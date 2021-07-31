using NewGameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProjectDemo.Concrete
{
    class CampaignManager : Abstract.ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi:"+" "+campaign.CampaignName );
            Console.WriteLine("Kampanya İndirimi : %" + campaign.CampaignDiscount);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Kaldırıldı:"+" "+campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi:"+" "+campaign.CampaignName );
            Console.WriteLine("Güncel Kampanya indirimi : %" + campaign.CampaignDiscount);
        }
    }
}
