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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int herbTest()
        {
            PotionClass testUnf = new PotionClass();
            IngredientsClass testHerb = new IngredientsClass();
            testHerb.herbCost = int.Parse(herbCostInput.Text);
            testHerb.vialOfWaterCost = int.Parse(vialOfWaterCost.Text);
            testUnf.unfPotionCost = testHerb.herbCost + testHerb.vialOfWaterCost;
            return testUnf.unfPotionCost;
        }

        private void UnfPotCalcButton_Click(object sender, EventArgs e)
        {
            costPerUnfOutput.Text = herbTest().ToString();
        }


    }
}
