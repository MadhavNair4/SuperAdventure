using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class HealingPotion: Item
    {
        public HealingPotion(int amountToHeal, int iD, string name, string namePlural): 
            base(iD, name, namePlural)
        {
            AmountToHeal = amountToHeal;
        }

        public int AmountToHeal { get; set; }
    }
}
