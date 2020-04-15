using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        public int id { get; set; }
        /// <summary>
        /// Represents person's first name.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Represents person's last name.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Represents person's email address.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Represents person's callphone number.
        /// </summary>
        public string CellphoneNumber { get; set; }

        public PersonModel()
        {

        }
        public PersonModel(string FirstName, string LastName, string EmailAddress, string CellphoneNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.EmailAddress = EmailAddress;
            this.CellphoneNumber = CellphoneNumber;
        }

    }
}
