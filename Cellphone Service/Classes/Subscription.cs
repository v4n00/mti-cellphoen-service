using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellphone_Service.Classes
{
    public enum _ClientType
    {
        Standard,
        Gold,
        Platinum
    }

    public enum _SubscriptionType
    {
        CallAndSMS,
        Internet,
        AllInclusive
    }

    [Serializable]
    public class Subscription
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public _SubscriptionType SubscriptionType { get; set; }
        public _ClientType ClientType { get; set; }

        public Subscription() { }

        public Subscription(_SubscriptionType subscriptionType, _ClientType clientType)
        {
            SubscriptionType = subscriptionType;
            ClientType = clientType;
        }

        public void UpdatePriceAndName()
        {
            switch(SubscriptionType)
            {
                case _SubscriptionType.CallAndSMS:
                    this.Name = "Calls and SMS only";
                    this.Price = 10;
                    break;
                case _SubscriptionType.Internet:
                    this.Name = "Internet only";
                    this.Price = 20;
                    break;
                case _SubscriptionType.AllInclusive:
                    this.Price = 25;
                    this.Name = "All inclusive";
                    break;
            }
            switch(ClientType)
            {
                case _ClientType.Standard:
                    this.Price = this.Price;
                    break;
                case _ClientType.Gold:
                    this.Price -= 2.5;
                    break;
                case _ClientType.Platinum:
                    this.Price -= 4.5;
                    break;
            }
        }
    }
}
