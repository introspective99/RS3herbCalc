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
            //these system.eventhandlers update the costPerUnfOutput box whenever the user clicks off of the input boxes
            this.vialOfWaterCostInput.Leave += new System.EventHandler(this.VialOfWaterCostInput_Leave);
            this.herbCostInput.Leave += new System.EventHandler(this.HerbCostInput_Leave);
        }
            //this method does the calculation for unfinished potions
        public int UnfPotCostCalculate()
        {
            PotionClass unfinishedPotion = new PotionClass();
            IngredientsClass createUnfPotHerb = new IngredientsClass();

            //this takes the input of the Herb Cost NumericUpDown and Vial of Water Cost NumericUpDown and stores the value in the unfPotionCost property of the Potion Class
            createUnfPotHerb.herbCost = Convert.ToInt32(Math.Round(herbCostInput.Value, 0));
            createUnfPotHerb.vialOfWaterCost = Convert.ToInt32(Math.Round(vialOfWaterCostInput.Value, 0));
            unfinishedPotion.unfPotionCost = createUnfPotHerb.herbCost + createUnfPotHerb.vialOfWaterCost;

            return unfinishedPotion.unfPotionCost;
        }
        private void VialOfWaterCostInput_Leave(object sender, EventArgs e)
        {
            costPerUnfOutput.Value = UnfPotCostCalculate();
        }
        private void HerbCostInput_Leave(object sender, EventArgs e)
        {
            costPerUnfOutput.Value = UnfPotCostCalculate();
        }

        /*public int FinishedPotCostCalculate()
        {

        }*/















    }
}
