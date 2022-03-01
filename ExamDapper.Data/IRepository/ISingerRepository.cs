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
    public interface ISingerRepository 
    {
        public IDbConnection GetConnection();
        Task<IEnumerable<Singer>> GetAllAsync(Func<Singer, bool> pred = null);
        Task<Singer> GetAsync(Func<Singer, bool> pred);
    }
}
