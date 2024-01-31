
using Microsoft.EntityFrameworkCore;
using TopTeacher.Application.Interfaces;
using TourismGuiding.Application.Features.Places.Queries.GetAll;
using TourismGuiding.Application.Features.Places.Queries.GetAllByTourismId;
using TourismGuiding.Entities.Images;
using TourismGuiding.Entities.Services;
using TourismGuiding.Persistance;

namespace TopTeacher.Persistance.Repositories
{
    public class HelperRepositories : IHelper
    {
        private readonly ApplicationDbContext context;


        public HelperRepositories(ApplicationDbContext context)
        {
            this.context = context;

        }


        public async Task<IEnumerable<ImageUrlOfCOrP>> GetImagesOfCity(int CityId)
        {
            var response = await context.imagesOfCities.Where(x => x.CityId == CityId)
                .Select(e => new ImageUrlOfCOrP { Id = e.Id, ImageUrl = e.ImageUrl }).ToListAsync();
            return response;
        }

        public async Task<IEnumerable<ImageUrlOfCOrP>> GetImagesOfPlace(int PlaceId)
        {
            var response = await context.imagesOfPlaces.Where(x => x.PlaceId == PlaceId)
                .Select(e => new ImageUrlOfCOrP { Id = e.Id, ImageUrl = e.ImageUrl }).ToListAsync();
            return response;
        }
        public async Task<IEnumerable<PlacesGetAllByCityIdResponse>> GetPlacesById(int id)
        {
            var response = await context.places.Where(e => e.CityId == id)
                .Select(x => new PlacesGetAllByCityIdResponse
                {
                    PlaceId = x.PlaceId,
                    Name = x.Name,
                    EvaluationByStars = x.EvaluationByStars,
                  
                }).ToListAsync();
            return response;
        }

        public async Task<IEnumerable<Department>> GetDepartmentsById(int id)
        {
            var response = await context.departments.Where(e => e.PlaceId == id).ToListAsync();

            return response;
        }

        public async Task<IEnumerable<Service>> GetServicesById(int id)
        {
            var response = await context.services.Where(e => e.DepartmentId == id).ToListAsync();

            return response;
        }

        public async Task<IEnumerable<PlacesGetAllByTourismIdResponse>> GetPlacesByTourismId(int id)
        {
            var response = await context.places.Where(e => e.TourismId == id)
               .Select(x => new PlacesGetAllByTourismIdResponse
               {
                   PlaceId = x.PlaceId,
                   Name = x.Name,
                   EvaluationByStars = x.EvaluationByStars,
                   
               }).ToListAsync();
            return response;
        }

        public async Task<string> GetTourismName(string id)
        {
            int.TryParse(id, out int number);
            var tourism = await context.typesOfTourism.FindAsync(number);

            return tourism.TourismName;
        }

       
    }
}
