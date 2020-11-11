using System.Windows.Forms;

namespace PsychrometricTable
{
    class ComboItem
    {
        public string DryThermometerValue { get; set; }
        public int Value { get; set; }
        public string Text { get; set; }
    }

    partial class PsychrometricTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PsychrometricTableForm));
            this.labelOfDryThermometer = new System.Windows.Forms.Label();
            this.labelOfWetThermometer = new System.Windows.Forms.Label();
            this.dryThermometerCombobox = new System.Windows.Forms.ComboBox();
            this.wetThermometerCombobox = new System.Windows.Forms.ComboBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.airPressureLabel = new System.Windows.Forms.Label();
            this.airPressureCombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelOfDryThermometer
            // 
            this.labelOfDryThermometer.AutoSize = true;
            this.labelOfDryThermometer.Location = new System.Drawing.Point(22, 19);
            this.labelOfDryThermometer.Name = "labelOfDryThermometer";
            this.labelOfDryThermometer.Size = new System.Drawing.Size(187, 13);
            this.labelOfDryThermometer.TabIndex = 0;
            this.labelOfDryThermometer.Text = "Показание сухого термометра (°C):";
            // 
            // labelOfWetThermometer
            // 
            this.labelOfWetThermometer.AutoSize = true;
            this.labelOfWetThermometer.Location = new System.Drawing.Point(22, 55);
            this.labelOfWetThermometer.Name = "labelOfWetThermometer";
            this.labelOfWetThermometer.Size = new System.Drawing.Size(203, 13);
            this.labelOfWetThermometer.TabIndex = 1;
            this.labelOfWetThermometer.Text = "Показание влажного термометра (°C):";
            // 
            // dryThermometerCombobox
            // 
            this.dryThermometerCombobox.FormattingEnabled = true;
            this.dryThermometerCombobox.Location = new System.Drawing.Point(231, 16);
            this.dryThermometerCombobox.Name = "dryThermometerCombobox";
            this.dryThermometerCombobox.Size = new System.Drawing.Size(70, 21);
            this.dryThermometerCombobox.TabIndex = 2;
            this.dryThermometerCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.dryThermometerCombobox.SelectedIndexChanged += new System.EventHandler(this.DryThermometerCombobox_SelectedIndexChanged);
            // 
            // wetThermometerCombobox
            // 
            this.wetThermometerCombobox.FormattingEnabled = true;
            this.wetThermometerCombobox.Location = new System.Drawing.Point(231, 52);
            this.wetThermometerCombobox.Name = "wetThermometerCombobox";
            this.wetThermometerCombobox.Size = new System.Drawing.Size(70, 21);
            this.wetThermometerCombobox.TabIndex = 3;
            this.wetThermometerCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(118, 130);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // airPressureLabel
            // 
            this.airPressureLabel.AutoSize = true;
            this.airPressureLabel.Location = new System.Drawing.Point(22, 88);
            this.airPressureLabel.Name = "airPressureLabel";
            this.airPressureLabel.Size = new System.Drawing.Size(166, 13);
            this.airPressureLabel.TabIndex = 5;
            this.airPressureLabel.Text = "Давление воздуха (мм. рт. ст.):";
            // 
            // airPressureCombobox
            // 
            this.airPressureCombobox.FormattingEnabled = true;
            this.airPressureCombobox.Location = new System.Drawing.Point(231, 85);
            this.airPressureCombobox.Name = "airPressureCombobox";
            this.airPressureCombobox.Size = new System.Drawing.Size(70, 21);
            this.airPressureCombobox.TabIndex = 6;
            this.airPressureCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // PsychrometricTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 171);
            this.Controls.Add(this.airPressureCombobox);
            this.Controls.Add(this.airPressureLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.wetThermometerCombobox);
            this.Controls.Add(this.dryThermometerCombobox);
            this.Controls.Add(this.labelOfWetThermometer);
            this.Controls.Add(this.labelOfDryThermometer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PsychrometricTableForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Психрометрическая таблица";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOfDryThermometer;
        private System.Windows.Forms.Label labelOfWetThermometer;
        private System.Windows.Forms.ComboBox dryThermometerCombobox;
        private System.Windows.Forms.ComboBox wetThermometerCombobox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label airPressureLabel;
        private System.Windows.Forms.ComboBox airPressureCombobox;
    }
}

