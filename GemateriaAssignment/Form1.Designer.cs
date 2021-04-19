
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
            this.findMatchesInTorahButton = new System.Windows.Forms.Button();
            this.torahMatchesListBox = new System.Windows.Forms.ListBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultAmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(360, 62);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.inputTextBox.Size = new System.Drawing.Size(519, 23);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // numberResultTextBox
            // 
            this.numberResultTextBox.Location = new System.Drawing.Point(744, 114);
            this.numberResultTextBox.Name = "numberResultTextBox";
            this.numberResultTextBox.Size = new System.Drawing.Size(135, 23);
            this.numberResultTextBox.TabIndex = 1;
            // 
            // withKollelCheckBox
            // 
            this.withKollelCheckBox.AutoSize = true;
            this.withKollelCheckBox.Location = new System.Drawing.Point(360, 91);
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
            this.isMisparKutenCheckBox.Location = new System.Drawing.Point(360, 118);
            this.isMisparKutenCheckBox.Name = "isMisparKutenCheckBox";
            this.isMisparKutenCheckBox.Size = new System.Drawing.Size(96, 19);
            this.isMisparKutenCheckBox.TabIndex = 3;
            this.isMisparKutenCheckBox.Text = "Mispar Kuten";
            this.isMisparKutenCheckBox.UseVisualStyleBackColor = true;
            this.isMisparKutenCheckBox.CheckedChanged += new System.EventHandler(this.isMisparKutenCheckBox_CheckedChanged);
            // 
            // calculateGemateriaButton
            // 
            this.calculateGemateriaButton.Location = new System.Drawing.Point(654, 165);
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
            this.inputLabel.Location = new System.Drawing.Point(514, 31);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(195, 15);
            this.inputLabel.TabIndex = 5;
            this.inputLabel.Text = "Enter Phrase to Calculate Gemateria";
            // 
            // numberResultLabel
            // 
            this.numberResultLabel.AutoSize = true;
            this.numberResultLabel.Enabled = false;
            this.numberResultLabel.Location = new System.Drawing.Point(690, 117);
            this.numberResultLabel.Name = "numberResultLabel";
            this.numberResultLabel.Size = new System.Drawing.Size(39, 15);
            this.numberResultLabel.TabIndex = 6;
            this.numberResultLabel.Text = "Result";
            // 
            // findMatchesInTorahButton
            // 
            this.findMatchesInTorahButton.Location = new System.Drawing.Point(390, 165);
            this.findMatchesInTorahButton.Name = "findMatchesInTorahButton";
            this.findMatchesInTorahButton.Size = new System.Drawing.Size(75, 23);
            this.findMatchesInTorahButton.TabIndex = 7;
            this.findMatchesInTorahButton.Text = "Find Matches in Torah";
            this.findMatchesInTorahButton.UseMnemonic = false;
            this.findMatchesInTorahButton.UseVisualStyleBackColor = true;
            this.findMatchesInTorahButton.Click += new System.EventHandler(this.findMatchesInTorahButton_Click);
            // 
            // torahMatchesListBox
            // 
            this.torahMatchesListBox.FormattingEnabled = true;
            this.torahMatchesListBox.ItemHeight = 15;
            this.torahMatchesListBox.Location = new System.Drawing.Point(21, 208);
            this.torahMatchesListBox.Name = "torahMatchesListBox";
            this.torahMatchesListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.torahMatchesListBox.Size = new System.Drawing.Size(1167, 319);
            this.torahMatchesListBox.TabIndex = 8;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(38, 173);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(47, 15);
            this.resultLabel.TabIndex = 9;
            this.resultLabel.Text = "Results:";
            // 
            // resultAmountLabel
            // 
            this.resultAmountLabel.AutoSize = true;
            this.resultAmountLabel.Location = new System.Drawing.Point(81, 173);
            this.resultAmountLabel.Name = "resultAmountLabel";
            this.resultAmountLabel.Size = new System.Drawing.Size(0, 15);
            this.resultAmountLabel.TabIndex = 10;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 617);
            this.Controls.Add(this.resultAmountLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.torahMatchesListBox);
            this.Controls.Add(this.findMatchesInTorahButton);
            this.Controls.Add(this.numberResultLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.calculateGemateriaButton);
            this.Controls.Add(this.isMisparKutenCheckBox);
            this.Controls.Add(this.withKollelCheckBox);
            this.Controls.Add(this.numberResultTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Name = "MainWindow";
            this.Text = "Results:";
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
        private System.Windows.Forms.Button findMatchesInTorahButton;
        private System.Windows.Forms.ListBox torahMatchesListBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label resultAmountLabel;
    }
}

