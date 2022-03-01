using ExamDapper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDapper.Service.Interfaces
{
    public interface IMusicSerice
    {
        Task CreateAsync(Music singer);
        Task<Music> GetAsync(Func<Music, bool> pred);
        Task<IEnumerable<Music>> GetAllAsync(int pageSize, int pageIndex, Func<Music, bool> pred = null);
        Task UpdateAsync(Music singer);
        Task DeleteAsync(int id);
    }
}
