namespace Nomadwork.Infra.Repository
{
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
