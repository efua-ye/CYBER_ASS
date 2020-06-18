using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookAPI.Entities;

namespace BookAPI.Interface
{
    public interface IReader
    {
        void Add(Reader reader);
        Task<bool> AddAsync(Reader reader);
        Task<bool> Update(Reader reader);
        Task<IEnumerable<Reader>> GetAll();
        Task<Reader> GetById(int Id);
        Task<bool> Delete(int Id);
    }
}
