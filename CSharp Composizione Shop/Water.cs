using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Composizione_Shop
{
    // SOTTOCLASSE
    public class Water : itemShop
    {
        private float capacity = 1.5f;
        private float ph;
        private string source;

        // COSTRUTTORE
        public Water(string name, float capacity, float ph, string source) : base(name)
        {
            this.capacity = capacity;
            this.ph = ph;
            this.source = source;
        }

        // GETTERS

        public float GetCapacity()
        {
            return this.capacity;
        }

        public float GetPh()
        {
            return this.ph;
        }

        public string GetSource() 
        { 
            return this.source; 
        }

        //SETTERS

        public float SetMaxCapacity(float maxCapacity)
        {
            this.capacity = maxCapacity;
            if (capacity > 1.5f)
            {
                Console.WriteLine("La capacità massima della bottiglia è di 1,5L");
            }
            return maxCapacity;
        }
        // METODI

        //public float LitriDaBere()
        //{
            
        //}


        
    }
}
