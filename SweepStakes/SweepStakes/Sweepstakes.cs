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
        public Dictionary<int, Contestant> contestantsDictionary = new Dictionary<int, Contestant>();
        
        //CONSTRUCTOR

        //MEMBER METHODS
        public Sweepstakes (string name)
        {
            this.name = name;
        }

        public void RegisterContestant(Contestant contestant)
        {
            // this is where i store my contestant into the dictionary.

            PrintContestantInfo(contestant);

            Console.WriteLine("Great, you're all set with registration process! Press any key to continue and let the next contestant register.");
            Console.ReadLine();
            Console.Clear();
           
        }

        public Contestant PickWinner()
        {
            Random randomContestant = new Random();
            winningNumber = randomContestant.Next(1, maxNumber + 1);
            foreach (KeyValuePair<int, Contestant> contestant in contestantsDictionary)
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
