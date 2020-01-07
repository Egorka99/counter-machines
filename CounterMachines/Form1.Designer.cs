namespace CounterMachines
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonNextStep = new System.Windows.Forms.Button();
            this.memoryTape = new System.Windows.Forms.DataGridView();
            this.listBoxStates = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxSecondAddend = new System.Windows.Forms.TextBox();
            this.textBoxFirstAddend = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoryTape)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(544, 50);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 39;
            this.buttonCalculate.Text = "Вычислить";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonNextStep);
            this.groupBox1.Controls.Add(this.memoryTape);
            this.groupBox1.Controls.Add(this.listBoxStates);
            this.groupBox1.Location = new System.Drawing.Point(57, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 387);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Машина Тьюринга";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Состояния:";
            // 
            // buttonNextStep
            // 
            this.buttonNextStep.Location = new System.Drawing.Point(368, 120);
            this.buttonNextStep.Name = "buttonNextStep";
            this.buttonNextStep.Size = new System.Drawing.Size(131, 62);
            this.buttonNextStep.TabIndex = 31;
            this.buttonNextStep.Text = "Вычислить";
            this.buttonNextStep.UseVisualStyleBackColor = true;
            this.buttonNextStep.Click += new System.EventHandler(this.buttonNextStep_Click);
            // 
            // memoryTape
            //  
            this.memoryTape.AllowUserToAddRows = false;
            this.memoryTape.AllowUserToDeleteRows = false;
            this.memoryTape.AllowUserToResizeColumns = false;
            this.memoryTape.AllowUserToResizeRows = false;
            this.memoryTape.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.memoryTape.ColumnHeadersHeight = 25;
            this.memoryTape.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.memoryTape.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.memoryTape.DefaultCellStyle = dataGridViewCellStyle1;
            this.memoryTape.Location = new System.Drawing.Point(29, 49);
            this.memoryTape.Name = "memoryTape";
            this.memoryTape.ReadOnly = true;
            this.memoryTape.RowHeadersVisible = false;
            this.memoryTape.RowHeadersWidth = 25;
            this.memoryTape.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.memoryTape.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.memoryTape.Size = new System.Drawing.Size(570, 42);
            this.memoryTape.TabIndex = 24;
            // 
            // listBoxStates
            // 
            this.listBoxStates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxStates.FormattingEnabled = true;
            this.listBoxStates.ItemHeight = 16;
            this.listBoxStates.Location = new System.Drawing.Point(29, 132);
            this.listBoxStates.Name = "listBoxStates";
            this.listBoxStates.Size = new System.Drawing.Size(198, 228);
            this.listBoxStates.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(327, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(197, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "+";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(351, 53);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(163, 20);
            this.textBoxResult.TabIndex = 35;
            // 
            // textBoxSecondAddend
            // 
            this.textBoxSecondAddend.Location = new System.Drawing.Point(221, 53);
            this.textBoxSecondAddend.Name = "textBoxSecondAddend";
            this.textBoxSecondAddend.Size = new System.Drawing.Size(100, 20);
            this.textBoxSecondAddend.TabIndex = 34;
            // 
            // textBoxFirstAddend
            // 
            this.textBoxFirstAddend.Location = new System.Drawing.Point(91, 53);
            this.textBoxFirstAddend.Name = "textBoxFirstAddend";
            this.textBoxFirstAddend.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstAddend.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 550);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxSecondAddend);
            this.Controls.Add(this.textBoxFirstAddend);
            this.Name = "Form1";
            this.Text = "Сложение чисел в унарной системе";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoryTape)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonNextStep;
        private System.Windows.Forms.DataGridView memoryTape;
        private System.Windows.Forms.ListBox listBoxStates;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxSecondAddend;
        private System.Windows.Forms.TextBox textBoxFirstAddend;
    }
}

