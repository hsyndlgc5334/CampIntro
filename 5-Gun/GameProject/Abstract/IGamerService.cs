using GameProject.Entity;

namespace GameProject.Abstract
{
    public interface IGamerService
    {
         void Add(Gamer gamer);
         void Update(Gamer gamer);
         void Delete(Gamer gamer);
    }
}