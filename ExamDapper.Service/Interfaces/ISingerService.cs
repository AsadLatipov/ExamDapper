using ExamDapper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDapper.Service.Interfaces
{
    public interface ISingerService
    {
        Task CreateAsync(Singer singer);
        Task<Singer> GetAsync(Func<Singer, bool> pred);
        Task<IEnumerable<Singer>> GetAllAsync(Func<Singer, bool> pred=null);
        Task UpdateAsync(Singer singer);
        Task DeleteAsync(int id);

    }
}
