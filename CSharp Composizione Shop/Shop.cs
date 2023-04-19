using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Composizione_Shop
{
    public class Shop
    {
        // ATTRIBUTI 

        private string name;
        private string city;
        private string address;
        private int civicNumber;
        private List<itemShop> itemShop;

        // COSTRUTTORE

        public Shop(string name, string city, string address, int civicNumber)
        {
            this.name = name;
            this.city = city;
            this.address = address;
            this.civicNumber = civicNumber;
            this.itemShop = new List<itemShop>();
        }

        // GETTERS

        public string getName()
        {
            return this.name;
        }

        public string getCity()
        { 
            return this.city; 
        }

        public string getAddress()
        {
            return this.address;
        }

        public int getCivicNumber()
        {
            return this.civicNumber;
        }

        public List<itemShop> GetShopList()
        {
            return this.itemShop;
        }

        // SETTERS 

        public void SetCategories(string categories)
        {
            this.
        }
    }

   
    
}
