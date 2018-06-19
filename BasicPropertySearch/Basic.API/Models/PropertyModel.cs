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
    public class PropertyModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int PropertyId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string ShortDescription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string PropertyContent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string City { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string PostCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public float Price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<string> Images { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public bool IsSold { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int NoOfBedrooms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public PropertyType PropertyType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public PropertyStatus PropertyStatus { get; set; }

    }

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public enum PropertyType
    {
        /// <summary>
        /// 
        /// </summary>
        House = 1,
        /// <summary>
        /// 
        /// </summary>
        Bungalow,
        /// <summary>
        /// 
        /// </summary>
        FlatApartment,
        /// <summary>
        /// 
        /// </summary>
        Land,
        /// <summary>
        /// 
        /// </summary>
        Other
    }

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public enum PropertyStatus
    {
        /// <summary>
        /// 
        /// </summary>
        ForSale = 1,
        /// <summary>
        /// 
        /// </summary>
        ForLet,
        /// <summary>
        /// 
        /// </summary>
        ForLease
    }
}
