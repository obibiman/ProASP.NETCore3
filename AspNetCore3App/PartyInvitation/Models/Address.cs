using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvitation.Models
{
    /// <summary>
    /// </summary>
    public class Address
    {
        /// <summary>
        /// </summary>
        public int AddressId { get; set; }

        /// <summary>
        /// </summary>
        public string AddressLine1 { get; set; }

        /// <summary>
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// </summary>
        public string CityName { get; set; }

        /// <summary>
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// </summary>
        public string StateCode { get; set; }

        /// <summary>
        /// </summary>
        public virtual Student Student { get; set; }

        /// <summary>
        /// </summary>
        public string ZipCode { get; set; }
    }
}
