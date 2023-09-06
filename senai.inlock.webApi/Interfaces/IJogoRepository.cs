using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório JogoRepository
    /// Definir os métodos que serão implementados pelo JogoRepository
    /// </summary>
    public interface IJogoRepository
    {
        //TipoRetorno NomeMetodo(TipoParâmetro NomeParâmetro)

        /// <summary>
        /// Cadastrar um novo Jogo
        /// </summary>
        /// <param name="novoJogo">Objeto que será cadastrado</param>
        void Cadastrar(JogoDomain novoJogo);

        /// <summary>
        /// Listar todos os objetos cadastrados
        /// </summary>
        /// <returns>Lista com os objetos</returns>
        List<JogoDomain> ListarTodos();
    }
}
