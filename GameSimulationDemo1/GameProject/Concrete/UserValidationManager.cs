using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class UserValidationManager:IUserValidationService
    {
        IUserValidationService userValidationService;

        public bool Validate(Gamer gamer)
        {
            userValidationService = new MernisServiceAdapter();
            return userValidationService.Validate(gamer);
        }
    }
}
