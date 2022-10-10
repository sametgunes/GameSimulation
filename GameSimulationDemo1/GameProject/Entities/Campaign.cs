using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Campaign :ICampaignEntity
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public decimal DiscountRate { get; set; }
    }
}
