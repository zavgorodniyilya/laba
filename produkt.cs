using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    class produkt
    {
        private string name = new string(' ', 20);
        int amount;
        private float cost;
        public produkt()
        {
            this.name = "Название";
            this.amount = 0;
            this.cost = 0;
        }
        public produkt(string name, int amount, float cost)
        {
            this.name = name;
            this.amount = amount;
            this.cost = cost;

        }
        public string Name
        {
            set
            {
                name = value;
            }
        }
        public int Amount
        {
            set
            {
                amount = value;
            }
        }
        public float Cost
        {
            set
            {
                cost = Convert.ToSingle(value);
            }
        }
        public void GetInfo()
        {
            Console.WriteLine("Наименование -  {0}; количество - {1}; стоимость - {2}.", name, amount, cost);
        }
    }
}
