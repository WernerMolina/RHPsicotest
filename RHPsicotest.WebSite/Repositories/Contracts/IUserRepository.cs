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
        //Crud User
        public Task<bool> AddUser(UserVM user);
        public Task<bool> UpdateUser(UserUpdateVM user);
        public Task<bool> DeleteUser(int id);

        //Get User
        public Task<UserUpdateVM> GetUserUpdate(int id);

        public Task<List<User>> GetAllUsers();

        public Task<bool> UserExists(string email, int id = 0);

        //Get Role
        public Task<List<Role>> GetAllRoles();
    }
}
