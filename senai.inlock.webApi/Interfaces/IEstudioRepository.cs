﻿using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório EstudioRepository
    /// Definir os métodos que serão implementados pelo EstudioRepository
    /// </summary>
    public interface IEstudioRepository
    {
        //TipoRetorno NomeMetodo(TipoParâmetro NomeParâmetro)

        /// <summary>
        /// Cadastrar um novo Estudio
        /// </summary>
        /// <param name="novoEstudio">Objeto que será cadastrado</param>
        void Cadastrar(EstudioDomain novoEstudio);

        /// <summary>
        /// Listar todos os objetos cadastrados
        /// </summary>
        /// <returns>Lista com os objetos</returns>
        List<EstudioDomain> ListarTodos();
    }
}
