using ExamDapper.Data.Repository;
using ExamDapper.Domain.Entities;
using ExamDapper.Service.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDapper.Service.Services
{
    public class MusicService : IMusicSerice
    {

        MusicRepository musicRepository = new MusicRepository();
        public async Task CreateAsync(Music music)
        { 
            string query = "insert into Music(Title, Description, SingerId, Length, PlaylistId, CreatedData) values" +
                $"('{music.Title}', '{music.Description}', {music.SingerId}, '{music.Length}', 1, '{music.CreatedDate}');";

            await musicRepository.CreateAsync(query);
        }

        public async Task DeleteAsync(int id)
        {
            string query = $"delete from Music where id = {id}";
            await musicRepository.DeleteAsync(query);
        }

        public async Task<IEnumerable<Music>> GetAllAsync(int pageSize, int pageIndex, Func<Music, bool> pred = null)
        {
            throw new NotImplementedException();
        }

        public async Task<Music> GetAsync(Func<Music, bool> pred)
        {
            return await musicRepository.GetAsync(pred);
        }

        public async Task UpdateAsync(Music singer)
        {
            await musicRepository.UpdateAsync("update");
        }
    }
    //return await groups.Skip(pageSize* (pageIndex - 1)).Take(pageSize).ToListAsync();
}
