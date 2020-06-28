﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookWeb.Entities;
namespace BookWeb.Interface
{
    public interface IUser
    {
        User Authenticate(string username, string password);
        User Create(User user, string password);
        Task<bool> Update(User user, string password = null);
        //Implement these as before
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(int Id);
        Task<bool> Delete(int Id);

    }
}
