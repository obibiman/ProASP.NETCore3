using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvitation.Models
{
    /// <summary>
    /// </summary>
     public class Student
    {
        /// <summary>
        /// </summary>
        public virtual Address Address { get; set; }

        /// <summary>
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// </summary>
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }

            set
            {
                var names = value.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                FirstName = names[0];
                LastName = names[1];
            }
        }

        /// <summary>
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// </summary>
        public int StudentId { get; set; }
    }
}
