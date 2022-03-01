using Dapper;
using ExamDapper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDapper.Data.IRepository
{
    public interface IMusicRepository
    {
        public IDbConnection GetConnection();
        Task<IEnumerable<Music>> GetAllAsync(Func<Music, bool> pred = null);
        Task<Music> GetAsync(Func<Music, bool> pred);
    }
}
