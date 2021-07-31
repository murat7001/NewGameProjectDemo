using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProjectDemo
{
    class VerificationManager : IVerificationService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {                             
            if (gamer.Id.Length == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }
    }
}
