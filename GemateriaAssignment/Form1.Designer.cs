
namespace GemateriaAssignment
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.numberResultTextBox = new System.Windows.Forms.TextBox();
            this.withKollelCheckBox = new System.Windows.Forms.CheckBox();
            this.isMisparKutenCheckBox = new System.Windows.Forms.CheckBox();
            this.calculateGemateriaButton = new System.Windows.Forms.Button();
            this.inputLabel = new System.Windows.Forms.Label();
            this.numberResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(160, 89);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.inputTextBox.Size = new System.Drawing.Size(593, 27);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // numberResultTextBox
            // 
            this.numberResultTextBox.Location = new System.Drawing.Point(599, 159);
            this.numberResultTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numberResultTextBox.Name = "numberResultTextBox";
            this.numberResultTextBox.Size = new System.Drawing.Size(154, 27);
            this.numberResultTextBox.TabIndex = 1;
            // 
            // withKollelCheckBox
            // 
            this.withKollelCheckBox.AutoSize = true;
            this.withKollelCheckBox.Location = new System.Drawing.Point(160, 128);
            this.withKollelCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.withKollelCheckBox.Name = "withKollelCheckBox";
            this.withKollelCheckBox.Size = new System.Drawing.Size(104, 24);
            this.withKollelCheckBox.TabIndex = 2;
            this.withKollelCheckBox.Text = "With Kollel";
            this.withKollelCheckBox.UseVisualStyleBackColor = true;
            this.withKollelCheckBox.CheckedChanged += new System.EventHandler(this.withKollelCheckBox_CheckedChanged);
            // 
            // isMisparKutenCheckBox
            // 
            this.isMisparKutenCheckBox.AutoSize = true;
            this.isMisparKutenCheckBox.Location = new System.Drawing.Point(160, 164);
            this.isMisparKutenCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.isMisparKutenCheckBox.Name = "isMisparKutenCheckBox";
            this.isMisparKutenCheckBox.Size = new System.Drawing.Size(118, 24);
            this.isMisparKutenCheckBox.TabIndex = 3;
            this.isMisparKutenCheckBox.Text = "Mispar Kuten";
            this.isMisparKutenCheckBox.UseVisualStyleBackColor = true;
            this.isMisparKutenCheckBox.CheckedChanged += new System.EventHandler(this.isMisparKutenCheckBox_CheckedChanged);
            // 
            // calculateGemateriaButton
            // 
            this.calculateGemateriaButton.Location = new System.Drawing.Point(359, 220);
            this.calculateGemateriaButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calculateGemateriaButton.Name = "calculateGemateriaButton";
            this.calculateGemateriaButton.Size = new System.Drawing.Size(86, 31);
            this.calculateGemateriaButton.TabIndex = 4;
            this.calculateGemateriaButton.Text = "Calculate Gemateria";
            this.calculateGemateriaButton.UseVisualStyleBackColor = true;
            this.calculateGemateriaButton.Click += new System.EventHandler(this.calculateGemateriaButton_Click);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(336, 48);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(246, 20);
            this.inputLabel.TabIndex = 5;
            this.inputLabel.Text = "Enter Phrase to Calculate Gemateria";
            // 
            // numberResultLabel
            // 
            this.numberResultLabel.AutoSize = true;
            this.numberResultLabel.Enabled = false;
            this.numberResultLabel.Location = new System.Drawing.Point(537, 163);
            this.numberResultLabel.Name = "numberResultLabel";
            this.numberResultLabel.Size = new System.Drawing.Size(49, 20);
            this.numberResultLabel.TabIndex = 6;
            this.numberResultLabel.Text = "Result";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.numberResultLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.calculateGemateriaButton);
            this.Controls.Add(this.isMisparKutenCheckBox);
            this.Controls.Add(this.withKollelCheckBox);
            this.Controls.Add(this.numberResultTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.Text = "Gemateria Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox numberResultTextBox;
        private System.Windows.Forms.CheckBox withKollelCheckBox;
        private System.Windows.Forms.CheckBox isMisparKutenCheckBox;
        private System.Windows.Forms.Button calculateGemateriaButton;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label numberResultLabel;
    }
}

