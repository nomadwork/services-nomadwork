using System.Collections.Generic;

namespace Nomadwork.Domain.Shared
{
    public abstract class ADommain
    {
        /// <summary>
        /// **Este Objeto possui erro de validação caso esta propriedade seja:** ***true***
        /// </summary>
        public bool Erro { get; private set; } = false;


        /// <summary>
        /// /// **Contém lista de todos os erros de validação deste Objeto**
        /// </summary>
        /// <typeparam name="string"></typeparam>
        /// <returns></returns>S
        public List<string> Erros { get; private set; } = new List<string>();

        /// <summary>
        /// **Adiciona um erro de validação a este objeto.**
        /// <para>*Torana a propriedade* ***Erro=true***</para>
        /// </summary>
        /// <param name="error">*Descrição do erro*</param>
        public void AddErro(string error)
        {
            Erro = true;
            Erros.Add(error);
        }

        /// <summary>
        /// **Adiciona vários erros de validação a este objeto.**
        /// </summary>
        /// <param name="error">*Descrição dos erros*</param>
        public void AddErro(List<string> errors)
        {
            Erro = true;
            Erros.AddRange(errors);
        }

        /// <summary>
        /// **Verifica se o conjunto de parâmentros informados atendem a regra de negócio.**
        /// <code>new string[]{param1,param2,param3,...}</code>
        /// </summary>
        /// <param name="args">*new string[]{param1,param2,param3,...}*</param>
        abstract protected bool CheckEntryOk(string[] args);

    }
}