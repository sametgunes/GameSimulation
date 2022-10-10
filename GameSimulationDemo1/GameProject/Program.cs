using System;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            Gamer gamer = new Gamer
            {
                Id = 1,
                FirstName = "Muhammet Ali",
                LastName = "Yalçın",
                IdentityNumber = 22567312266,
                DateOfBirth = new DateTime(1997,6,11)
            };

            Gamer gamer2 = new Gamer
            {
                Id = 4,
                FirstName = "ABDURRAHMAN YASİN",
                LastName = "TAŞ",
                IdentityNumber = 36644051368,
                DateOfBirth = new DateTime(1995,8,26)
            };
            gamerManager.Add(gamer);


            CampaignRateManager campaignRateManager = new CampaignRateManager();
            Campaign campaign = new Campaign
            {
                CampaignId = 2,
                CampaignName = "Abduction. %40 OFF!",
                DiscountRate = 0.40M
            };
            campaignRateManager.Add(campaign);

            GameManager gameManager = new GameManager();
            Game game = new Game
            {
                GameId = 3,
                GameName = "HelloWorld",
                GamePrice = 450
            };
            gameManager.Add(game);

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(gamer, game);
            salesManager.CampaignSales(gamer, game, campaign);
        }
    }
}
