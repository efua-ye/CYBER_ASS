using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookWeb.Data;
using BookWeb.Entities;
using BookWeb.Interface;
using Microsoft.EntityFrameworkCore;

namespace BookWeb.Services
{
    public class ReaderService : IReader
    {
        private BookWebDataContext _context;
        public ReaderService(BookWebDataContext context)
        {
            _context = context;
        }
        public void Add(Reader reader)
        {
            _context.Add(reader);
            _context.SaveChanges();
        }
        public async Task<bool> AddAsync(Reader reader)
        {
            try
            {
                await _context.AddAsync(reader);
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
            // find the entity/object
            var reader = await _context.Readers.FindAsync(Id);

            if (reader != null)
            {
                _context.Readers.Remove(reader);
                _context.SaveChanges();
                return true;
            }

            return false;
        }
        public async Task<IEnumerable<Reader>> GetAll()
        {

            return await _context.Readers.ToListAsync();
        }

        public async Task<Reader> GetById(int Id)
        {
            var reader = await _context.Readers.FindAsync(Id);

            return reader;
        }

        public async Task<bool> Update(Reader reader)
        {
            var _reader = await _context.Readers.FindAsync(reader.Id);
            if (_reader != null)
            {
                _reader.Name = reader.Name;
                _reader.FavouriteAuthor = reader.FavouriteAuthor;

                await _context.SaveChangesAsync();
                return true;
            }

            return false;

        }

    }
}
