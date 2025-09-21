using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels.Models
{
    public class City
    {
        string cityId;
        string cityName;

        public string CityId
        {
            get { return cityId; }
            set { cityId = value; }
        }
        public string CityName
        {
            get { return cityName; }
            set { cityName = value; }
        }

    }
}
