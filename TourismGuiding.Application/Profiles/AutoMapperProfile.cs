using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.Cities.Commends.Add;
using TourismGuiding.Application.Features.Cities.Commends.Update;
using TourismGuiding.Application.Features.Cities.Queries.GetAll;
using TourismGuiding.Application.Features.Cities.Queries.GetById;
using TourismGuiding.Application.Features.Departments.Commends.Add;
using TourismGuiding.Application.Features.Departments.Commends.Update;
using TourismGuiding.Application.Features.Departments.Queries.GetAllByPlaceId;
using TourismGuiding.Application.Features.Departments.Queries.GetById;
using TourismGuiding.Application.Features.ImagesCities.Commends.Add;
using TourismGuiding.Application.Features.ImagesPlaces.Commends.Add;
using TourismGuiding.Application.Features.Places.Commends.Add;
using TourismGuiding.Application.Features.Places.Commends.Update;
using TourismGuiding.Application.Features.Places.Queries.GetAll;
using TourismGuiding.Application.Features.Places.Queries.GetAllByTourismId;
using TourismGuiding.Application.Features.Places.Queries.GetById;
using TourismGuiding.Application.Features.Services.Commends.Add;
using TourismGuiding.Application.Features.Services.Queries.GetAllByDepartmentId;
using TourismGuiding.Application.Features.Tourisms.Commends.Add;
using TourismGuiding.Application.Features.Tourisms.Commends.Update;
using TourismGuiding.Application.Features.Tourisms.Queries.GetAll;
using TourismGuiding.Application.Features.Tourisms.Queries.GetById;
using TourismGuiding.Entities;
using TourismGuiding.Entities.Images;
using TourismGuiding.Entities.NewFolder;
using TourismGuiding.Entities.Services;

namespace TourismGuiding.Application.Profiles
{
    public  class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {

            // Tourism Handler
            CreateMap<Tourism, TourismsAddRequest>().ReverseMap();
            CreateMap<Tourism, TourismsUpdateCommend>().ReverseMap();
            CreateMap<Tourism, TourismsGetByIdResponse>().ReverseMap();
            CreateMap<Tourism, TourismsGetAllResponse>().ReverseMap();


            // Tourism Controller
            CreateMap<TourismsUpdateCommend, TourismsUpdateRequest>().ReverseMap();

            // Image Handler
            CreateMap<ImagesOfCity, ImagesCitiesAddCommend>().ReverseMap();
            CreateMap<ImagesOfPlace, ImagesPlacesAddCommend> ().ReverseMap();

            // City Handler
            CreateMap<City, CitiesAddRequest>().ReverseMap();
            CreateMap<City, CitiesUpdateCommend>().ReverseMap();
            CreateMap<City, CitiesGetByIdResponse>().ReverseMap();
            CreateMap<City, CitiesGetAllResponse>().ReverseMap();

            // Place Handler
            CreateMap<Place, PlacesAddCommend>().ReverseMap();
            CreateMap<Place, PlacesUpdateCommend>().ReverseMap();
            CreateMap<Place, PlacesGetByIdResponse>().ReverseMap();
            CreateMap<Place, PlacesGetAllByCityIdResponse>().ReverseMap();
           
            // Department Handler
            CreateMap<Department, DepartmentAddCommend>().ReverseMap();
            CreateMap<Department, DepartmentUpdateCommend>().ReverseMap();
            CreateMap<Department, DepartmentGetByIdResponse>().ReverseMap();
            CreateMap<Department, DepartmentGetAllByPlaceIdResponse>().ReverseMap();

            // Service Handler
            CreateMap<Service, ServiceAddCommend>().ReverseMap();
         
           // CreateMap<Service, ServiceGetByIdResponse>().ReverseMap();
            CreateMap<Service, ServiceGetAllByDepartmentIdResponse>().ReverseMap();

            // Service Controller
            CreateMap<ServiceAddCommend, ServiceAddRequest>().ReverseMap();
        }
    }
}
