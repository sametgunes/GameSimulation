using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class CampaignRateManager : ICampaignRateService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName +" - " + "has been successfully added.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " - " + "has been successfully updated.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " - " + "has been successfully deleted.");
        }
    }
}
