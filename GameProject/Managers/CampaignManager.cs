using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : Campaigns,ICampaignService
    {
        public void Add(Campaigns campaign)
        {
            Console.WriteLine("Campaign is added: " + campaign.Name);
        }

        public void Delete(Campaigns campaign)
        {
            Console.WriteLine("Campaign is deleted: " + campaign.Name);
        }

        public double Sale(Games game,Campaigns campaign)
        {
            return game.Price * campaign.Sale;
        }

        public void Update(Campaigns campaign)
        {
            Console.WriteLine("Campaign is updated: " + campaign.Name);
        }
    }
}
