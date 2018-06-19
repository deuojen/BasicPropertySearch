using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.API.BLL.DB.Entity
{
    public class Property
    {
        public int PropertyId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string PropertyContent { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public float Price { get; set; }
        public List<string> Images { get; set; }

        public bool IsSold { get; set; }
        public int NoOfBedrooms { get; set; }

        public PropertyType PropertyType { get; set; }
        public PropertyStatus PropertyStatus { get; set; }

    }

    public enum PropertyType
    {
        House = 1,
        Bungalow,
        FlatApartment,
        Land,
        Other
    }

    public enum PropertyStatus
    {
        ForSale = 1,
        ForLet,
        ForLease
    }
}
