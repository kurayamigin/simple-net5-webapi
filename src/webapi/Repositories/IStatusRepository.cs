using System.Collections.Generic;
using System.Threading.Tasks;
using webapi.Modules;

namespace webapi.Repositories
{
    public interface IStatusRepository
    {
        Task<List<Status>> FindAll();
        Task<Status?> FindById(int id);
        void Insert(Status status);
        Task Delete(int id);
        void Update(Status status);
        Task<int> Save();
    }
}