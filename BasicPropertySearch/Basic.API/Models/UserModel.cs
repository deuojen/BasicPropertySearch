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
    public class UserModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string UserName { get; set; }
    }
}
