using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерные_состовляющие
{
    public class Tovar
    {
        private string name;
        private string izgotovitel;
        private string opisanie;
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }


        public string Izgotovitel
        {
            get { return izgotovitel; }
            set { izgotovitel = value; }
        }
        public string Opisanie
        {
            get { return opisanie; }
            set { opisanie = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Tovar() { Name = "name1"; Izgotovitel = "izgotovitel"; Opisanie = "opisanie1"; Price = 0; }

        public Tovar(string name, string izgotovitel, string opisanie, double price)
        {
            this.name = name;
            this.izgotovitel = izgotovitel;
            this.opisanie = opisanie;
            this.price = price;
        }

        public override string ToString()
        {
            //return "Name=" + Name + " Izgotovitel=" + Izgotovitel + "Opisanie tovara"+ Opisanie + " Price=" + Price;
            return  Name ;
        }

    }
}
