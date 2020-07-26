using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MybookWeb.Dtos;
using MybookWeb.Entities;
using MybookWeb.Models;

namespace MybookWeb.Interface
{
    public interface IAccount
    {
        Task<bool> CreateUser(ApplicationUser user, string password);

        Task<SignInModel> SignIn(LoginDto loginDetails);

        Task<bool> LoginIn(LoginViewModel loginModel);
    }
}
