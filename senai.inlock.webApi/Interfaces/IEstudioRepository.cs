using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interfaces
{
    /// <summary>
    /// Interface responsavel pelo repositorio estudiosrepository
    /// define os metodos que serao implementados pelo repositorio
    /// </summary>
    public interface IEstudioRepository
    {
        /// <summary>
        /// Cadastrar um novo Estudio
        /// </summary>
        /// <param name="novoEstudio">este parametro e o objeto que sera cadastrado</param>
        void Cadastrar(EstudioDomain novoEstudio);
        
        /// <summary>
        /// Listar todos os objetos Estudio cadastrados
        /// </summary>
        /// <returns>Lista com os objetos</returns>
        List<EstudioDomain> ListarTodos();
       
        /// <summary>
        /// Deletar um objeto Estudio
        /// </summary>
        /// <param name="id">Id do objeto que será deletado</param>
        void Deletar(int id);
    }
}
