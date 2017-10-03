using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;


namespace Rent.Entities
{
    /// <summary>
    /// Represents a row of Booking data.
    /// </summary>
    [DataContract]
    public partial class Equipment
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [Browsable(false)]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Make { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int Year { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public DateTime ChangedOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int ChangedBy { get; set; }
    }
}
