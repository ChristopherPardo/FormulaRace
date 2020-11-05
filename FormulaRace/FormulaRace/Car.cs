using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaCrash
{
    public class Car
    {
        private string brand;
        private string powerUnit;

        public Car(string brand, string powerUnit)
        {
            this.brand = brand;
            this.powerUnit = powerUnit;
        }
        public string Brand
        {
            get
            {
                return this.brand;
            }
        }
        public string PowerUnit
        {
            get
            {
                return this.powerUnit;
            }
        }

    }
}