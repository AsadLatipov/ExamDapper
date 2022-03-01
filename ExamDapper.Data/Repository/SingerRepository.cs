using Dapper;
using ExamDapper.Data.IRepository;
using ExamDapper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDapper.Data.Repository
{
    public class SingerRepository : GenericRepository<Singer>,  ISingerRepository
    {
        protected IDbConnection db;
        public SingerRepository()
        {
            db = GetConnection();
        }
        
        public async Task<IEnumerable<Singer>> GetAllAsync(Func<Singer, bool> pred = null)
        {
            string query = "select * from Singer";
            var res = await db.QueryAsync<Singer>(query);

            return pred == null ? res : res.Where(pred);
        }

        public async Task<Singer> GetAsync(Func<Singer, bool> pred)
        {
            string query = "select * from Singer";
            var res = await db.QueryAsync<Singer>(query);
            return res.Where(pred).FirstOrDefault();
        }
    }
}
