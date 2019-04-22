using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RS3herbCalc
{
    public partial class PotionCalculator : Form
    {
        public PotionCalculator()
        {
            InitializeComponent();
            //these system.eventhandlers update the output boxes whenever the user clicks off of the input boxes
            this.vialOfWaterCostInput.Leave += new System.EventHandler(this.VialOfWaterCostInput_Leave);
            this.herbCostInput.Leave += new System.EventHandler(this.HerbCostInput_Leave);
            this.ingredientsCostInput.Leave += new System.EventHandler(this.IngredientsCostInput_Leave);
        }

        public int UnfinishedPotionCost()
        {
            PotionClass unfinishedPotion = new PotionClass();
            IngredientsClass unfinishedPotionHerb = new IngredientsClass();

            //this takes the input of the Herb Cost NumericUpDown and Vial of Water Cost NumericUpDown and stores the value in the unfPotionCost property of the Potion Class
            unfinishedPotionHerb.herbCost = Convert.ToInt32(Math.Round(herbCostInput.Value, 0));
            unfinishedPotionHerb.vialOfWaterCost = Convert.ToInt32(Math.Round(vialOfWaterCostInput.Value, 0));
            unfinishedPotion.unfPotionCost = unfinishedPotionHerb.herbCost + unfinishedPotionHerb.vialOfWaterCost;

            return unfinishedPotion.unfPotionCost;
        }

        public int FinishedThreeDoseCalc()
        {
            IngredientsClass extraIngredient = new IngredientsClass();
            PotionClass threeDosePotionCost = new PotionClass();

            //this takes the input of ingredients and adds it to the previously found Unfinished Potion Cost
            extraIngredient.ingredientCost = Convert.ToInt32(Math.Round(ingredientsCostInput.Value, 0));
            threeDosePotionCost.potion3Cost = extraIngredient.ingredientCost + UnfinishedPotionCost();

            return threeDosePotionCost.potion3Cost;
        }

        public int FinishedOneDoseCalc()
        {
            PotionClass oneDosePotionCost = new PotionClass();

            //this takes the 3 dose potion and divides it by three to work out the cost of 1 dose of the potion
            const int x = 3;
            oneDosePotionCost.potion1Cost = FinishedThreeDoseCalc() / x;

            return oneDosePotionCost.potion1Cost;
        }
        
        //these methods update the output boxes when leaving an input box
        private void IngredientsCostInput_Leave(object sender, EventArgs e)
        {
            costPer3DoseOutput.Value = FinishedThreeDoseCalc();
            costPer1DoseOutput.Value = FinishedOneDoseCalc();
        }
        private void VialOfWaterCostInput_Leave(object sender, EventArgs e)
        {
            costPerUnfOutput.Value = UnfinishedPotionCost();
        }
        private void HerbCostInput_Leave(object sender, EventArgs e)
        {
            costPerUnfOutput.Value = UnfinishedPotionCost();
        }
    }
}
