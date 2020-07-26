﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MybookWeb.Dtos;
using MybookWeb.Entities;

namespace MybookWeb.Interface
{
    public interface IAccount
    {
        Task<bool> CreateUser(ApplicationUser user, string password);
        Task<SignInModel> SignIn(LoginDto loginDetails);
        Task<bool> Update(ApplicationUser AppUser); 
        Task<List<ApplicationUser>> GetAll();
        Task<ApplicationUser> GetById(String Id);
        Task<bool> Delete(String Id);
    }
}
