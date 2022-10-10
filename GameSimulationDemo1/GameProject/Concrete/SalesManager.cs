using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Sales(Gamer gamer, Game game)
        {
            Console.WriteLine("The game named" + " " + game.GameName + " " + "was sold to the player named" + " " + gamer.FirstName + " " + gamer.LastName + " " +
                              "for the price of" + " " + game.GamePrice);
        }

        public void CampaignSales(Gamer gamer, Game game, Campaign campaign)
        {
            decimal discountedSales = game.GamePrice - (game.GamePrice * campaign.DiscountRate);
            Console.WriteLine("The game named" + " " + game.GameName + " " + "was sold to the user named" + " " + gamer.FirstName + " " + gamer.LastName + " "
                              + "for the price of" + " " + discountedSales + " " + "with the campaign named" + " " + campaign.CampaignName);
        }
    }
}
