using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellphone_Service.Classes
{
    [Serializable]
    public class ExtraOption
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public ExtraOption() { }

        public ExtraOption(string name, double price, string description)
        {
            Name = name;
            Price = price;
            Description = description;
        }

        public override string ToString()
        {
            string rez;

            rez = "Extra option - name: " + Name + ", price: " + Price.ToString() + ", description: " + Description;

            return rez;
        }
    }
}
