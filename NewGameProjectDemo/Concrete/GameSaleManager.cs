using NewGameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProjectDemo.Concrete
{
    class GameSaleManager : Abstract.IGameSaleServicer
    {
        public void Sale(Gamer gamer, Game game, Campaign campaign)
        {
            double newPrice = game.GamePrice - (game.GamePrice * (campaign.CampaignDiscount / 100));
            Console.WriteLine(game.GameName + " oyunu " + gamer.FirstName + " " + gamer.LastName + " kişisine satıldı.");
            Console.WriteLine("Oyunun indirimli Fiyatı : " + newPrice + " TL");
            Console.WriteLine("Uygulanan İndirim fiyatı : " + game.GamePrice * (campaign.CampaignDiscount / 100) + " TL");

        }
    }
}
