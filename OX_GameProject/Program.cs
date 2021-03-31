using System;

namespace OX_GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,BirthYear = 1996,
                FirstName = "Tayyip",
                LastName = "Altunöz",
                IdentityNumber = 12345
            });
        }
    }
}
