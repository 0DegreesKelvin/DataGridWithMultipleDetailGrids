using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataGridWithMultipleDetailGrids
{
    /// <summary>
    /// A company that does some business
    /// </summary>
    public class Company
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Company"/> class.
        /// </summary>
        public Company() 
        {
            this.Locations = new List<Address>();
            this.Staff = new List<Person>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Company"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        public Company(string name) : this()
        {
            this.CompanyName = name;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets the locations of the company
        /// </summary>
        public IList<Address> Locations { get; private set; }

        /// <summary>
        /// Gets the staff in the company
        /// </summary>
        public IList<Person> Staff { get; private set; } 
    }
}
