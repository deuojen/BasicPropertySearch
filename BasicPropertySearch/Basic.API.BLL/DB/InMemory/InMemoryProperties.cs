using Basic.API.BLL.DB.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.API.BLL.DB.InMemory
{
    public class InMemoryProperties
    {
        public IEnumerable<Property> Properties { get; set; }

        public InMemoryProperties()
        {
            Properties = new List<Property>() {
                new Property()
                {
                    Address= "sample address 1",
                    City = "Coventry",
                    Images = new List<string>() { "https://localhost:44321/Content/images/g1.jpg", "https://localhost:44321/Content/images/g2.jpg", "https://localhost:44321/Content/images/g3.jpg", "https://localhost:44321/Content/images/g4.jpg" },
                    IsSold = false,
                    NoOfBedrooms = 1,
                    PostCode = "CV1",
                    Price = 150000.00F,
                    PropertyStatus = PropertyStatus.ForSale,
                    PropertyContent = "full content",
                    PropertyId = 1,
                    PropertyType = PropertyType.House,
                    ShortDescription = "short decription",
                    Title = "Sample House at Coventry"
                },
                new Property()
                {
                    Address= "sample address 2",
                    City = "Coventry",
                    Images = new List<string>() { "https://localhost:44321/Content/images/g1.jpg", "https://localhost:44321/Content/images/g2.jpg", "https://localhost:44321/Content/images/g3.jpg", "https://localhost:44321/Content/images/g4.jpg" },
                    IsSold = false,
                    NoOfBedrooms = 2,
                    PostCode = "CV2",
                    Price = 120000.00F,
                    PropertyStatus = PropertyStatus.ForSale,
                    PropertyContent = "full content",
                    PropertyId = 2,
                    PropertyType = PropertyType.House,
                    ShortDescription = "short decription",
                    Title = "Sample House at Coventry"
                },
                new Property()
                {
                    Address= "sample address 3",
                    City = "Coventry",
                    Images = new List<string>() { "https://localhost:44321/Content/images/g1.jpg", "https://localhost:44321/Content/images/g2.jpg", "https://localhost:44321/Content/images/g3.jpg", "https://localhost:44321/Content/images/g4.jpg" },
                    IsSold = false,
                    NoOfBedrooms = 3,
                    PostCode = "CV3",
                    Price = 130000.00F,
                    PropertyStatus = PropertyStatus.ForSale,
                    PropertyContent = "full content",
                    PropertyId = 3,
                    PropertyType = PropertyType.House,
                    ShortDescription = "short decription",
                    Title = "Sample House at Coventry"
                },new Property()
                {
                    Address= "sample address 4",
                    City = "Coventry",
                    Images = new List<string>() { "https://localhost:44321/Content/images/g1.jpg", "https://localhost:44321/Content/images/g2.jpg", "https://localhost:44321/Content/images/g3.jpg", "https://localhost:44321/Content/images/g4.jpg" },
                    IsSold = false,
                    NoOfBedrooms = 2,
                    PostCode = "CV2",
                    Price = 140000.00F,
                    PropertyStatus = PropertyStatus.ForSale,
                    PropertyContent = "full content",
                    PropertyId = 4,
                    PropertyType = PropertyType.House,
                    ShortDescription = "short decription",
                    Title = "Sample House at Coventry"
                },new Property()
                {
                    Address= "sample address 5",
                    City = "Coventry",
                    Images = new List<string>() { "https://localhost:44321/Content/images/g1.jpg", "https://localhost:44321/Content/images/g2.jpg", "https://localhost:44321/Content/images/g3.jpg", "https://localhost:44321/Content/images/g4.jpg" },
                    IsSold = false,
                    NoOfBedrooms = 2,
                    PostCode = "CV3",
                    Price = 155000.00F,
                    PropertyStatus = PropertyStatus.ForLet,
                    PropertyContent = "full content",
                    PropertyId = 5,
                    PropertyType = PropertyType.FlatApartment,
                    ShortDescription = "short decription",
                    Title = "Sample House at Coventry"
                },
                new Property()
                {
                    Address= "sample address 6",
                    City = "Coventry",
                    Images = new List<string>() { "https://localhost:44321/Content/images/g1.jpg", "https://localhost:44321/Content/images/g2.jpg", "https://localhost:44321/Content/images/g3.jpg", "https://localhost:44321/Content/images/g4.jpg" },
                    IsSold = false,
                    NoOfBedrooms = 3,
                    PostCode = "CV6",
                    Price = 150000.00F,
                    PropertyStatus = PropertyStatus.ForLet,
                    PropertyContent = "full content",
                    PropertyId = 6,
                    PropertyType = PropertyType.House,
                    ShortDescription = "short decription",
                    Title = "Sample House at Coventry"
                },
                new Property()
                {
                    Address= "sample address 7",
                    City = "Coventry",
                    Images = new List<string>() { "https://localhost:44321/Content/images/g1.jpg", "https://localhost:44321/Content/images/g2.jpg", "https://localhost:44321/Content/images/g3.jpg", "https://localhost:44321/Content/images/g4.jpg" },
                    IsSold = false,
                    NoOfBedrooms = 3,
                    PostCode = "CV1",
                    Price = 180000.00F,
                    PropertyStatus = PropertyStatus.ForSale,
                    PropertyContent = "full content",
                    PropertyId = 7,
                    PropertyType = PropertyType.House,
                    ShortDescription = "short decription",
                    Title = "Sample House at Coventry"
                },
                new Property()
                {
                    Address= "sample 8 1",
                    City = "Coventry",
                    Images = new List<string>() { "https://localhost:44321/Content/images/g1.jpg", "https://localhost:44321/Content/images/g2.jpg", "https://localhost:44321/Content/images/g3.jpg", "https://localhost:44321/Content/images/g4.jpg" },
                    IsSold = false,
                    NoOfBedrooms = 2,
                    PostCode = "CV1",
                    Price = 199000.00F,
                    PropertyStatus = PropertyStatus.ForSale,
                    PropertyContent = "full content",
                    PropertyId = 8,
                    PropertyType = PropertyType.House,
                    ShortDescription = "short decription",
                    Title = "Sample House at Coventry"
                }

            };
        }


    }
}
