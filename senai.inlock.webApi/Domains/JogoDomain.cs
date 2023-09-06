namespace senai.inlock.webApi.Domains
{
    /// <summary>
    /// Classe que representa a entidade(tabela) Jogo
    /// </summary>
    public class JogoDomain
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public DateTime DataLancamento { get; set; }

        public float valor { get; set; }

        //Referência para a classe Estudio
        public EstudioDomain estudio { get; set; }
    }
}
