using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProjectDemo.Abstract
{
    interface ICampaignService
    {
        void Add(Entities.Campaign campaign);
        void Delete(Entities.Campaign campaign);
        void Update(Entities.Campaign campaign);
    }
}
