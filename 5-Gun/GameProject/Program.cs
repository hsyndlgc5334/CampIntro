using System;
using GameProject.Concrete;
using GameProject.Entity;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game(){Id=1,Name="CS-GO",Price=123};
            var game2 = new Game(){Id=12,Name="LOL",Price=111};
            var gamer = new Gamer(){Id=1,FirstName="hüseyin",LastName="dalgıç",IdentityNumber=12345,BirdYear=1997};
            var gamer2 = new Gamer(){Id=12,FirstName="mehmet",LastName="şimşek",IdentityNumber=23212,BirdYear=1994};
            var campaign = new Campaign(){Id=1,Name="Pazar"};
            var campaign2 = new Campaign(){Id=12,Name="Cuma"};
            var campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Delete(campaign);
            campaignManager.Update(campaign);
            campaignManager.Add(campaign2);
            campaignManager.Delete(campaign2);
            campaignManager.Update(campaign2);
            var gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer);
            gamerManager.Delete(gamer);
            gamerManager.Update(gamer);
            var orderManager = new OrderManager(new CampaignManager());
            orderManager.Add(campaign);
            orderManager.Delete(campaign);
            orderManager.Update(campaign);
            orderManager.Add(campaign2);
            orderManager.Delete(campaign2);
            orderManager.Update(campaign2);
        }
    }
}
