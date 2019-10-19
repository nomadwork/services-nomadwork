using Microsoft.EntityFrameworkCore;
using Nomadwork.Infra.Data.Contexts;
using Nomadwork.Infra.Data.ObjectData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nomadwork.Infra.Repository
{
    public class EstablishmmentRepository
    {
        private readonly NomadworkDbContext _context;

        private EstablishmmentRepository(NomadworkDbContext context)
        {
            _context = context;
        }

        internal static EstablishmmentRepository GetInstance(NomadworkDbContext context)
            => new EstablishmmentRepository(context);


        internal IEnumerable<EstablishmmentModelData> GetByLocation(decimal latitude, decimal longitude)
            => _context.Establishments
                       .Include(x => x.Address)
                       .Where(establismment
                => (establismment.Address.LatitudePrecision.Equals(decimal.Round(latitude, 1))
                    && establismment.Address.LongitudePricision.Equals(decimal.Round(longitude, 1)))
                     && establismment.Active)
                    .ToHashSet()
                    .Take(20)
                    .ToList();

        internal IEnumerable<EstablishmmentModelData> GetByFilter(string select)
            => _context.Establishments
                        .Include(x => x.Address)
                        .Where(x => x.Active
                        && (x.Name.Contains(select)
                        || x.Address.Street.Contains(select)
                        || x.Address.Zipcode.StartsWith(select)))
                        .ToHashSet()
                        .Take(20)
                        .ToList();


        internal EstablishmmentModelData GetById(long id)
             => _context.Establishments
                                    .Include(x => x.Address)
                                    .Include(x => x.Photos)
                                    .FirstOrDefault(establisshment => establisshment.Id.Equals(id) && establisshment.Active);

        internal IEnumerable<EstablishmmentModelData> GetAll()
            => _context.Establishments.ToList();



        internal void DeleteAll()
        {
            var all = GetAll();

            all.ToList().ForEach(async x =>
            {
                await Delete(x);
            });

        }


        internal async Task<ReturnRepository> CreateSingle(EstablishmmentModelData establishmentModelData)
        {
            try
            {
                _context.Establishments.Add(establishmentModelData);
                await _context.SaveChangesAsync();
                return ReturnRepository.Create(false, string.Format("Estabelecimento {0} salvo com sucesso!", establishmentModelData.Name));
            }
            catch (Exception ex)
            {
                return ReturnRepository.Create(true, string.Format("Erro ao salvar o estabelecimento {0}! Analise o erro: {1}", establishmentModelData.Name, ex.InnerException));
            }

        }

        internal async Task<ReturnRepository> CreateSingle(EstablishmmentSugestionModelData establishmentModelData)
        {
            try
            {
                _context.EstablishmentSugestions.Add(establishmentModelData);
                await _context.SaveChangesAsync();
                return ReturnRepository.Create(false, string.Format("Estabelecimento {0} salvo com sucesso!", establishmentModelData.Name));
            }
            catch (Exception ex)
            {
                return ReturnRepository.Create(true, string.Format("Erro ao salvar o estabelecimento {0}! Analise o erro: {1}", establishmentModelData.Name, ex.InnerException));
            }

        }

        internal async Task<ReturnRepository> Update(EstablishmmentModelData establishmentModelData)
        {
            try
            {
                _context.Entry(establishmentModelData).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (Exists(establishmentModelData.Id))
                {
                    return ReturnRepository.Create(true, string.Format("Erro ao salvar o estabelecimento {0}!\n Analise o erro: {1}", establishmentModelData.Name, ex.Message));
                }
            }

            return ReturnRepository.Create(false, string.Format("Estabelecimento {0} alterado com sucesso!", establishmentModelData.Name));

        }


        internal async Task<ReturnRepository> Delete(EstablishmmentModelData establishmentModelData)
        {
            establishmentModelData.Active = false;

            return await Update(establishmentModelData);
        }


        private bool Exists(long id)
        {
            return _context.Establishments.Any(e => e.Id == id);
        }

        //mok
        internal async Task<ReturnRepository> CreateMok(List<EstablishmmentModelData> establishmentModelData)
        {
            try
            {
                _context.Establishments.AddRange(establishmentModelData);
                await _context.SaveChangesAsync();
                return ReturnRepository.Create(false, "Estabelecimentos salvo com sucesso!");

            }
            catch (Exception ex)
            {
                return ReturnRepository.Create(true, string.Format("Erro ao salvar o estabelecimento ! Analise o erro: {0} ", ex.InnerException));
            }

        }

    }

    internal struct ReturnRepository
    {
        public static ReturnRepository Create(bool erro, string description)
        => new ReturnRepository(erro, description);

        private ReturnRepository(bool erro, string description)
        {
            Erro = erro;
            Description = description;
        }

        public bool Erro { get; private set; }
        public string Description { get; set; }

    }
}
