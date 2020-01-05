using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CounterMachines
{
    public partial class Form1 : Form
    {
        String FirstAddend;
        String SecondAddend;

        public Form1()
        {
            InitializeComponent();
            FirstAddend = String.Empty;
            SecondAddend = String.Empty;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            FirstAddend = textBoxFirstAddend.Text;
            SecondAddend = textBoxSecondAddend.Text;

            buttonCalculate.Enabled = false;

            FillMemoryTape(); 
            //проверки
        }

        private void FillMemoryTape()
        {
            memoryTape.RowCount = 1;
            memoryTape.ColumnCount = 11;

            int Index = 1;
             
            memoryTape.Rows[0].Cells[0].Value = "#";

            for (int i = 0; i < FirstAddend.Length; i++)
            {
                memoryTape.Rows[0].Cells[Index++].Value = FirstAddend.ElementAt(i);
            }
             
            memoryTape.Rows[0].Cells[Index++].Value = "+"; 

            for (int j = 0; j < SecondAddend.Length; j++)
            {
                memoryTape.Rows[0].Cells[Index++].Value = SecondAddend.ElementAt(j);
            }

            memoryTape.Rows[0].Cells[Index++].Value = "#";


            memoryTape.ClearSelection();
        } 

        private void buttonNextStep_Click(object sender, EventArgs e)
        {
        }
    }
}
