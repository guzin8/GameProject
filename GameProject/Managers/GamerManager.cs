using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if(userValidationService.Validate(gamer)==true)
            Console.WriteLine("Gamer is added: "+ gamer.FirstName);

            else
                Console.WriteLine("Validation is wrong!");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer is deleted: " + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer is updated: " + gamer.FirstName);
        }
    }
}
