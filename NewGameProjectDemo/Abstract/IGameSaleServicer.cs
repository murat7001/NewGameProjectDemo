using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProjectDemo.Abstract
{
    interface IGameSaleServicer
    {
        void Sale(Gamer gamer, Entities.Game game, Entities.Campaign campaign);
    }
}
