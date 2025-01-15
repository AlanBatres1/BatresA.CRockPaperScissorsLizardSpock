using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatresA.CRockPaperScissorsLizardSpock.Services
{
    public class RPSLSServices
    {
        public string RPSLS()
        {
            Random rng = new Random();
            int Random = rng.Next(1, 6);
            switch (Random)
            {
                case 1:
                    return "Rock";

                case 2:
                    return "Paper";

                case 3:
                    return "Scissors";

                case 4:
                    return "Lizard";

                case 5:
                    return "Spock";

                default:
                    return "what did you do, rety again";
            }
        }
    }
}