using Nomadwork.Domain.Shared;
using Nomadwork.ViewObject.Shared;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nomadwork.Domain.User
{
    public class User : ADommain
    {
        public User(string name, string email, string password, DateTime dateborn, Gender gender)
        {
            if (CheckEntryOk(new string[] { name, email, password })
                && CheckEntryOk(dateborn))
            {
                Name = name;
                Email = email;
                Password = password;
                Dateborn = dateborn;
                Gender = gender;
            }
        }

        public static User Create(string name, string email, string password, DateTime dateborn, Gender gender)
            => new User(name, email, password, dateborn, gender);


        public string Name { get; private set; }

        public string Email { get; private set; }

        public string Password { get; private set; }

        public DateTime Dateborn { get; private set; }

        public Gender Gender { get; private set; }



        private bool CheckEntryOk(DateTime dateborn)
        {
            var ok = true;

            if ((dateborn.Year - DateTime.Now.Year) < 18)
            {
                AddErro("Apenas para maiores de idade!");
                ok = false;
            }

            if ((dateborn.Year - DateTime.Now.Year).Equals(18)
                && (dateborn.Month < DateTime.Now.Month))
            {
                AddErro("Apenas para maiores de idade!");
                ok = false;
            }

            if ((dateborn.Year - DateTime.Now.Year).Equals(18)
                && (dateborn.Month >= DateTime.Now.Month)
                && dateborn.Day < DateTime.Now.Day)
            {
                AddErro("Apenas para maiores de idade!");
                ok = false;
            }

            return ok;
        }

        private bool CheckEntryOkEmail(string email)
            => new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$").IsMatch(email);


        private bool CheckEntryOkName(string name)
            => !string.IsNullOrWhiteSpace(name) 
                && name.Contains(" ") 
                && name.Length > 10;

        private bool CheckEntryOkPassword(string password) 
        {
            var ok = true;

            if (password.Length < 5)
            {
                AddErro("Informe senha com ao menos 5 dígitos!");
                ok = false;
            }

            if (password.Length > 20)
            {
                AddErro("Informe senha com menos de 20 dígitos!");
                ok = false;
            }

            if (!new Regex(@"^[a-zA-Z0-9]+$").IsMatch(password))
            {
                AddErro("Sua senha deve conter ao menos um caracter especial!");
                ok = false;
            }

            if (password.ToCharArray().Any(char.IsNumber))
            {
                AddErro("Sua senha deve conter ao menos um numero!");
                ok = false;
            }

            if (password.ToCharArray().Any(char.IsLower))
            {
                AddErro("Sua senha deve conter ao menos uma letra minúscula!");
                ok = false;
            }

            if (password.ToCharArray().Any(char.IsUpper))
            {
                AddErro("Sua senha deve conter ao menos uma letra maiúsclula!");
                ok = false;
            }

            return ok;

        }

        protected override bool CheckEntryOk(string[] args)
        {
            var name = args[0];
            var email = args[1];
            var password = args[2];
            var ok = true;

            if (CheckEntryOkName(name))
            {
                AddErro("Informe um nome válido!");
                ok = false;
            }

            if (CheckEntryOkEmail(email))
            {
                AddErro("Informe um email válido!");
                ok = false;
            }

            //if (CheckEntryOkPassword(password))
            //{
            //    ok = false;
            //}

          

            return ok;
        }
    }
}
