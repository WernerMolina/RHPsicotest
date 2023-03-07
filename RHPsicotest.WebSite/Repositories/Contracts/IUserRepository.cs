using Microsoft.AspNetCore.Mvc.Rendering;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.ViewModels.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories.Contracts
{
    public interface IUserRepository
    {
        //Crud User
        public Task<bool> AddUser(UserVM user, List<int> rolesId);
        public Task<bool> UpdateUser(UserUpdateVM user, List<int> rolesId);
        public Task<bool> DeleteUser(int id);

        //Get User
        //public Task<UserDTO> GetUserDTO(int id);
        public Task<(UserUpdateVM, MultiSelectList)> GetUserAndRolesSelected(int id);

        //public Task<User> GetUserWithRoles(int id);
        public Task<IEnumerable<UserDTO>> GetAllUsers();
        //public Task<UserDTO> GetUserLogin(Login userLogin);

        //Get Role
        public Task<MultiSelectList> GetAllRoles();
        public Task<MultiSelectList> GetRolesSelected(List<int> rolesId);
    }
}
