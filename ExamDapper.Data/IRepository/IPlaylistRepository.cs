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
    public interface IPlaylistRepository
    {
        public IDbConnection GetConnection();
        Task<IEnumerable<Playlist>> GetAllAsync(Func<Playlist, bool> pred = null);
        Task<Playlist> GetAsync(Func<Playlist, bool> pred);
    }
}
