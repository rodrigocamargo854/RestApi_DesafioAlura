using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Users;

namespace Api.Service.Services
{
    //?Classe criada com os serviços em especifico ao usuário
    //?Regras de negócio
    //*Todos os metodos estão implmentados 

    public class VideosServices : IVideoServices
    {
        //*Repositorio para usuários
        private IRepository<VideosEntities> _repository;
        //*    //*Todos os metodos estão implmentados 
        public VideosServices(IRepository<VideosEntities> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<VideosEntities> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<VideosEntities>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<VideosEntities> Post(VideosEntities film)
        {
            return await _repository.InsertAsync(film);
        }

        public async Task<VideosEntities> Put(VideosEntities film)
        {
            return await _repository.UpdateAsync(film);
        }
    }
}
