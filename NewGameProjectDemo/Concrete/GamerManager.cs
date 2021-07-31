using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProjectDemo
{
    class GamerManager : IGamerService
    {
        public GamerManager()
        {

        }
        private IVerificationService verificationService;

        public GamerManager(IVerificationService verificationService)
        {
            this.verificationService = verificationService;
        }
        public void Add(Gamer gamer)
        {
            if (verificationService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Kayıt Oldu:" + gamer.FirstName + " " + gamer.LastName);
            }
            else
            {
                Console.WriteLine("Kayıt Başarısız. Bilgilerinizi tekrar kontrol ediniz.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi:" + gamer.FirstName + " " + gamer.LastName);
        }

        public void UpDate(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi:" + gamer.FirstName + " " + gamer.LastName);
        }
    }
}
