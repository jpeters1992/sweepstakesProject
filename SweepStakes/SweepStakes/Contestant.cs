using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Contestant
    {
        //MEMBER VARIABLES
        private string firstName;
        private string lastName;
        private string emailAddress;
        private int registrationNumber;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }

            set
            {
                emailAddress = value;
            }
        }

        public int RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }

            set
            {
                registrationNumber = value;
            }
        }
        //CONSTRUCTOR

        public Contestant()
        {
            this.firstName = UserInterface.GetFirstName();
            this.lastName = UserInterface.GetLastName();
            this.emailAddress = UserInterface.GetEmailAddress();
            this.registrationNumber = UserInterface.GetRegistrationNumber();
        }

        //MEMBER METHODS
        
    }
}
