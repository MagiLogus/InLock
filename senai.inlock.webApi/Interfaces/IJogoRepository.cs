using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório JogoRepository
    /// Definir os métodos que serão implementados pelo JogoRepository
    /// </summary>
    public interface IJogoRepository
    {
        /// <summary>
        /// Cadastrar um novo jogo
        /// </summary>
        /// <param name="novoJogo">este parametro e o objeto que sera cadastrado</param>
        void Cadastrar(JogoDomain novoJogo);

        /// <summary>
        /// Listar todos os objetos Jogos cadastrados
        /// </summary>
        /// <returns>Lista com os objetos</returns>
        List<JogoDomain> ListarTodos();

        /// <summary>
        /// Deletar um objeto Estudio
        /// </summary>
        /// <param name="id">Id do objeto que será deletado</param>
        void Deletar(int id);
    }
}
