using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS3herbCalc
{
    static public class CalculatorLogic
    {
        static public decimal UnfinishedPotionCost(decimal herbCostInput, decimal vialOfWaterCostInput)
            //takes the information from the PotionCalculator form and work out the cost of 1 unfinished potion.
        {
            PotionClass unfinishedPotion = new PotionClass();
            IngredientsClass unfinishedPotionHerb = new IngredientsClass();
            unfinishedPotionHerb.herbCost = herbCostInput;
            unfinishedPotionHerb.vialOfWaterCost = vialOfWaterCostInput;
            unfinishedPotion.unfPotionCost = unfinishedPotionHerb.herbCost + unfinishedPotionHerb.vialOfWaterCost;
            return unfinishedPotion.unfPotionCost;
        }


        static public decimal FinishedThreeDoseCalc(decimal ingredientsCostInput, decimal costPerUnfOutput)
            //takes the info from PotionCalculator form to work out the cost of 1 potion.
        {
            IngredientsClass extraIngredient = new IngredientsClass();
            PotionClass threeDosePotionCost = new PotionClass();
            extraIngredient.ingredientCost = ingredientsCostInput;
            threeDosePotionCost.potion3Cost = threeDosePotionCost.unfPotionCost + extraIngredient.ingredientCost;
            return threeDosePotionCost.potion3Cost;
        }


        static public decimal FinishedOneDoseCalc(decimal costPer3DoseOutput)
            //takes the info from PotionCalculator form and works out the cost of 1 dose of a potion.
        {
            PotionClass oneDosePotionCost = new PotionClass();
            oneDosePotionCost.potion1Cost = costPer3DoseOutput / 3;
            return oneDosePotionCost.potion1Cost;
        }


        static public decimal TotalUnfPotsMade(decimal herbsUsedInput, bool portableWellCheck, bool wastelessHerbloreCheck)
        {
            PotionClass unfPotionsMade = new PotionClass();
            IngredientsClass herbCount = new IngredientsClass();
            herbCount.herbStock = herbsUsedInput;

            if (portableWellCheck == true && wastelessHerbloreCheck == true)
            {
                decimal x = 1.15m;
                unfPotionsMade.totalPotsMade = herbCount.herbStock * x;
                return unfPotionsMade.totalPotsMade;
            }
            else if (portableWellCheck == true && wastelessHerbloreCheck == false)
            {
                decimal x = 1.05m;
                unfPotionsMade.totalPotsMade = herbCount.herbStock * x;
                return unfPotionsMade.totalPotsMade;
            }
            else if (portableWellCheck == false && wastelessHerbloreCheck == true)
            {
                decimal x = 1.10m;
                unfPotionsMade.totalPotsMade = herbCount.herbStock * x;
                return unfPotionsMade.totalPotsMade;
            }
            else
            {
                unfPotionsMade.totalPotsMade = herbCount.herbStock;
                return unfPotionsMade.totalPotsMade;
            }
        }


        static public decimal TotalThreeDosePotsMade(decimal unfPotsToProcessInput, bool portableWellCheck, bool wastelessHerbloreCheck)
        {
            PotionClass threeDosePotions = new PotionClass();
            IngredientsClass secondaryIngredient = new IngredientsClass();
            secondaryIngredient.unfPotionStock = unfPotsToProcessInput;
            if (portableWellCheck == true && wastelessHerbloreCheck == true)
            {
                decimal x = 1.15m;
                threeDosePotions.totalPotsMade = unfPotsToProcessInput * x;
                return threeDosePotions.totalPotsMade;
            }
            else if (portableWellCheck == true && wastelessHerbloreCheck == false)
            {
                decimal x = 1.05m;
                threeDosePotions.totalPotsMade = unfPotsToProcessInput * x;
                return threeDosePotions.totalPotsMade;
            }
            else if (portableWellCheck == false && wastelessHerbloreCheck == true)
            {
                decimal x = 1.10m;
                threeDosePotions.totalPotsMade = unfPotsToProcessInput * x;
                return threeDosePotions.totalPotsMade;
            }
            else
            {
                threeDosePotions.totalPotsMade = unfPotsToProcessInput;
                return threeDosePotions.totalPotsMade;
            }
        }

        static public decimal ResourceCostPerPotion(decimal herbCostInput, decimal ingredientsCostInput, decimal vialOfWaterCostInput)
        {
            IngredientsClass totalIngredientsCost = new IngredientsClass();
            totalIngredientsCost.ingredientCost = ingredientsCostInput;
            totalIngredientsCost.herbCost = herbCostInput;
            totalIngredientsCost.vialOfWaterCost = vialOfWaterCostInput;
            return totalIngredientsCost.vialOfWaterCost + totalIngredientsCost.herbCost + totalIngredientsCost.ingredientCost;
        }

        static public decimal TotalFourDosePotionYield(decimal totalThreeDoseMadeOutput)
        {
            PotionClass fourDosePotions = new PotionClass();
            return fourDosePotions.totalPotsMade = (totalThreeDoseMadeOutput * 3) / 4;
        }

        static public decimal TotalResourceCost(decimal herbCostInput, decimal vialOfWaterCostInput, decimal ingredientsCostInput, decimal herbsUsedInput)
        {
            IngredientsClass ingredientsCost = new IngredientsClass();
            PotionClass potionCost = new PotionClass();
            ingredientsCost.herbCost = herbsUsedInput * herbCostInput;
            ingredientsCost.vialOfWaterCost = herbsUsedInput * vialOfWaterCostInput;
            ingredientsCost.ingredientCost = herbsUsedInput * ingredientsCostInput;
            return ingredientsCost.ingredientCost + ingredientsCost.vialOfWaterCost + ingredientsCost.herbCost;
        }

        static public decimal ValueSellingAllThreeDose(decimal threeDoseValueInput, decimal totalThreeDoseMadeOutput)
        {
            PotionClass threeDoseValue = new PotionClass();
            threeDoseValue.gePotion3Cost = threeDoseValueInput;
            threeDoseValue.totalPotsMade = totalThreeDoseMadeOutput;
            return threeDoseValue.total3DoseValue = threeDoseValue.gePotion3Cost * threeDoseValue.totalPotsMade;
        }

        static public decimal ValueSellingAllFourDose(decimal fourDoseValueInput, decimal totalFourDoseMadeOutput)
        {
            PotionClass fourDoseValue = new PotionClass();
            fourDoseValue.gePotion4Cost = fourDoseValueInput;
            fourDoseValue.totalPotsMade = totalFourDoseMadeOutput;
            return fourDoseValue.total4DoseValue = fourDoseValue.gePotion4Cost * fourDoseValue.totalPotsMade;
        }
        static public decimal ProfitLossSellingThreeDose(decimal resourceCostOutput, decimal sellingAllThreeDoseOutput)
        {
            PotionClass profitLossThreeDose = new PotionClass();
            profitLossThreeDose.totalPotionCost = resourceCostOutput;
            profitLossThreeDose.total3DoseValue = sellingAllThreeDoseOutput;
            return profitLossThreeDose.gross = profitLossThreeDose.total3DoseValue - profitLossThreeDose.totalPotionCost;
        }
        static public decimal ProfitLossSellingFourDose(decimal resourceCostOutput, decimal sellingAllFourDoseOutput)
        {
            PotionClass profitLossFourDose = new PotionClass();
            profitLossFourDose.totalPotionCost = resourceCostOutput;
            profitLossFourDose.total4DoseValue = sellingAllFourDoseOutput;
            return profitLossFourDose.gross = profitLossFourDose.total4DoseValue - profitLossFourDose.totalPotionCost;
        }
    }
}
