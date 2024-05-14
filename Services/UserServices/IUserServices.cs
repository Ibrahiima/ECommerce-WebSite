using DTOs;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IUserService
    {
        Task<List<UserDTOs>> GetAllAsync();
        Task<UserDTOs> GetByIdAsync(string id);
       

        Task<UserDTOs> CreateAsync(UserDTOs dto);
        Task UpdateAsync(UserDTOs dto);
        Task DeleteAsync(int id);
    }

}
