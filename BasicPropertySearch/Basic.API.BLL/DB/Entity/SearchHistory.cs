using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.API.BLL.DB.Entity
{
    public class SearchHistory
    {
        public User User { get; set; }
        public SearchParameters SearchParameters { get; set; }
    }
}
