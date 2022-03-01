using Dapper;
using ExamDapper.Data.IRepository;
using ExamDapper.Data.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDapper.Data.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T :class
    {
        public async Task<T> CreateAsync(string query, DynamicParameters pars = null, CommandType command = CommandType.Text)
        {
            IDbConnection db = GetConnection();
            var res = await db.QueryAsync<T>(query, param: pars, commandType: command);
            return res.FirstOrDefault();
        }

        public async Task<T> DeleteAsync(string query, DynamicParameters pars = null, CommandType command = CommandType.Text)
        {
            IDbConnection db = GetConnection();
            var res = await db.QueryAsync<T>(query, param: pars, commandType: command);
            return res.FirstOrDefault();
        }


        public async Task<IEnumerable<T>> GetAllAsync(string query, DynamicParameters pars = null, CommandType command = CommandType.Text)
        {
            IDbConnection db = GetConnection();
            return  await db.QueryAsync<T>(query, param: pars, commandType: command);
        }

        public async Task<T> GetAsync(string query, DynamicParameters pars = null, CommandType command = CommandType.Text)
        {
            IDbConnection db = GetConnection();
            var res = await db.QueryAsync<T>(query, param: pars, commandType: command);
            return res.FirstOrDefault();
        }

        public IDbConnection GetConnection()
        {
            return new SqlConnection(Constants.EXAMCON);
        }

        public async Task<T> UpdateAsync(string query, DynamicParameters pars = null, CommandType command = CommandType.Text)
        {
            IDbConnection db = GetConnection();
            var res = await db.QueryAsync<T>(query, param: pars, commandType: command);
            return res.FirstOrDefault();
        }
    }
}
