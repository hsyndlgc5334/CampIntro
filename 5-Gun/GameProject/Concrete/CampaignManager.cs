using GameProject.Abstract;
using GameProject.Entity;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            System.Console.WriteLine($"{campaign.Name} kampanyası eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            System.Console.WriteLine($"{campaign.Name} kampanyası silindi.");
        }

        public void Update(Campaign campaign)
        {
            System.Console.WriteLine($"{campaign.Name} kampanyası güncellendi.");
        }
    }
}