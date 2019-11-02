using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Nomadwork.Infra.Data.Contexts;
using Nomadwork.Infra.Data.ObjectData;
using Nomadwork.Infra.TokenGenerate;
using System;

namespace Nomadwork
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

#if !DEBUG
            var teste = new AuthorizationPolicyBuilder()
                             .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme‌​)
                             .RequireAuthenticatedUser()
                             .Build(); 
#endif

            services.AddMvc(
#if !DEBUG
              options =>
            {
                options.Filters.Add(new CustomAuthorizeFilter(teste));

            } 
#endif
            ).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddResponseCompression();

            services.AddDbContext<NomadworkDbContext>(options =>
                                                   options.UseMySql(
                                                   Configuration.GetConnectionString("DbConnectionProd")));
#if !DEBUG

            services.AddScoped<UserModelData>();
            services.AddScoped<EstablishmmentModelData>();

            var signingConfigurations = new SigningConfigurations();

            services.AddSingleton(signingConfigurations);

            var tokenConfiguration = new TokenConfiguration();

            new ConfigureFromConfigurationOptions<TokenConfiguration>(
                Configuration.GetSection("TokenConfigurations"))
                    .Configure(tokenConfiguration);

            services.AddSingleton(tokenConfiguration);

            services.AddAuthentication(authOptions =>
              {
                  authOptions.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                  authOptions.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

              }).AddJwtBearer(bearerOptions =>
              {
                  var paramsValidation = bearerOptions.TokenValidationParameters;
                  paramsValidation.IssuerSigningKey = signingConfigurations.Key;
                  paramsValidation.ValidAudience = tokenConfiguration.Audience;
                  paramsValidation.ValidIssuer = tokenConfiguration.Issuer;
                  paramsValidation.ValidateIssuerSigningKey = true;
                  paramsValidation.ValidateLifetime = true;
                  paramsValidation.ClockSkew = TimeSpan.FromMinutes(1);
              });

            services.AddAuthorization(auth =>
                   {
                       auth.AddPolicy("Bearer", teste);

                   }); 
#endif

            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public static void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

           
            app.UseMvc();

            app.UseResponseCompression();

#if !DEBUG
            app.UseAuthentication(); 
#endif

            app.UseSwagger()
                .UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "");
                c.RoutePrefix = string.Empty;
            });
        }
    }
}
