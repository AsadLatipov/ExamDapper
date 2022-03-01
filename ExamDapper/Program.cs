using ExamDapper.Service.Services;
using System;
using System.Threading.Tasks;

namespace ExamDapper
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            SingerService singerService = new SingerService();
            var res = await singerService.GetAsync(x => x.Id == 2);
            Console.WriteLine(res.Fullname);
        }
    }
}
