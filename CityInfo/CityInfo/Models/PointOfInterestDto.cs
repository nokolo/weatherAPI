﻿using System;
namespace CityInfo.Models
{
    public class PointOfInterestDto
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

     
        public PointOfInterestDto()
        {
        }
    }
}

