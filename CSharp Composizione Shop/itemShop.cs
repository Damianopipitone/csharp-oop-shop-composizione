using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Composizione_Shop
{
    public class itemShop
    {
        private string name;
        private string cateogries;

        // COSTRUTTORE

        public itemShop(string name, string cateogories)
        {
            this.name = name;
            this.cateogries = cateogories;
        }

        // GETTERS 

        public string GetName()
        {
            return this.name;
        }

        public string GetCateogries()
        {
            return this.cateogries;
        }

        public string GetItemString()
        {
            string rapprString = "Nome prodotto: " + this.name + "\n";
            rapprString += "La categoria cui appartiene è : " + this.cateogries + "\n";
            return rapprString;

        }
    }
}
