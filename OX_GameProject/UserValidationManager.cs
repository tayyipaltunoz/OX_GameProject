using System;
using System.Collections.Generic;
using System.Text;

namespace OX_GameProject
{
    class UserValidationManager:IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==1996 && gamer.FirstName=="Tayyip" && 
                gamer.LastName=="Altunöz" && gamer.IdentityNumber==12345 )
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
