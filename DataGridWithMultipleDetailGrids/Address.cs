using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataGridWithMultipleDetailGrids
{
    /// <summary>
    /// An address of a place
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        /// <param name="line1">
        /// The line 1.
        /// </param>
        /// <param name="town">
        /// The town.
        /// </param>
        /// <param name="county">
        /// The county.
        /// </param>
        /// <param name="postcode">
        /// The postcode.
        /// </param>
        public Address(string line1, string town, string county, string postcode)
        {
            this.Street = line1;
            this.Town = town;
            this.County = county;
            this.Postcode = postcode;
        }

        /// <summary>
        /// Gets or sets the first line of the address.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets the town part of the address.
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// Gets or sets the County part of the address.
        /// </summary>
        public string County { get; set; }

        /// <summary>
        /// Gets or sets the Postcode.
        /// </summary>
        public string Postcode { get; set; }
    }
}
