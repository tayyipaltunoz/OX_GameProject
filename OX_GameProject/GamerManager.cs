using System;
using System.Collections.Generic;
using System.Text;

namespace OX_GameProject
{
    
    class GamerManager:IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt başarılı");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız!!");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt başarı ile güncellendi");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }
    }
}
