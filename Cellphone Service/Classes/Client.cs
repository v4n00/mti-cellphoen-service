using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellphone_Service.Classes
{

    [Serializable]
    public class Client : IComparable<Client>
    {
        public string Name { get; set; }
        public Subscription Subscription { get; set; }
        public double TotalBill { get; set;  }
        public List<ExtraOption> ExtraOptions { get; set; }

        public Client()
        {
            ExtraOptions = new List<ExtraOption>();
        }

        public Client(string name, Subscription subscription) : this()
        {
            Name = name;
            Subscription = subscription;
        }

        public void AddExtraOption(ExtraOption extraOption)
        {
            ExtraOptions.Add(extraOption);
            Update();
        }

        public void Update()
        {
            Subscription.UpdatePriceAndName();
            double totalBill = 0;
            totalBill += Subscription.Price;
            foreach (ExtraOption extraOption in ExtraOptions)
            {
                totalBill += extraOption.Price;
            }
            TotalBill = totalBill;
        }

        public int CompareTo(Client other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
