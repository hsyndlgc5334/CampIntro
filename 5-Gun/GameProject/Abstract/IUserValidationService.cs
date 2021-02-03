using GameProject.Entity;

namespace GameProject.Abstract
{
    public interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}