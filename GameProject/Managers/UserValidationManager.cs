﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
           if(gamer.BirthYear == 1999&&gamer.FirstName == "Güzin" && gamer.LastName =="Kanburoglu" && gamer.IdentityNumber == 123456)
            {
                return true;
            }
            return false;
        }
    }
}
