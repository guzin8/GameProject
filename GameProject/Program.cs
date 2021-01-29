using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            Gamer gamer = new Gamer { Id = 8, BirthYear = 1999, FirstName ="Güzin",LastName = "Kanburoglu",IdentityNumber=123456};
            gamerManager.Add(gamer);

            Campaigns campaign1 = new Campaigns { Id = 1, Name = "Christmas Sale", Sale = 0.50 };
            Campaigns campaign2 = new Campaigns { Id = 2, Name = "The Game Awards Sale", Sale = 0.30 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);

            Games game = new Games { Name = "GTA", Price = 100};

            Console.WriteLine("Price is: "+ campaignManager.Sale(game, campaign1));

        }
    }
}
