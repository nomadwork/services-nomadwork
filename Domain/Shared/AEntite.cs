using System;
using System.Collections.Generic;

namespace services_nomadwork.Domain.Shared
{
    public abstract class AEntite
    {
        public string Id
        {
            get
            {
                return Guid.NewGuid().ToString().Substring(0, 6).ToUpper();
            }
        }
       
        public bool Erro { get; private set; }

        public List<string> Erros { get; private set; } = new List<string>();

        public void AddErro(string error)
        {
            Erro = true;
            Erros.Add(error);
        }
        public void AddErro(List<string> errors)
        {
            Erro = true;
            Erros.AddRange(errors);
        }

        abstract protected bool CheckEntryOk(string[] args);

    }
}