﻿namespace RS3herbCalc
{
    partial class CalcForm
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
            this.ingredientCost = new System.Windows.Forms.Label();
            this.vialOfWaterCost = new System.Windows.Forms.Label();
            this.grimyCleanCheck = new System.Windows.Forms.CheckBox();
            this.portableWellCheck = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.factoryOutfitCheck = new System.Windows.Forms.CheckBox();
            this.botanistAmuletCheck = new System.Windows.Forms.CheckBox();
            this.wastelessHerbloreCheck = new System.Windows.Forms.CheckBox();
            this.potionDoseLabel = new System.Windows.Forms.Label();
            this.costPer3DoseLabel = new System.Windows.Forms.Label();
            this.costPerUnfLabel = new System.Windows.Forms.Label();
            this.herbCostInput = new System.Windows.Forms.NumericUpDown();
            this.costPerUnfOutput = new System.Windows.Forms.NumericUpDown();
            this.vialOfWaterCostInput = new System.Windows.Forms.NumericUpDown();
            this.ingredientsCostInput = new System.Windows.Forms.NumericUpDown();
            this.costPer1DoseOutput = new System.Windows.Forms.NumericUpDown();
            this.costPer3DoseOutput = new System.Windows.Forms.NumericUpDown();
            this.herbsUsedInput = new System.Windows.Forms.NumericUpDown();
            this.herbsUsedLabel = new System.Windows.Forms.Label();
            this.totalPotsMadeOutput = new System.Windows.Forms.NumericUpDown();
            this.totalPotsMadeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.herbCostInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costPerUnfOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vialOfWaterCostInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsCostInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costPer1DoseOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costPer3DoseOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.herbsUsedInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPotsMadeOutput)).BeginInit();
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
            // costPerUnfLabel
            // 
            this.costPerUnfLabel.AutoSize = true;
            this.costPerUnfLabel.Location = new System.Drawing.Point(203, 9);
            this.costPerUnfLabel.Name = "costPerUnfLabel";
            this.costPerUnfLabel.Size = new System.Drawing.Size(133, 13);
            this.costPerUnfLabel.TabIndex = 34;
            this.costPerUnfLabel.Text = "Cost Per Unfinished Potion";
            // 
            // herbCostInput
            // 
            this.herbCostInput.Location = new System.Drawing.Point(15, 26);
            this.herbCostInput.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.herbCostInput.Name = "herbCostInput";
            this.herbCostInput.Size = new System.Drawing.Size(120, 20);
            this.herbCostInput.TabIndex = 36;
            this.herbCostInput.Leave += new System.EventHandler(this.UpdateCostPerUnfOutPut);
            // 
            // costPerUnfOutput
            // 
            this.costPerUnfOutput.Location = new System.Drawing.Point(206, 26);
            this.costPerUnfOutput.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.costPerUnfOutput.Name = "costPerUnfOutput";
            this.costPerUnfOutput.Size = new System.Drawing.Size(120, 20);
            this.costPerUnfOutput.TabIndex = 37;
            // 
            // vialOfWaterCostInput
            // 
            this.vialOfWaterCostInput.Location = new System.Drawing.Point(15, 65);
            this.vialOfWaterCostInput.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.vialOfWaterCostInput.Name = "vialOfWaterCostInput";
            this.vialOfWaterCostInput.Size = new System.Drawing.Size(120, 20);
            this.vialOfWaterCostInput.TabIndex = 38;
            this.vialOfWaterCostInput.Leave += new System.EventHandler(this.UpdateCostPerUnfOutPut);
            // 
            // ingredientsCostInput
            // 
            this.ingredientsCostInput.Location = new System.Drawing.Point(15, 104);
            this.ingredientsCostInput.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.ingredientsCostInput.Name = "ingredientsCostInput";
            this.ingredientsCostInput.Size = new System.Drawing.Size(120, 20);
            this.ingredientsCostInput.TabIndex = 40;
            this.ingredientsCostInput.Leave += new System.EventHandler(this.IngredientsCostInput_Leave);
            // 
            // costPer1DoseOutput
            // 
            this.costPer1DoseOutput.Location = new System.Drawing.Point(206, 65);
            this.costPer1DoseOutput.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.costPer1DoseOutput.Name = "costPer1DoseOutput";
            this.costPer1DoseOutput.Size = new System.Drawing.Size(120, 20);
            this.costPer1DoseOutput.TabIndex = 41;
            // 
            // costPer3DoseOutput
            // 
            this.costPer3DoseOutput.Location = new System.Drawing.Point(206, 104);
            this.costPer3DoseOutput.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.costPer3DoseOutput.Name = "costPer3DoseOutput";
            this.costPer3DoseOutput.Size = new System.Drawing.Size(120, 20);
            this.costPer3DoseOutput.TabIndex = 42;
            // 
            // herbsUsedInput
            // 
            this.herbsUsedInput.Location = new System.Drawing.Point(15, 143);
            this.herbsUsedInput.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.herbsUsedInput.Name = "herbsUsedInput";
            this.herbsUsedInput.Size = new System.Drawing.Size(120, 20);
            this.herbsUsedInput.TabIndex = 43;
            // 
            // herbsUsedLabel
            // 
            this.herbsUsedLabel.AutoSize = true;
            this.herbsUsedLabel.Location = new System.Drawing.Point(12, 127);
            this.herbsUsedLabel.Name = "herbsUsedLabel";
            this.herbsUsedLabel.Size = new System.Drawing.Size(121, 13);
            this.herbsUsedLabel.TabIndex = 44;
            this.herbsUsedLabel.Text = "No# of herbs to process";
            // 
            // totalPotsMadeOutput
            // 
            this.totalPotsMadeOutput.Location = new System.Drawing.Point(206, 143);
            this.totalPotsMadeOutput.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.totalPotsMadeOutput.Name = "totalPotsMadeOutput";
            this.totalPotsMadeOutput.Size = new System.Drawing.Size(120, 20);
            this.totalPotsMadeOutput.TabIndex = 45;
            // 
            // totalPotsMadeLabel
            // 
            this.totalPotsMadeLabel.AutoSize = true;
            this.totalPotsMadeLabel.Location = new System.Drawing.Point(203, 127);
            this.totalPotsMadeLabel.Name = "totalPotsMadeLabel";
            this.totalPotsMadeLabel.Size = new System.Drawing.Size(120, 13);
            this.totalPotsMadeLabel.TabIndex = 46;
            this.totalPotsMadeLabel.Text = "Total 3 dose Pots Made";
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 423);
            this.Controls.Add(this.totalPotsMadeLabel);
            this.Controls.Add(this.totalPotsMadeOutput);
            this.Controls.Add(this.herbsUsedLabel);
            this.Controls.Add(this.herbsUsedInput);
            this.Controls.Add(this.costPer3DoseOutput);
            this.Controls.Add(this.costPer1DoseOutput);
            this.Controls.Add(this.ingredientsCostInput);
            this.Controls.Add(this.vialOfWaterCostInput);
            this.Controls.Add(this.costPerUnfOutput);
            this.Controls.Add(this.herbCostInput);
            this.Controls.Add(this.costPerUnfLabel);
            this.Controls.Add(this.costPer3DoseLabel);
            this.Controls.Add(this.potionDoseLabel);
            this.Controls.Add(this.wastelessHerbloreCheck);
            this.Controls.Add(this.botanistAmuletCheck);
            this.Controls.Add(this.factoryOutfitCheck);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.portableWellCheck);
            this.Controls.Add(this.grimyCleanCheck);
            this.Controls.Add(this.vialOfWaterCost);
            this.Controls.Add(this.ingredientCost);
            this.Controls.Add(this.herbCostLabel);
            this.Name = "CalcForm";
            this.Text = "RS3 Potion Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.herbCostInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costPerUnfOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vialOfWaterCostInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsCostInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costPer1DoseOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costPer3DoseOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.herbsUsedInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPotsMadeOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label herbCostLabel;
        private System.Windows.Forms.Label ingredientCost;
        private System.Windows.Forms.Label vialOfWaterCost;
        private System.Windows.Forms.CheckBox grimyCleanCheck;
        private System.Windows.Forms.CheckBox portableWellCheck;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox factoryOutfitCheck;
        private System.Windows.Forms.CheckBox botanistAmuletCheck;
        private System.Windows.Forms.CheckBox wastelessHerbloreCheck;
        private System.Windows.Forms.Label potionDoseLabel;
        private System.Windows.Forms.Label costPer3DoseLabel;
        private System.Windows.Forms.Label costPerUnfLabel;
        private System.Windows.Forms.NumericUpDown herbCostInput;
        private System.Windows.Forms.NumericUpDown costPerUnfOutput;
        private System.Windows.Forms.NumericUpDown vialOfWaterCostInput;
        private System.Windows.Forms.NumericUpDown ingredientsCostInput;
        private System.Windows.Forms.NumericUpDown costPer1DoseOutput;
        private System.Windows.Forms.NumericUpDown costPer3DoseOutput;
        private System.Windows.Forms.NumericUpDown herbsUsedInput;
        private System.Windows.Forms.Label herbsUsedLabel;
        private System.Windows.Forms.NumericUpDown totalPotsMadeOutput;
        private System.Windows.Forms.Label totalPotsMadeLabel;
    }
}
