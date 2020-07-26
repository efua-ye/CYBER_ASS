﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MybookWeb.Data;
using MybookWeb.Entities;
using MybookWeb.Interface;

namespace MybookWeb.Services
{
    public class CategoryService : ICategory
    {
        private MybookWebDataContext _context;
        public CategoryService(MybookWebDataContext context)
        {
            _context = context;
        }
        public void Add(Category category)
        {
            category.DateCreated = DateTime.Now;
            _context.Add(category);
            _context.SaveChanges();
        }

        public async Task<bool> AddAsync(Category category)
        {
            try
            {
                await _context.AddAsync(category);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> Delete(int Id)
        {
            var category = await _context.Category.FindAsync(Id);

            if (category != null)
            {
                _context.Category.Remove(category);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _context.Category.ToListAsync();
        }

        public async Task<Category> GetById(int Id)
        {
            var category = await _context.Category.FindAsync(Id);

            return category;
        }

        public async Task<bool> Update(Category category)
        {
            var aut = await _context.Category.FindAsync(category.Id);
            if (aut != null)
            {

                aut.CategoryName = category.CategoryName;
                aut.CreatedBy = category.CreatedBy;
                

                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}
