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
    public class SearchParametersModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<PropertyType> PropertyTypeList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<PropertyStatus> PropertyStatusList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public float MinPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public float MaxPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int MinNoOfBedrooms { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int MaxNoOfBedrooms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public bool IncludeSold { get; set; }
    }
}
