using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapStone_WinFormTest2
{
    public partial class Form1 : Form
    {
        Combination combination = new Combination();
        List<TextBox> TextBoxes = new List<TextBox>();

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateTextBoxesList() 
        {
            TextBoxes.Clear();
            TextBoxes.Add(textBox1);
            TextBoxes.Add(textBox2);
            TextBoxes.Add(textBox3);
            TextBoxes.Add(textBox4);
            TextBoxes.Add(textBox5);
            TextBoxes.Add(textBox6);
            TextBoxes.Add(textBox7);
            TextBoxes.Add(textBox8);
            TextBoxes.Add(textBox9);
        }

        private void HighlightSelectedTextBoxes(int[] Values)
        {
            foreach (int Value in Values) 
            {
                TextBoxes[Value - 1].Text = "X";
            }
        }

        private void ResetTextBoxes() 
        {
            foreach (TextBox textBox in TextBoxes) 
            {
                textBox.Text = string.Empty;
            }
        }

        private void DisplaySet(int[] Set) 
        {
            LblCombination.Text = string.Join(", ", Set);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateTextBoxesList();
        }

        private void BtnGenerateCombination_Click(object sender, EventArgs e)
        {
            var Set = combination.GetCombination();
            ResetTextBoxes();
            HighlightSelectedTextBoxes(Set);
            DisplaySet(Set);
        }
    }
}
