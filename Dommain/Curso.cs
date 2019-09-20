using System.Collections.Generic;

namespace Nomadwork.Dommain
{
    public class Curso : Entidade
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public List<Conteudo> ConteudoProgramatico { get; set; }
    }
}