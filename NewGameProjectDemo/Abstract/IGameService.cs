using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProjectDemo.Abstract
{
    interface IGameService
    {
        void Add(Entities.Game game);
        void Update(Entities.Game game);
        void Delete(Entities.Game game);
    }
}
