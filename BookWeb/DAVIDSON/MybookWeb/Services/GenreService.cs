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
    public class GenreService : IGenre
    {
        private MybookWebDataContext _context;

        public GenreService(MybookWebDataContext context)
        {
            _context = context;
        }
        public void Add(Genre genre)
        {
            genre.DateCreated = DateTime.Now;
            _context.Add(genre);
            _context.SaveChanges();
        }

        public async Task<bool> AddAsync(Genre genre)
        {
            try
            {
                await _context.AddAsync(genre);
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
            var genre = await _context.Genres.FindAsync(Id);

            if (genre != null)
            {
                _context.Genres.Remove(genre);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public async Task<IEnumerable<Genre>> GetAll()
        {
            return await _context.Genres.ToListAsync();
        }

        public async Task<Genre> GetById(int Id)
        {
            var genre = await _context.Genres.FindAsync(Id);

            return genre;
        }

        public async Task<bool> Update(Genre genre)
        {
            var aut = await _context.Genres.FindAsync(genre.Id);
            if (aut != null)
            {

                aut.Name = genre.Name;
                aut.CreatedBy = genre.CreatedBy;
                

                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}
