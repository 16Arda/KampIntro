using System;

namespace OyunProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 2000,
                FirstName = "Arda",
                LastName = "A",
                IdentityNumber = 12345
            });
        }
    }
}
