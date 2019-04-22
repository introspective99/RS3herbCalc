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
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }
        
        private void IngredientsCostInput_Leave(object sender, EventArgs e)
            //passes information over to the Logic class when you leave the ingredientsCostInput or costPerUnfOutput boxes
        {
            costPer3DoseOutput.Value = CalculatorLogic.FinishedThreeDoseCalc(ingredientsCostInput.Value, costPerUnfOutput.Value);
            costPer1DoseOutput.Value = CalculatorLogic.FinishedOneDoseCalc(costPer3DoseOutput.Value);
        }
        private void UpdateCostPerUnfOutPut(object sender, EventArgs e)
            //passes information over to the Logic class when you leave the herbcostinput or vialofwatercostinput boxes
        {
            costPerUnfOutput.Value = CalculatorLogic.UnfinishedPotionCost(herbCostInput.Value, vialOfWaterCostInput.Value);
        }

    }
}
