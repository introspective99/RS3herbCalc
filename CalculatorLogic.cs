using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS3herbCalc
{
    static public class CalculatorLogic
    {
        static public int UnfinishedPotionCost(decimal herbCostInput, decimal vialOfWaterCostInput)
            //takes the information from the PotionCalculator form and work out the cost of 1 unfinished potion.
        {
            PotionClass unfinishedPotion = new PotionClass();
            IngredientsClass unfinishedPotionHerb = new IngredientsClass();
            
            unfinishedPotionHerb.herbCost = ConvertToInt(herbCostInput);
            unfinishedPotionHerb.vialOfWaterCost = ConvertToInt(vialOfWaterCostInput);
            unfinishedPotion.unfPotionCost = unfinishedPotionHerb.herbCost + unfinishedPotionHerb.vialOfWaterCost;

            return unfinishedPotion.unfPotionCost;
        }

        static public int FinishedThreeDoseCalc(decimal ingredientsCostInput, decimal costPerUnfOutput)
            //takes the info from PotionCalculator form to work out the cost of 1 potion.
        {
            IngredientsClass extraIngredient = new IngredientsClass();
            PotionClass threeDosePotionCost = new PotionClass();

            extraIngredient.ingredientCost = ConvertToInt(ingredientsCostInput);
            threeDosePotionCost.potion3Cost = threeDosePotionCost.unfPotionCost + extraIngredient.ingredientCost;

            return threeDosePotionCost.potion3Cost;
        }

        static public int FinishedOneDoseCalc(decimal costPer3DoseOutput)
            //takes the info from PotionCalculator form and works out the cost of 1 dose of a potion.
        {
            PotionClass oneDosePotionCost = new PotionClass();
            
            oneDosePotionCost.potion1Cost = ConvertToInt(costPer3DoseOutput) / 3;

            return oneDosePotionCost.potion1Cost;
        }







        private static int ConvertToInt(decimal decimalNumber)
            //Converts the decimals given by NumericUpDown
        {
            return Convert.ToInt32(Math.Round(decimalNumber, 0));
        }
    }
}
