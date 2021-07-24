using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Users
{
    //?Na camada domain criamos as interfaces para o usuario ou para 
    //?qual entidade necessitar. Metodos especificos que recebem o tipo 
    //?da entidade para
    //? Aqui criamos toda a regra de negocio.
    public interface IVideoServices
    {
        //*Retorna um usuario 
        Task<VideosEntities> Get(Guid id);
        //?Retorna uma lista de usuarios
        Task<IEnumerable<VideosEntities>> GetAll();
        Task<VideosEntities> Put(VideosEntities id);
        Task<VideosEntities> Post(VideosEntities id);
        Task<bool> Delete(Guid id);


    }
}
