namespace senai.inlock.webApi.Domains
{
    /// <summary>
    /// Classe que representa a entidade(tabela) Usuario
    /// </summary>
    public class UsuarioDomain
    {
        public string Email { get; set; }

        public string Senha { get; set; }

        //Referência para a classe TiposUsuario
        public TiposUsuarioDomain tiposUsuario { get; set; }
    }
}
