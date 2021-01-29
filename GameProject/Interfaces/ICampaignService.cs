using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignService
    {
        void Add(Campaigns campaign);
        void Delete(Campaigns campaign);
        void Update(Campaigns campaign);
        double Sale(Games game,Campaigns campaign);
    }
}
