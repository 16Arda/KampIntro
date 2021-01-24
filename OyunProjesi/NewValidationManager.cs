using System;
using System.Collections.Generic;
using System.Text;

namespace OyunProjesi
{
    class NewValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
