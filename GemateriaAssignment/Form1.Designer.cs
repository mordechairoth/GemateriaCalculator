
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
            this.inputTextBox.Location = new System.Drawing.Point(140, 67);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(519, 23);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            this.inputTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // numberResultTextBox
            // 
            this.numberResultTextBox.Location = new System.Drawing.Point(524, 119);
            this.numberResultTextBox.Name = "numberResultTextBox";
            this.numberResultTextBox.Size = new System.Drawing.Size(135, 23);
            this.numberResultTextBox.TabIndex = 1;
            // 
            // withKollelCheckBox
            // 
            this.withKollelCheckBox.AutoSize = true;
            this.withKollelCheckBox.Location = new System.Drawing.Point(140, 96);
            this.withKollelCheckBox.Name = "withKollelCheckBox";
            this.withKollelCheckBox.Size = new System.Drawing.Size(83, 19);
            this.withKollelCheckBox.TabIndex = 2;
            this.withKollelCheckBox.Text = "With Kollel";
            this.withKollelCheckBox.UseVisualStyleBackColor = true;
            this.withKollelCheckBox.CheckedChanged += new System.EventHandler(this.withKollelCheckBox_CheckedChanged);
            // 
            // isMisparKutenCheckBox
            // 
            this.isMisparKutenCheckBox.AutoSize = true;
            this.isMisparKutenCheckBox.Location = new System.Drawing.Point(140, 123);
            this.isMisparKutenCheckBox.Name = "isMisparKutenCheckBox";
            this.isMisparKutenCheckBox.Size = new System.Drawing.Size(96, 19);
            this.isMisparKutenCheckBox.TabIndex = 3;
            this.isMisparKutenCheckBox.Text = "Mispar Kuten";
            this.isMisparKutenCheckBox.UseVisualStyleBackColor = true;
            this.isMisparKutenCheckBox.CheckedChanged += new System.EventHandler(this.isMisparKutenCheckBox_CheckedChanged);
            // 
            // calculateGemateriaButton
            // 
            this.calculateGemateriaButton.Location = new System.Drawing.Point(314, 165);
            this.calculateGemateriaButton.Name = "calculateGemateriaButton";
            this.calculateGemateriaButton.Size = new System.Drawing.Size(75, 23);
            this.calculateGemateriaButton.TabIndex = 4;
            this.calculateGemateriaButton.Text = "Calculate Gemateria";
            this.calculateGemateriaButton.UseVisualStyleBackColor = true;
            this.calculateGemateriaButton.Click += new System.EventHandler(this.calculateGemateriaButton_Click);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(294, 36);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(165, 15);
            this.inputLabel.TabIndex = 5;
            this.inputLabel.Text = "Phrase to Calculate Gemateria";
            // 
            // numberResultLabel
            // 
            this.numberResultLabel.AutoSize = true;
            this.numberResultLabel.Enabled = false;
            this.numberResultLabel.Location = new System.Drawing.Point(470, 122);
            this.numberResultLabel.Name = "numberResultLabel";
            this.numberResultLabel.Size = new System.Drawing.Size(39, 15);
            this.numberResultLabel.TabIndex = 6;
            this.numberResultLabel.Text = "Result";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numberResultLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.calculateGemateriaButton);
            this.Controls.Add(this.isMisparKutenCheckBox);
            this.Controls.Add(this.withKollelCheckBox);
            this.Controls.Add(this.numberResultTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Name = "MainWindow";
            this.Text = "Form1";
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

