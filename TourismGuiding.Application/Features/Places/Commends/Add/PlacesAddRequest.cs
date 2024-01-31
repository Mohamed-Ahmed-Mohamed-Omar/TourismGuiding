﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.ResponseGeneration;


namespace TourismGuiding.Application.Features.Places.Commends.Add
{
    public class PlacesAddRequest 
    {
       
        public string Name { get; set; }
        public string phone { get; set; }

        public int? EvaluationByStars { get; set; }

        public string? PositionLink { get; set; }

        public string? Description { get; set; }
      

        public int TourismId { get; set; }



       
    }
}
