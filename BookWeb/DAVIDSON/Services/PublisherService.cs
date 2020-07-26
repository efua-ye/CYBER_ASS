using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MybookWeb.Data;
using MybookWeb.Entities;
using MybookWeb.Interface;

namespace MybookWeb.Services
{
    public class PublisherService : IPublisher
    {
        private MybookWebDataContext _context;
        public PublisherService(MybookWebDataContext context)
        {
            _context = context;
        }
        public void Add(Publisher pub)
        {
            //pub.DateCreated = DateTime.Now;
            _context.Add(pub);
            _context.SaveChanges();
        }

        public async Task<bool> AddAsync(Publisher pub)
        {
            try
            {
                await _context.AddAsync(pub);
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
            var pub = await _context.Publishers.FindAsync(Id);

            if (pub != null)
            {
                _context.Publishers.Remove(pub);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public async Task<IEnumerable<Publisher>> GetAll()
        {
            return await _context.Publishers.ToListAsync();
        }

        public async Task<Publisher> GetById(int Id)
        {
            var pub = await _context.Publishers.FindAsync(Id);

            return pub;
        }

        public async Task<bool> Update(Publisher pub)
        {
            var aut = await _context.Publishers.FindAsync(pub.Id);
            if (aut != null)
            {
                aut.Name = pub.Name;

                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}
