using GameProject.Abstract;
using GameProject.Entity;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if(_userValidationService.Validate(gamer))
            {
                System.Console.WriteLine($"{gamer.FirstName} isimli oyuncu eklendi.");
            }
            else
            {
                System.Console.WriteLine($"E-Devlet sistemi ile uyum sağlanamadı");
            }
        }

        public void Delete(Gamer gamer)
        {
            if(_userValidationService.Validate(gamer))
            {
                System.Console.WriteLine($"{gamer.FirstName} isimli oyuncu silindi.");
            }
            else
            {
                System.Console.WriteLine($"E-Devlet sistemi ile uyum sağlanamadı");
            }
        }

        public void Update(Gamer gamer)
        {
            if(_userValidationService.Validate(gamer))
            {
                System.Console.WriteLine($"{gamer.FirstName} isimli oyuncu güncellendi .");
            }
            else
            {
                System.Console.WriteLine($"E-Devlet sistemi ile uyum sağlanamadı");
            }
        }
    }
}