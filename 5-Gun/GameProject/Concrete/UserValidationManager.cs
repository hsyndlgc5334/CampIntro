using GameProject.Abstract;
using GameProject.Entity;

namespace GameProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.Id == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}