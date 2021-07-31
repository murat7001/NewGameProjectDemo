using System;

namespace NewGameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Players
            Gamer gamer1 = new Gamer
            {
                FirstName = "Engin ",
                LastName = "Demiroğ",
                Id = "01",
                BirthYear=new DateTime(1985)
            };
            Gamer gamer2 = new Gamer
            {
                FirstName = "Murat ",
                LastName = "Yıldırım",
                Id="02",
                BirthYear=new DateTime(2002),
            };

            //Games 
            Entities.Game game1 = new Entities.Game
            {
                GameName = "GTA V",
                Category = "Aksiyon",
                GamePrice = 150
            };
            Entities.Game game2 = new Entities.Game
            {
                GameName = "Pubg",
                Category = "Hayatta Kalma, Savaş",
                GamePrice = 100
            };

            //Campaigns
            Entities.Campaign campaign1 = new Entities.Campaign();
            campaign1.CampaignName = "Yaz İndirimi";
            campaign1.CampaignDiscount = 10;
            Console.WriteLine("------");
            Entities.Campaign campaign2 = new Entities.Campaign();
            campaign2.CampaignName = "Öğrenci İndirimi";
            campaign2.CampaignDiscount = 25;
            //Gamer Manager
            GamerManager gamerManager = new GamerManager(new VerificationManager());
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);
            gamerManager.UpDate(gamer2);

            Console.WriteLine("-----");
            //Game Manager
            Concrete.GameManager gameManager = new Concrete.GameManager();
            gameManager.Add(game1);

            Console.WriteLine("-----");


            gameManager.Add(game2);

            Console.WriteLine("-----");
            //Campaign Manager
            Concrete.CampaignManager campaignManager = new Concrete.CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);

            Console.WriteLine("------");

            Concrete.GameSaleManager gameSaleManager = new Concrete.GameSaleManager();
            gameSaleManager.Sale(gamer1, game1, campaign1);

            Console.WriteLine("-----");

            gameSaleManager.Sale(gamer2, game2, campaign2);





            Console.ReadLine();


        }
    }
}
