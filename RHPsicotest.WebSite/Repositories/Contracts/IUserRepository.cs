using Microsoft.AspNetCore.Mvc.Rendering;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories.Contracts
{
    public interface IUserRepository
    {
        public Task<IEnumerable<User>> GetAllUsers();

        public Task<MultiSelectList> GetAllRoles();

        public Task<MultiSelectList> GetRolesSelected(int userId);

        public Task<User> GetUserWithRoles(int id);

        public Task<UserDTO> GetUserDTO(int id);

        public Task<User> AddUser(User user, List<int> roles);

        public Task<bool> UpdateUser(UserDTO user, List<int> roles);

        public Task<bool> DeleteUser(int id);

        public Task<UserDTO> GetUserLogin(Login userLogin);

    }
}
