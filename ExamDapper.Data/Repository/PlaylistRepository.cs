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
    public class PlaylistRepository : GenericRepository<Playlist>, IPlaylistRepository
    {
        protected IDbConnection db;
        public PlaylistRepository()
        {
            db = GetConnection();
        }
        public async Task<IEnumerable<Playlist>> GetAllAsync(Func<Playlist, bool> pred = null)
        {
            string query = "select * from Music";
            var res = await db.QueryAsync<Playlist>(query);

            return pred == null ? res : res.Where(pred);
        }

        public async Task<Playlist> GetAsync(Func<Playlist, bool> pred)
        {
            string query = "select * from Music";
            var res = await db.QueryAsync<Playlist>(query);
            return res.Where(pred).FirstOrDefault();
        }
    }
}
