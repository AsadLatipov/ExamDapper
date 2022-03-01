using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDapper.Data.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        public IDbConnection GetConnection();
        Task<T> GetAsync (string query, DynamicParameters pars=null, CommandType command = CommandType.Text);
        Task<IEnumerable<T>> GetAllAsync(string query, DynamicParameters pars = null, CommandType command = CommandType.Text);
        Task<T> CreateAsync(string query, DynamicParameters pars = null, CommandType command = CommandType.Text);
        Task<T> DeleteAsync(string query, DynamicParameters pars = null, CommandType command = CommandType.Text);
        Task<T> UpdateAsync(string query, DynamicParameters pars = null, CommandType command = CommandType.Text);
    }
}
