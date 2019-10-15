using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public interface ISweepstakesManager
    {
        //MEMBER VARIABLES
        string FirstName { get; set; }
        string LastName { get; set; }
        string EmailAddress { get; set; }
        int RegistrationNumber { get; set; }


        //CONSTRUCTOR

        //MEMBER METHODS
        void InsertSweepstakes(Sweepstakes sweepstakes);

        Sweepstakes GetSweepstakes();
    }
}
