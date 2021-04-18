using GemateriaAssignment.Calculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GemateriaAssignment
{
    public partial class MainWindow : Form
    {
        GemateriaCalculator gemateriaCalculator;
        string hebrewPhrase;
        
        public MainWindow()
        {
            InitializeComponent();
            gemateriaCalculator = new GemateriaCalculator();
            hebrewPhrase = "";
            
        }

        private void calculateGemateriaButton_Click(object sender, EventArgs e)
        {
            long result = gemateriaCalculator.CalculateGemateria(hebrewPhrase);
            UpdateResult(result.ToString());
        }

        private void UpdateResult(string result)
        {
            numberResultTextBox.Text = result;
        }

        private void withKollelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
           gemateriaCalculator.WithKollel = withKollelCheckBox.Checked;
        }

        private void isMisparKutenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            gemateriaCalculator.IsMisparKuten = isMisparKutenCheckBox.Checked;
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            hebrewPhrase = inputTextBox.Text;
        }
    }
}
