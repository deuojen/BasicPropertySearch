using Basic.API.BLL.DB.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.API.BLL.DB.Repositories.Interfaces
{
   public interface IPropertyRepository
    {
        IEnumerable<Property> Get(SearchParameters searchParameters, User user);
        Property Get(int propertyId, User user);
    }
}
