namespace RS3herbCalc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.herbCostLabel = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.ingredientCost = new System.Windows.Forms.Label();
            this.vialOfWaterCost = new System.Windows.Forms.Label();
            this.grimyCleanCheck = new System.Windows.Forms.CheckBox();
            this.portableWellCheck = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.factoryOutfitCheck = new System.Windows.Forms.CheckBox();
            this.botanistAmuletCheck = new System.Windows.Forms.CheckBox();
            this.wastelessHerbloreCheck = new System.Windows.Forms.CheckBox();
            this.costPer3DoseOutput = new System.Windows.Forms.TextBox();
            this.costPer1DoseOutput = new System.Windows.Forms.TextBox();
            this.potionDoseLabel = new System.Windows.Forms.Label();
            this.costPer3DoseLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.potion3GECostLabel = new System.Windows.Forms.Label();
            this.costPerUnfLabel = new System.Windows.Forms.Label();
            this.UnfPotCalcButton = new System.Windows.Forms.Button();
            this.herbCostInput = new System.Windows.Forms.NumericUpDown();
            this.costPerUnfOutput = new System.Windows.Forms.NumericUpDown();
            this.vialOfWaterCostInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.herbCostInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costPerUnfOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vialOfWaterCostInput)).BeginInit();
            this.SuspendLayout();
            // 
            // herbCostLabel
            // 
            this.herbCostLabel.AutoSize = true;
            this.herbCostLabel.Location = new System.Drawing.Point(12, 9);
            this.herbCostLabel.Name = "herbCostLabel";
            this.herbCostLabel.Size = new System.Drawing.Size(54, 13);
            this.herbCostLabel.TabIndex = 0;
            this.herbCostLabel.Text = "Herb Cost";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(15, 104);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(139, 20);
            this.textBox5.TabIndex = 6;
            // 
            // ingredientCost
            // 
            this.ingredientCost.AutoSize = true;
            this.ingredientCost.Location = new System.Drawing.Point(12, 87);
            this.ingredientCost.Name = "ingredientCost";
            this.ingredientCost.Size = new System.Drawing.Size(78, 13);
            this.ingredientCost.TabIndex = 11;
            this.ingredientCost.Text = "Ingredient Cost";
            // 
            // vialOfWaterCost
            // 
            this.vialOfWaterCost.AutoSize = true;
            this.vialOfWaterCost.Location = new System.Drawing.Point(12, 48);
            this.vialOfWaterCost.Name = "vialOfWaterCost";
            this.vialOfWaterCost.Size = new System.Drawing.Size(92, 13);
            this.vialOfWaterCost.TabIndex = 12;
            this.vialOfWaterCost.Text = "Vial of Water Cost";
            // 
            // grimyCleanCheck
            // 
            this.grimyCleanCheck.AutoSize = true;
            this.grimyCleanCheck.Location = new System.Drawing.Point(15, 212);
            this.grimyCleanCheck.Name = "grimyCleanCheck";
            this.grimyCleanCheck.Size = new System.Drawing.Size(91, 17);
            this.grimyCleanCheck.TabIndex = 13;
            this.grimyCleanCheck.Text = "Is herb grimy?";
            this.grimyCleanCheck.UseVisualStyleBackColor = true;
            // 
            // portableWellCheck
            // 
            this.portableWellCheck.AutoSize = true;
            this.portableWellCheck.Location = new System.Drawing.Point(15, 258);
            this.portableWellCheck.Name = "portableWellCheck";
            this.portableWellCheck.Size = new System.Drawing.Size(125, 17);
            this.portableWellCheck.TabIndex = 19;
            this.portableWellCheck.Text = "Using Portable Well?";
            this.portableWellCheck.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 394);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(213, 17);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "check if using Unf pots instead of herbs";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // factoryOutfitCheck
            // 
            this.factoryOutfitCheck.AutoSize = true;
            this.factoryOutfitCheck.Location = new System.Drawing.Point(15, 304);
            this.factoryOutfitCheck.Name = "factoryOutfitCheck";
            this.factoryOutfitCheck.Size = new System.Drawing.Size(161, 17);
            this.factoryOutfitCheck.TabIndex = 24;
            this.factoryOutfitCheck.Text = "Using Factory outfit 3 piece?";
            this.factoryOutfitCheck.UseVisualStyleBackColor = true;
            // 
            // botanistAmuletCheck
            // 
            this.botanistAmuletCheck.AutoSize = true;
            this.botanistAmuletCheck.Location = new System.Drawing.Point(15, 281);
            this.botanistAmuletCheck.Name = "botanistAmuletCheck";
            this.botanistAmuletCheck.Size = new System.Drawing.Size(139, 17);
            this.botanistAmuletCheck.TabIndex = 25;
            this.botanistAmuletCheck.Text = "Using Botanist amulets?";
            this.botanistAmuletCheck.UseVisualStyleBackColor = true;
            // 
            // wastelessHerbloreCheck
            // 
            this.wastelessHerbloreCheck.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.wastelessHerbloreCheck.AutoSize = true;
            this.wastelessHerbloreCheck.Location = new System.Drawing.Point(15, 235);
            this.wastelessHerbloreCheck.Name = "wastelessHerbloreCheck";
            this.wastelessHerbloreCheck.Size = new System.Drawing.Size(236, 17);
            this.wastelessHerbloreCheck.TabIndex = 26;
            this.wastelessHerbloreCheck.Text = "Are you using the Wasteless Herblore scroll?";
            this.wastelessHerbloreCheck.UseVisualStyleBackColor = true;
            // 
            // costPer3DoseOutput
            // 
            this.costPer3DoseOutput.Location = new System.Drawing.Point(206, 104);
            this.costPer3DoseOutput.Name = "costPer3DoseOutput";
            this.costPer3DoseOutput.Size = new System.Drawing.Size(139, 20);
            this.costPer3DoseOutput.TabIndex = 27;
            // 
            // costPer1DoseOutput
            // 
            this.costPer1DoseOutput.Location = new System.Drawing.Point(206, 64);
            this.costPer1DoseOutput.Name = "costPer1DoseOutput";
            this.costPer1DoseOutput.Size = new System.Drawing.Size(139, 20);
            this.costPer1DoseOutput.TabIndex = 28;
            // 
            // potionDoseLabel
            // 
            this.potionDoseLabel.AutoSize = true;
            this.potionDoseLabel.Location = new System.Drawing.Point(203, 48);
            this.potionDoseLabel.Name = "potionDoseLabel";
            this.potionDoseLabel.Size = new System.Drawing.Size(108, 13);
            this.potionDoseLabel.TabIndex = 29;
            this.potionDoseLabel.Text = "Cost Per Potion Dose";
            // 
            // costPer3DoseLabel
            // 
            this.costPer3DoseLabel.AutoSize = true;
            this.costPer3DoseLabel.Location = new System.Drawing.Point(203, 87);
            this.costPer3DoseLabel.Name = "costPer3DoseLabel";
            this.costPer3DoseLabel.Size = new System.Drawing.Size(117, 13);
            this.costPer3DoseLabel.TabIndex = 30;
            this.costPer3DoseLabel.Text = "Cost Per 3 Dose Potion";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 143);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 20);
            this.textBox3.TabIndex = 31;
            // 
            // potion3GECostLabel
            // 
            this.potion3GECostLabel.AutoSize = true;
            this.potion3GECostLabel.Location = new System.Drawing.Point(12, 127);
            this.potion3GECostLabel.Name = "potion3GECostLabel";
            this.potion3GECostLabel.Size = new System.Drawing.Size(116, 13);
            this.potion3GECostLabel.TabIndex = 32;
            this.potion3GECostLabel.Text = "3 Dose Potion GE Cost";
            // 
            // costPerUnfLabel
            // 
            this.costPerUnfLabel.AutoSize = true;
            this.costPerUnfLabel.Location = new System.Drawing.Point(203, 9);
            this.costPerUnfLabel.Name = "costPerUnfLabel";
            this.costPerUnfLabel.Size = new System.Drawing.Size(133, 13);
            this.costPerUnfLabel.TabIndex = 34;
            this.costPerUnfLabel.Text = "Cost Per Unfinished Potion";
            // 
            // UnfPotCalcButton
            // 
            this.UnfPotCalcButton.Location = new System.Drawing.Point(218, 143);
            this.UnfPotCalcButton.Name = "UnfPotCalcButton";
            this.UnfPotCalcButton.Size = new System.Drawing.Size(102, 25);
            this.UnfPotCalcButton.TabIndex = 35;
            this.UnfPotCalcButton.Text = "Calculate Unf Pot Cost";
            this.UnfPotCalcButton.UseVisualStyleBackColor = true;
            this.UnfPotCalcButton.Click += new System.EventHandler(this.UnfPotCalcButton_Click);
            // 
            // herbCostInput
            // 
            this.herbCostInput.Location = new System.Drawing.Point(15, 26);
            this.herbCostInput.Name = "herbCostInput";
            this.herbCostInput.Size = new System.Drawing.Size(120, 20);
            this.herbCostInput.TabIndex = 36;
            // 
            // costPerUnfOutput
            // 
            this.costPerUnfOutput.Location = new System.Drawing.Point(206, 26);
            this.costPerUnfOutput.Name = "costPerUnfOutput";
            this.costPerUnfOutput.Size = new System.Drawing.Size(120, 20);
            this.costPerUnfOutput.TabIndex = 37;
            // 
            // vialOfWaterCostInput
            // 
            this.vialOfWaterCostInput.Location = new System.Drawing.Point(15, 65);
            this.vialOfWaterCostInput.Name = "vialOfWaterCostInput";
            this.vialOfWaterCostInput.Size = new System.Drawing.Size(120, 20);
            this.vialOfWaterCostInput.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 423);
            this.Controls.Add(this.vialOfWaterCostInput);
            this.Controls.Add(this.costPerUnfOutput);
            this.Controls.Add(this.herbCostInput);
            this.Controls.Add(this.UnfPotCalcButton);
            this.Controls.Add(this.costPerUnfLabel);
            this.Controls.Add(this.potion3GECostLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.costPer3DoseLabel);
            this.Controls.Add(this.potionDoseLabel);
            this.Controls.Add(this.costPer1DoseOutput);
            this.Controls.Add(this.costPer3DoseOutput);
            this.Controls.Add(this.wastelessHerbloreCheck);
            this.Controls.Add(this.botanistAmuletCheck);
            this.Controls.Add(this.factoryOutfitCheck);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.portableWellCheck);
            this.Controls.Add(this.grimyCleanCheck);
            this.Controls.Add(this.vialOfWaterCost);
            this.Controls.Add(this.ingredientCost);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.herbCostLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.herbCostInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costPerUnfOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vialOfWaterCostInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label herbCostLabel;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label ingredientCost;
        private System.Windows.Forms.Label vialOfWaterCost;
        private System.Windows.Forms.CheckBox grimyCleanCheck;
        private System.Windows.Forms.CheckBox portableWellCheck;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox factoryOutfitCheck;
        private System.Windows.Forms.CheckBox botanistAmuletCheck;
        private System.Windows.Forms.CheckBox wastelessHerbloreCheck;
        private System.Windows.Forms.TextBox costPer3DoseOutput;
        private System.Windows.Forms.TextBox costPer1DoseOutput;
        private System.Windows.Forms.Label potionDoseLabel;
        private System.Windows.Forms.Label costPer3DoseLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label potion3GECostLabel;
        private System.Windows.Forms.Label costPerUnfLabel;
        private System.Windows.Forms.Button UnfPotCalcButton;
        private System.Windows.Forms.NumericUpDown herbCostInput;
        private System.Windows.Forms.NumericUpDown costPerUnfOutput;
        private System.Windows.Forms.NumericUpDown vialOfWaterCostInput;
    }
}

