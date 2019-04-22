using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS3herbCalc
{
    public class IngredientsClass
    {
        public string herb { get; set; }
        public decimal herbCost { get; set; }
        public string ingredient { get; set; }
        public decimal ingredientCost { get; set; }
        public bool herbClean { get; set; }
        public decimal vialOfWaterCost { get; set; }
        public decimal herbStock { get; set; }
        public decimal unfPotionStock { get; set; }
    }
}

