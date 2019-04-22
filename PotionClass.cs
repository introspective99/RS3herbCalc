using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS3herbCalc
{
    public class PotionClass
    {
        public string potionName { get; set; }
        public decimal potion4Cost { get; set; }
        public decimal potion3Cost { get; set; }
        public decimal potion2Cost { get; set; }
        public decimal potion1Cost { get; set; }
        public decimal gePotion4Cost { get; set; }
        public decimal gePotion3Cost { get; set; }
        public decimal unfPotionCost { get; set; }
        public decimal geUnfPotionCost { get; set; }
        public decimal totalPotsMade { get; set; }
        public decimal unfPotsMade { get; set; }
        public decimal total3DoseValue { get; set; }
        public decimal total4DoseValue { get; set; }
        public decimal totalPotionCost { get; set; }
        public decimal gross { get; set; }
    }
}
