using GameProject.Abstract;
using GameProject.Entity;

namespace GameProject.Concrete
{
    public class OrderManager : IOrderService
    {
        ICampaignService _iCampaignService;
        public OrderManager(ICampaignService iCampaignService)
        {
            _iCampaignService = iCampaignService;
        }
        private bool Sale(Campaign campaign)
        {
            switch (campaign.Id)
            {
                case 1:
                    System.Console.WriteLine($"{campaign.Name} isimli kampanya satışta uygulandı.");
                    return true;
                case 2:
                    System.Console.WriteLine($"{campaign.Name} isimli kampanya satışta uygulandı.");
                    return true;
                case 3:
                    System.Console.WriteLine($"{campaign.Name} isimli kampanya satışta uygulandı.");
                    return true;
                case 4:
                    System.Console.WriteLine($"{campaign.Name} isimli kampanya satışta uygulandı.");
                    return true;
                case 5:
                    System.Console.WriteLine($"{campaign.Name} isimli kampanya satışta uygulandı.");
                    return true;
                default:
                    System.Console.WriteLine($"{campaign.Name} isimli kampanya bulunamadı.");
                    return false;
            }
        }

        public void Add(Campaign campaign)
        {
            if(Sale(campaign))
            {
                System.Console.WriteLine($"{campaign.Name} kampanyalı satış eklendi.");
            }
            else
            {
                System.Console.WriteLine($"Satışta kampanya uygulanmadan eklendi.");
            }
        }

        public void Delete(Campaign campaign)
        {
            if(Sale(campaign))
            {
                System.Console.WriteLine($"{campaign.Name} kampanyalı oyun satışı silindi.");
            }
        }
        public void Update(Campaign campaign)
        {
            if(Sale(campaign))
            {
                System.Console.WriteLine($"{campaign.Name} kampanyalı satış güncellendi.");
            }
            
        }

    }
}