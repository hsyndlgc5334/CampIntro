using GameProject.Entity;

namespace GameProject.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
    }
}