﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels
{
    public class City 
    {
        string cityId;
        string cityName;

        public string CityId
        {
            get { return cityId; }
            set
            {
                cityId = value;
                
            }
        }

        [Required(ErrorMessage = "City Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "City Name cannot be less than 3 characters.")]
        public string CityName
        {
            get { return cityName; }
            set
            {
                cityName = value;  
            }
        }
    }

   
}
