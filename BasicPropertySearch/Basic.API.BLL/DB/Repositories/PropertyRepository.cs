using Basic.API.BLL.DB.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Basic.API.BLL.DB.Entity;
using Basic.API.BLL.DB.InMemory;

namespace Basic.API.BLL.DB.Repositories
{
    public class FakePropertyRepository : IPropertyRepository
    {
        private InMemoryProperties _InMemoryProperties { get; set; }

        public FakePropertyRepository(InMemoryProperties InMemoryProperties)
        {
            _InMemoryProperties = InMemoryProperties;
        }

        public Property Get(int propertyId, User user)
        {
            return _InMemoryProperties.Properties.FirstOrDefault(x => x.PropertyId == propertyId);
        }

        public IEnumerable<Property> Get(SearchParameters searchParameters, User user)
        {
            var list = _InMemoryProperties.Properties.Where(x => (x.City.ToUpper() == searchParameters.Location.ToUpper() || x.PostCode.ToUpper() == searchParameters.Location.ToUpper()));

            if (!searchParameters.IncludeSold)
            {
                list = list.Where(x => (!x.IsSold));
            }

            if (searchParameters.MinNoOfBedrooms > 0)
            {
                list = list.Where(x => (x.NoOfBedrooms >= searchParameters.MinNoOfBedrooms));
            }

            if (searchParameters.MaxNoOfBedrooms > 0)
            {
                list = list.Where(x => (x.NoOfBedrooms <= searchParameters.MaxNoOfBedrooms));
            }

            if (searchParameters.MinPrice > 0)
            {
                list = list.Where(x => (x.Price >= searchParameters.MinPrice));
            }

            if (searchParameters.MaxPrice > 0)
            {
                list = list.Where(x => (x.Price <= searchParameters.MaxPrice));
            }

            if ((searchParameters.PropertyStatusList?.Count ?? 0 )> 0)
            {
                list = list.Where(x => searchParameters.PropertyStatusList.Contains(x.PropertyStatus));
            }

            if ((searchParameters.PropertyTypeList?.Count ?? 0) > 0)
            {
                list = list.Where(x => searchParameters.PropertyTypeList.Contains(x.PropertyType));
            }

            return list;
        }
    }
}
