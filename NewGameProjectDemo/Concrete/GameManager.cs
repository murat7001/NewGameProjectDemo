using NewGameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProjectDemo.Concrete
{
    class GameManager : Abstract.IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun Eklendi:"+game.GameName +" "+  
                "Fiyatı: " + game.GamePrice +" "+
                "Kategori: " + game.Category);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun Silindi:"+" "+game.GameName );
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun Güncellendi:"+" "+game.GameName );
        }
    }
}
