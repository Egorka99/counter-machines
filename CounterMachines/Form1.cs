using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            memoryTape.RowCount = 2;
            memoryTape.ColumnCount = 11;
            memoryTape.ClearSelection();
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
            int Index = 1;
              
            memoryTape.Rows[0].Cells[0].Value = "#"; 
            memoryTape.Rows[1].Cells[0].Value = "▲";  

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

        }

        private void buttonNextStep_Click(object sender, EventArgs e)
        {
            listBoxStates.Items.Add("(q1)#->(q1)#R");

            for (int i = 1; i < memoryTape.ColumnCount; i++)
            {
                memoryTape.Rows[1].Cells[i-1].Value = ""; 
                memoryTape.Rows[1].Cells[i].Value = "▲";
                memoryTape.Refresh();
                 

                if (memoryTape.Rows[0].Cells[i].Value.ToString() == "+")
                {
                    memoryTape.Rows[0].Cells[i].Value = "1";
                    listBoxStates.Items.Add("(q1)1->(q1)1R");
                    listBoxStates.Items.Add("(q1)+->(q2)1R");
                    Thread.Sleep(1000); 
                }
                if (memoryTape.Rows[0].Cells[i].Value.ToString() == "#")
                {
                    memoryTape.Rows[0].Cells[i-1].Value = "#";
                    listBoxStates.Items.Add("(q2)1->(q2)1R");
                    listBoxStates.Items.Add("(q2)#->(q3)#L"); 
                    listBoxStates.Items.Add("(q3)1->(q0)#L");
                    break;
                }  
                else
                {
                    Thread.Sleep(1000);
                }
            }
        } 
    }
}
