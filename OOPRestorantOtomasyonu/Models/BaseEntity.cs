using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRestorantOtomasyonu.Models
{
    public abstract class BaseEntity
    {
        public string Ad
        {
            get;
            set;
           
        }

        public decimal Fiyat
        {
            get;
            set;
        }




        public override string ToString()
        {
            return $"{Ad} {Fiyat}";
        }
    }
}
