using ExamDapper.Data.Repository;
using ExamDapper.Domain.Entities;
using ExamDapper.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDapper.Service.Services
{
    public class SingerService : ISingerService
    {
        SingerRepository singerRepository = new SingerRepository();
        public async Task CreateAsync(Singer singer)
        {
            string query = $"insert into Singer(Fullname, CreatedDate) values('{singer.Fullname}', '{singer.CreatedDate}')";
            await singerRepository.CreateAsync(query);
        }

        public async Task DeleteAsync(int id)
        {
            string query = $"delete from Singer where id = {id}";
            await singerRepository.DeleteAsync(query);
        }

        public async Task<IEnumerable<Singer>> GetAllAsync(Func<Singer, bool> pred = null)
        {
            return await singerRepository.GetAllAsync(pred);
        }

        public async Task<Singer> GetAsync(Func<Singer, bool> pred)
        {
            return await singerRepository.GetAsync(pred);
        }

        public async Task UpdateAsync(Singer singer)
        {
            string query = $"update Singer set Fullname = '{singer.Fullname}', " +
                $"CreatedData = '{singer.CreatedDate}' " +
                $"where id = {singer.Id}";
            await singerRepository.UpdateAsync(query);
        }
    }
}
