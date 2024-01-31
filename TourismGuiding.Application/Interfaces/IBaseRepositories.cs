using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.ResponseGeneration;

namespace TourismGuiding.Application.Interfaces
{
    public interface IBaseRepositories<T>
    {
        // Create
        Task<ResponseGeneral> AddAsync(T entity);

        // Read
        Task<T> GetByIdAsync(int id);

        // Get all By Id

       //Task<IEnumerable<T>> GetAllByIdAsync(int id);

        // Get all
        Task<IEnumerable<T>> GetAllAsync();

        // Update
        Task<ResponseGeneral> UpdateAsync(T entity);

        // Delete
        Task<ResponseGeneral> DeleteAsync(int id);

    }
}
