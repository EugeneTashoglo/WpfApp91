using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9
{
    public class Monitor
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public override string ToString()
        {
            return $"Название:{Name}, " +
                $"Цена:{Price}";
        }
    }
}
