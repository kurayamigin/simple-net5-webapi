using System.Collections.Generic;
using System.Threading.Tasks;
using webapi.Dto;
using webapi.Modules;

namespace webapi.Services
{
    public interface IStatusService
    {
        Task<List<StatusDto>> FindAll();
        Task<StatusDto?> FindById(int id);
        Task Insert(StatusDto status);
        Task Delete(int id);
        void Update(StatusDto status);
        Task<int> Save();
    }
}