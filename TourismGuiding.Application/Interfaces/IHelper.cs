using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.Places.Queries.GetAll;
using TourismGuiding.Application.Features.Places.Queries.GetAllByTourismId;
using TourismGuiding.Entities;
using TourismGuiding.Entities.Images;
using TourismGuiding.Entities.NewFolder;
using TourismGuiding.Entities.Services;

namespace TopTeacher.Application.Interfaces
{
    public interface IHelper
    {
       
        Task<IEnumerable<ImageUrlOfCOrP>> GetImagesOfCity(int CityId);

        Task<IEnumerable<ImageUrlOfCOrP>> GetImagesOfPlace(int CityId);

        Task<IEnumerable<PlacesGetAllByCityIdResponse>> GetPlacesById(int id);

        Task<IEnumerable<Department>> GetDepartmentsById(int id);

        Task<IEnumerable<Service>> GetServicesById(int id);

        Task<IEnumerable<PlacesGetAllByTourismIdResponse>> GetPlacesByTourismId(int id);

        Task<string> GetTourismName(string id);
    }
}
