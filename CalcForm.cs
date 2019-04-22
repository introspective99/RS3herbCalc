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
            foreach (Control c in this.Controls)
            {
                if (c is NumericUpDown)
                {
                    c.Leave += new System.EventHandler(UpdateCostPerUnfOutput);
                    c.Enter += new System.EventHandler(UpdateCostPerUnfOutput);
                    c.Leave += new System.EventHandler(UpdateDoseOutputs);
                    c.Enter += new System.EventHandler(UpdateDoseOutputs);
                    c.Leave += new System.EventHandler(UpdateTotalUnfPotsMade);
                    c.Enter += new System.EventHandler(UpdateTotalUnfPotsMade);
                    c.Leave += new System.EventHandler(UpdateTotalThreeDosePotMadeOutput);
                    c.Enter += new System.EventHandler(UpdateTotalThreeDosePotMadeOutput);
                    c.Leave += new System.EventHandler(UpdatePricePerPotionOutput);
                    c.Enter += new System.EventHandler(UpdatePricePerPotionOutput);
                    c.Leave += new System.EventHandler(UpdateFourDoseValueOutput);
                    c.Enter += new System.EventHandler(UpdateFourDoseValueOutput);
                    c.Leave += new System.EventHandler(UpdateResourceCostOutput);
                    c.Enter += new System.EventHandler(UpdateResourceCostOutput);
                    c.Leave += new System.EventHandler(UpdateSellAllThreeDoseOutput);
                    c.Enter += new System.EventHandler(UpdateSellAllThreeDoseOutput);
                    c.Leave += new System.EventHandler(UpdateSellAllFourDoseOutput);
                    c.Enter += new System.EventHandler(UpdateSellAllFourDoseOutput);
                    c.Leave += new System.EventHandler(UpdateProfitLossThreeDose);
                    c.Enter += new System.EventHandler(UpdateProfitLossThreeDose);
                    c.Enter += new System.EventHandler(UpdateProfitLossFourDose);
                    c.Enter += new System.EventHandler(UpdateProfitLossFourDose);




                }
            }
        }
        
        private void UpdateDoseOutputs(object sender, EventArgs e)
            //passes information over to the Logic class when you leave the ingredientsCostInput or costPerUnfOutput boxes
        {
            costPer3DoseOutput.Value = CalculatorLogic.FinishedThreeDoseCalc(ingredientsCostInput.Value, costPerUnfOutput.Value);
            costPer1DoseOutput.Value = CalculatorLogic.FinishedOneDoseCalc(costPer3DoseOutput.Value);
        }

        private void UpdateCostPerUnfOutput(object sender, EventArgs e)
            //passes information over to the Logic class when you leave the herbcostinput or vialofwatercostinput boxes
        {
            costPerUnfOutput.Value = CalculatorLogic.UnfinishedPotionCost(herbCostInput.Value, vialOfWaterCostInput.Value);
        }

        private void UpdateTotalUnfPotsMade(object sender, EventArgs e)
        {
            totalUnfPotsMadeOutput.Value = CalculatorLogic.TotalUnfPotsMade(herbsUsedInput.Value, portableWellCheck.Checked, wastelessHerbloreCheck.Checked);

            if (selfmadeUnfsCheck.Checked == true)
            {
                unfPotsToProcessInput.Value = CalculatorLogic.TotalUnfPotsMade(herbsUsedInput.Value, portableWellCheck.Checked, wastelessHerbloreCheck.Checked);
            }
            else { }
        }

        private void UpdateTotalThreeDosePotMadeOutput(object sender, EventArgs e)
        {
            totalThreeDoseMadeOutput.Value = CalculatorLogic.TotalThreeDosePotsMade(unfPotsToProcessInput.Value, portableWellCheck.Checked, wastelessHerbloreCheck.Checked);
        }

        private void UpdatePricePerPotionOutput(object sender, EventArgs e)
        {
            pricePerPotionOutput.Value = CalculatorLogic.ResourceCostPerPotion(herbCostInput.Value, ingredientsCostInput.Value, vialOfWaterCostInput.Value);
        }

        private void UpdateFourDoseValueOutput(object sender, EventArgs e)
        {
            totalFourDoseMadeOutput.Value = CalculatorLogic.TotalFourDosePotionYield(totalThreeDoseMadeOutput.Value);
        }

        private void UpdateResourceCostOutput(object sender, EventArgs e)
        {
            resourceCostOutput.Value = CalculatorLogic.TotalResourceCost(herbCostInput.Value, vialOfWaterCostInput.Value, ingredientsCostInput.Value, herbsUsedInput.Value);
        }

        private void UpdateSellAllThreeDoseOutput(object sender, EventArgs e)
        {
            sellingAllThreeDoseOutput.Value = CalculatorLogic.ValueSellingAllThreeDose(threeDoseValueInput.Value, totalThreeDoseMadeOutput.Value);
        }

        private void UpdateSellAllFourDoseOutput(object sender, EventArgs e)
        {
            sellingAllFourDoseOutput.Value = CalculatorLogic.ValueSellingAllFourDose(fourDoseValueInput.Value, totalFourDoseMadeOutput.Value);
        }

        private void UpdateProfitLossThreeDose(object sender, EventArgs e)
        {
            profitLossThreeDoseOutput.Value = CalculatorLogic.ProfitLossSellingThreeDose(resourceCostOutput.Value, sellingAllThreeDoseOutput.Value);
        }

        private void UpdateProfitLossFourDose(object sender, EventArgs e)
        {
            profitLossFourDoseOutput.Value = CalculatorLogic.ProfitLossSellingFourDose(resourceCostOutput.Value, sellingAllFourDoseOutput.Value);
        }

 
    }
}
