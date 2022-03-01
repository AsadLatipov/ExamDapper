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
    public class MusicRepository : GenericRepository<Music>, IMusicRepository
    {
        protected IDbConnection db;
        public MusicRepository()
        {
            db = GetConnection();
        }
        public async Task<IEnumerable<Music>> GetAllAsync(Func<Music, bool> pred =null)
        {
            string query = "select * from Music inner join Singer on Singer.id = music.singerId" +
                " inner join Playlist on Playlist.id = music.playlistid";
            var res = await db.QueryAsync<Music>(query);

            return pred == null ? res : res.Where(pred);
        }

        public async Task<Music> GetAsync(Func<Music, bool> pred)
        {
            string query = "select * from Music inner join Singer on Singer.id = music.singerId" +
                " inner join Playlist on Playlist.id = music.playlistid";
            var res = await db.QueryAsync<Music>(query);

            return res.Where(pred).FirstOrDefault();
        }

        

        
    }
}
