using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataGridWithMultipleDetailGrids
{
    public class Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="title">
        /// The title.
        /// </param>
        /// <param name="forenames">
        /// The forenames.
        /// </param>
        /// <param name="surname">
        /// The surname.
        /// </param>
        public Person(string title, string forenames, string surname)
        {
            this.Title = title;
            this.Forenames = forenames;
            this.Surname = surname;
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the forenames.
        /// </summary>
        public string Forenames { get; set; }

        /// <summary>
        /// Gets or sets the surname.
        /// </summary>
        public string Surname { get; set; }
    }
}
