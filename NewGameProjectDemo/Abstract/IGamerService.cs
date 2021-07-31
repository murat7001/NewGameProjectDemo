using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProjectDemo
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void UpDate(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
