using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Basic.API.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class SearchHistoryModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public UserModel User { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public SearchParametersModel SearchParameters { get; set; }
    }
}
