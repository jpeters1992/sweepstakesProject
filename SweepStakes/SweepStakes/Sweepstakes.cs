using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Sweepstakes
    {
        //MEMBER VARIABLES
        public string name;
        public int maxNumber;
        public int winningNumber;
        public IDictionary<int, string> contestantsDictionary = new Dictionary<int, string>();
        
        //CONSTRUCTOR

        //MEMBER METHODS
        public Sweepstakes (string name)
        {
            this.name = name;
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestant.FirstName = UserInterface.GetFirstName();
            UserInterface.NewLine();
            contestant.LastName = UserInterface.GetLastName();
            UserInterface.NewLine();
            contestant.EmailAddress = UserInterface.GetEmailAddress();
            UserInterface.NewLine();
            contestant.RegistrationNumber = UserInterface.GetRegistrationNumber();
            UserInterface.NewLine();

            PrintContestantInfo(contestant);

            Console.WriteLine("Great, you're all set with registration process! Press any key to continue and let the next contestant register.");
            Console.ReadLine();
            Console.Clear();
           
        }

        public Contestant PickWinner()
        {
            Random randomContestant = new Random();
            winningNumber = randomContestant.Next(1, maxNumber + 1);
            foreach (KeyValuePair<int, string> contestant in contestantsDictionary)
            {
                if (contestant.Key == winningNumber)
                {
                    return contestant.Value;
                }
            }
            return null;

        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Contestant Name: "+contestant.FirstName+" "+contestant.LastName);
            Console.WriteLine("Contestant Email Address: " +contestant.EmailAddress);
            Console.WriteLine("Contestant Registration#: " +contestant.RegistrationNumber);
        }
    }
}
