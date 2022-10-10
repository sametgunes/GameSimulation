using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Adapters
{
    class FakeMernisServiceAdapter:IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
