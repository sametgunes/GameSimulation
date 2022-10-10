using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface ISalesService
    {
        void Sales(Gamer gamer, Game game);
        void CampaignSales(Gamer gamer, Game game, Campaign campaign);
    }
}
