using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.API.BLL.DB.Entity
{
    public class SearchParameters
    {
        public string Location { get; set; }

        public List<PropertyType> PropertyTypeList { get; set; }
        public List<PropertyStatus> PropertyStatusList { get; set; }

        public float MinPrice { get; set; }
        public float MaxPrice { get; set; }

        public int MinNoOfBedrooms { get; set; }
        public int MaxNoOfBedrooms { get; set; }

        public bool IncludeSold { get; set; }
    }
}
