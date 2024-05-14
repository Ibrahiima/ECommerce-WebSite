using AutoMapper;
using DTOs;
using ECommerceWebAPI;
using Models;
using Repository;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<UserDTOs>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<List<UserDTOs>>(entities);
        }

        public async Task<UserDTOs> GetByIdAsync(string id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return _mapper.Map<UserDTOs>(entity);
        }
        

        public async Task<UserDTOs> CreateAsync(UserDTOs dto)
        {
            var entity = _mapper.Map<User>(dto); 
            entity = await _repository.CreateAsync(entity);
            return _mapper.Map<UserDTOs>(entity);
        }

        public async Task UpdateAsync(UserDTOs dto)
        {
            var entity = _mapper.Map<User>(dto); 
            await _repository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}

