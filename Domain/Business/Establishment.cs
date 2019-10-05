using Nomadwork.Domain.Shared;
using Nomadwork.Domain.Location;
using System.Linq;
using System;

namespace Nomadwork.Domain.Business
{
    public class Establishmment : ADommain
    {
        private Establishmment(string name, string email, string phone, DateTime timeOpen, DateTime timeClose, short wifi, short noise, short plug)
        {
            if (CheckEntryOk(new string[] { name,  email, phone  }) 
                  && CheckEntryOkSchedule( timeOpen,  timeClose)
                && CheckEntryOkCharacteristic(wifi, noise, plug))
            {
                Name = name;
                Timeopen = timeOpen;
                Timeclose = timeClose;
                Wifi = wifi;
                Noise = noise;
                Plug = plug;
                Phone = phone;
                Email = email;
            }
        }

       

        public string Name { get; private set; }
        public DateTime Timeopen { get; private set; }
        public DateTime Timeclose { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public short Wifi { get; private set; }
        public short Noise { get; private set; }
        public short Plug { get; private set; }
        public Address Address { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="timeOpen"></param>
        /// <param name="timeClose"></param>
        /// <returns>**Retorna um novo objeto** ***Establishmment***</returns>
        public static Establishmment Create(string name, string email, string phone, DateTime timeOpen, DateTime timeClose, short wifi, short noise, short plug)
            => new Establishmment(name, email, phone, timeOpen, timeClose, wifi,  noise,  plug);

        public void SetAddress(Address address)
            => this.Address = address;

        private bool CheckEntryOkSchedule(DateTime timeOpen, DateTime timeClose)
        { var ok = true;

            if ((timeClose.Hour - timeOpen.Hour) < 3)
            {
                AddErro("O estabelecimento precisa ficar aberto ao menos 3 horas para ser sugerido!");
                ok = false;
            }

            if (!CheckEntryOkSchedule(timeOpen, "abertura"))
            {
                ok = false;
            }

            if (!CheckEntryOkSchedule(timeClose, "fechamento"))
            {
                ok = false;
            }

            return ok;
        }

        private bool CheckEntryOkSchedule(DateTime time, string type)
        {
           var ok = true;

            if (time.Hour > 23 || time.Hour < 0 )
            {
                AddErro(string.Format("Horário de {0} inválido, indique entre 0 e 23 horas!",type));
                ok = false;
            }
                
            if (time.Minute < 0 || time.Minute > 59 )
            {
                AddErro(string.Format("Horário de {0} inválido, indique entre 0 e 23 minutos!",type));
                 ok = false;
            }

            return ok;
        }


        private bool CheckEntryOkCharacteristic(short charc,string type)
        {
            var ok = true;
            if (charc > 3 || charc < 0)
            {
                AddErro(string.Format("este valor não é válido para {0}, no máximo 3",type));
                ok = false;
            }
            return ok;
        }
            
        private bool CheckEntryOkCharacteristic(short wifi, short noise, short plug)
        {
            var ok = true;

            if (!CheckEntryOkCharacteristic(wifi, "wifi"))
            {
                ok = false;
            }

            if (!CheckEntryOkCharacteristic(noise, "noise"))
            {
                ok = false;
            }
             
            if (!CheckEntryOkCharacteristic(plug, "plug"))
            {
                ok = false;
            }
           
            return ok;
        }

        private bool CheckEntryOkName(string name)
        {
            var ok = true;
            if (string.IsNullOrEmpty(name))
            {
                AddErro("Nome pode ser vazio");
                ok = false;
            }

            if (!string.IsNullOrEmpty(name) && name.Length > 99)
            {
                AddErro("Este Nome é muito Grande, utilize abreviações!");
                ok = false;
            }
             
            if (!string.IsNullOrEmpty(name) && (name.Contains("  ")))
            {
                AddErro("Este Nome não parece estar correto, retire os espaços duplos!");
                ok = false;
            }

            if (!string.IsNullOrEmpty(name) && name.Any(x => !char.IsLetterOrDigit(x) && !char.IsWhiteSpace(x)))
            {
                AddErro("Este Nome possui caracteres, informe apenas letras e números!");
                ok = false;
            }
            return ok;
        }


        private bool CheckEntryOkEmail(string email)
        {
            var ok = true;
            if (string.IsNullOrEmpty(email))
            {
                AddErro("Informe um email válido!");
                ok = false;
            }

            if (!string.IsNullOrEmpty(email) && email.Contains(" "))
            {
                AddErro("Email com espaço não existe!");
                ok = false;
            }

            if (!string.IsNullOrEmpty(email) && email.Length > 100)
            {
                AddErro("Este email está bem grande, faça outro!");
                ok = false;
            }
             
            if (!string.IsNullOrEmpty(email) && !email.Contains("@") && !email.Contains("."))
            {
                AddErro("Este email não é válido!");
                ok = false;
            }

            return ok;
        }

        private bool CheckEntryOkPhone(string phone)
        {
            var ok = true;

            if (string.IsNullOrEmpty(phone))
            {
                AddErro("Informe um número de telefone válido!");
                ok = false;
            }

            if (!string.IsNullOrEmpty(phone) && (phone.Length < 8))
            {
                AddErro("Esta faltando dígitos no número do seu telefone!");
                ok = false;
            }
            
            if (!string.IsNullOrEmpty(phone) && (phone.Length > 15))
            {
                AddErro("Esta sobrando dígitos no número do seu telefone!");
                ok = false;
            }
                
            if (!string.IsNullOrEmpty(phone) && phone.Contains(" "))
            {
                AddErro("Não existem números de telefone com espaço!");
                ok = false;
            }

            return ok;
        }


        protected override bool CheckEntryOk(string[] args)
        {
            var ok = true;
            var name = args[0];
            var email = args[1];
            var phone = args[2];

            if (!CheckEntryOkName(name))
            {
                ok = false;
            }

            if (!CheckEntryOkEmail(email))
            {
                ok = false;
            }

            if (!CheckEntryOkPhone(phone))
            {
                ok = false;
            }

            return ok;
        }

        
    }
}