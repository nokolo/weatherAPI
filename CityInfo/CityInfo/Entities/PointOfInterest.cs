﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace CityInfo.Entities
{
    public class PointOfInterest
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [ForeignKey("CityId")]
        public City? City { get; set; }

        public int CityId { get; set; }
       // public string? Description { get; set; }



        public PointOfInterest(string name)
        {
            Name = name;
        }
    }
}

