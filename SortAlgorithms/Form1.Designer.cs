﻿namespace SortAlgorithms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.FillButton = new System.Windows.Forms.Button();
            this.FillTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BubbleSortBtn = new System.Windows.Forms.Button();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.CompareLbl = new System.Windows.Forms.Label();
            this.SwopLbl = new System.Windows.Forms.Label();
            this.CocktailSortBtn = new System.Windows.Forms.Button();
            this.InsertSortBtn = new System.Windows.Forms.Button();
            this.ShellSortBtn = new System.Windows.Forms.Button();
            this.SelectionSortBtn = new System.Windows.Forms.Button();
            this.HeapSortBtn = new System.Windows.Forms.Button();
            this.GnomeSortBtn = new System.Windows.Forms.Button();
            this.TreeSortBtn = new System.Windows.Forms.Button();
            this.LsdRadixSortBtn = new System.Windows.Forms.Button();
            this.MsdRadixSortBtn = new System.Windows.Forms.Button();
            this.MergeSortBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.AddTextBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 61);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавить число";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(246, 24);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(15, 25);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(228, 20);
            this.AddTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.FillButton);
            this.panel2.Controls.Add(this.FillTextBox);
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 61);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Заполнить массив случайными числами";
            // 
            // FillButton
            // 
            this.FillButton.Location = new System.Drawing.Point(246, 24);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(75, 23);
            this.FillButton.TabIndex = 1;
            this.FillButton.Text = "Заполнить";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // FillTextBox
            // 
            this.FillTextBox.Location = new System.Drawing.Point(15, 25);
            this.FillTextBox.Name = "FillTextBox";
            this.FillTextBox.Size = new System.Drawing.Size(228, 20);
            this.FillTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(339, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(676, 128);
            this.panel3.TabIndex = 4;
            // 
            // BubbleSortBtn
            // 
            this.BubbleSortBtn.Location = new System.Drawing.Point(15, 134);
            this.BubbleSortBtn.Name = "BubbleSortBtn";
            this.BubbleSortBtn.Size = new System.Drawing.Size(75, 23);
            this.BubbleSortBtn.TabIndex = 5;
            this.BubbleSortBtn.Text = "BubbleSort";
            this.BubbleSortBtn.UseVisualStyleBackColor = true;
            this.BubbleSortBtn.Click += new System.EventHandler(this.BubbleSortBtn_Click);
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Location = new System.Drawing.Point(12, 171);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(43, 13);
            this.TimeLbl.TabIndex = 6;
            this.TimeLbl.Text = "Время:";
            // 
            // CompareLbl
            // 
            this.CompareLbl.AutoSize = true;
            this.CompareLbl.Location = new System.Drawing.Point(12, 193);
            this.CompareLbl.Name = "CompareLbl";
            this.CompareLbl.Size = new System.Drawing.Size(129, 13);
            this.CompareLbl.TabIndex = 6;
            this.CompareLbl.Text = "Количество сравнений: ";
            // 
            // SwopLbl
            // 
            this.SwopLbl.AutoSize = true;
            this.SwopLbl.Location = new System.Drawing.Point(12, 216);
            this.SwopLbl.Name = "SwopLbl";
            this.SwopLbl.Size = new System.Drawing.Size(116, 13);
            this.SwopLbl.TabIndex = 6;
            this.SwopLbl.Text = "Количество обменов:";
            // 
            // CocktailSortBtn
            // 
            this.CocktailSortBtn.Location = new System.Drawing.Point(96, 134);
            this.CocktailSortBtn.Name = "CocktailSortBtn";
            this.CocktailSortBtn.Size = new System.Drawing.Size(75, 23);
            this.CocktailSortBtn.TabIndex = 7;
            this.CocktailSortBtn.Text = "CocktailSort";
            this.CocktailSortBtn.UseVisualStyleBackColor = true;
            this.CocktailSortBtn.Click += new System.EventHandler(this.CocktailSortBtn_Click);
            // 
            // InsertSortBtn
            // 
            this.InsertSortBtn.Location = new System.Drawing.Point(177, 134);
            this.InsertSortBtn.Name = "InsertSortBtn";
            this.InsertSortBtn.Size = new System.Drawing.Size(75, 23);
            this.InsertSortBtn.TabIndex = 8;
            this.InsertSortBtn.Text = "InsertSort";
            this.InsertSortBtn.UseVisualStyleBackColor = true;
            this.InsertSortBtn.Click += new System.EventHandler(this.InsertSortBtn_Click);
            // 
            // ShellSortBtn
            // 
            this.ShellSortBtn.Location = new System.Drawing.Point(258, 134);
            this.ShellSortBtn.Name = "ShellSortBtn";
            this.ShellSortBtn.Size = new System.Drawing.Size(75, 23);
            this.ShellSortBtn.TabIndex = 9;
            this.ShellSortBtn.Text = "ShellSort";
            this.ShellSortBtn.UseVisualStyleBackColor = true;
            this.ShellSortBtn.Click += new System.EventHandler(this.ShellSortBtn_Click);
            // 
            // SelectionSortBtn
            // 
            this.SelectionSortBtn.Location = new System.Drawing.Point(339, 134);
            this.SelectionSortBtn.Name = "SelectionSortBtn";
            this.SelectionSortBtn.Size = new System.Drawing.Size(80, 23);
            this.SelectionSortBtn.TabIndex = 10;
            this.SelectionSortBtn.Text = "SelectionSort";
            this.SelectionSortBtn.UseVisualStyleBackColor = true;
            this.SelectionSortBtn.Click += new System.EventHandler(this.SelectionSortBtn_Click);
            // 
            // HeapSortBtn
            // 
            this.HeapSortBtn.Location = new System.Drawing.Point(425, 134);
            this.HeapSortBtn.Name = "HeapSortBtn";
            this.HeapSortBtn.Size = new System.Drawing.Size(63, 23);
            this.HeapSortBtn.TabIndex = 11;
            this.HeapSortBtn.Text = "HeapSort";
            this.HeapSortBtn.UseVisualStyleBackColor = true;
            this.HeapSortBtn.Click += new System.EventHandler(this.HeapSortBtn_Click);
            // 
            // GnomeSortBtn
            // 
            this.GnomeSortBtn.Location = new System.Drawing.Point(494, 134);
            this.GnomeSortBtn.Name = "GnomeSortBtn";
            this.GnomeSortBtn.Size = new System.Drawing.Size(78, 23);
            this.GnomeSortBtn.TabIndex = 12;
            this.GnomeSortBtn.Text = "GnomeSort";
            this.GnomeSortBtn.UseVisualStyleBackColor = true;
            this.GnomeSortBtn.Click += new System.EventHandler(this.GnomeSortBtn_Click);
            // 
            // TreeSortBtn
            // 
            this.TreeSortBtn.Location = new System.Drawing.Point(578, 134);
            this.TreeSortBtn.Name = "TreeSortBtn";
            this.TreeSortBtn.Size = new System.Drawing.Size(62, 23);
            this.TreeSortBtn.TabIndex = 13;
            this.TreeSortBtn.Text = "TreeSort";
            this.TreeSortBtn.UseVisualStyleBackColor = true;
            this.TreeSortBtn.Click += new System.EventHandler(this.TreeSortBtn_Click);
            // 
            // LsdRadixSortBtn
            // 
            this.LsdRadixSortBtn.Location = new System.Drawing.Point(646, 134);
            this.LsdRadixSortBtn.Name = "LsdRadixSortBtn";
            this.LsdRadixSortBtn.Size = new System.Drawing.Size(86, 23);
            this.LsdRadixSortBtn.TabIndex = 14;
            this.LsdRadixSortBtn.Text = "LsdRadixSort";
            this.LsdRadixSortBtn.UseVisualStyleBackColor = true;
            this.LsdRadixSortBtn.Click += new System.EventHandler(this.LsdRadixSortBtn_Click);
            // 
            // MsdRadixSortBtn
            // 
            this.MsdRadixSortBtn.Location = new System.Drawing.Point(738, 134);
            this.MsdRadixSortBtn.Name = "MsdRadixSortBtn";
            this.MsdRadixSortBtn.Size = new System.Drawing.Size(86, 23);
            this.MsdRadixSortBtn.TabIndex = 15;
            this.MsdRadixSortBtn.Text = "MsdRadixSort";
            this.MsdRadixSortBtn.UseVisualStyleBackColor = true;
            this.MsdRadixSortBtn.Click += new System.EventHandler(this.MsdRadixSortBtn_Click);
            // 
            // MergeSortBtn
            // 
            this.MergeSortBtn.Location = new System.Drawing.Point(830, 134);
            this.MergeSortBtn.Name = "MergeSortBtn";
            this.MergeSortBtn.Size = new System.Drawing.Size(70, 23);
            this.MergeSortBtn.TabIndex = 16;
            this.MergeSortBtn.Text = "MergeSort";
            this.MergeSortBtn.UseVisualStyleBackColor = true;
            this.MergeSortBtn.Click += new System.EventHandler(this.MergeSortBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 243);
            this.Controls.Add(this.MergeSortBtn);
            this.Controls.Add(this.MsdRadixSortBtn);
            this.Controls.Add(this.LsdRadixSortBtn);
            this.Controls.Add(this.TreeSortBtn);
            this.Controls.Add(this.GnomeSortBtn);
            this.Controls.Add(this.HeapSortBtn);
            this.Controls.Add(this.SelectionSortBtn);
            this.Controls.Add(this.ShellSortBtn);
            this.Controls.Add(this.InsertSortBtn);
            this.Controls.Add(this.CocktailSortBtn);
            this.Controls.Add(this.SwopLbl);
            this.Controls.Add(this.CompareLbl);
            this.Controls.Add(this.TimeLbl);
            this.Controls.Add(this.BubbleSortBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.TextBox FillTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BubbleSortBtn;
        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.Label CompareLbl;
        private System.Windows.Forms.Label SwopLbl;
        private System.Windows.Forms.Button CocktailSortBtn;
        private System.Windows.Forms.Button InsertSortBtn;
        private System.Windows.Forms.Button ShellSortBtn;
        private System.Windows.Forms.Button SelectionSortBtn;
        private System.Windows.Forms.Button HeapSortBtn;
        private System.Windows.Forms.Button GnomeSortBtn;
        private System.Windows.Forms.Button TreeSortBtn;
        private System.Windows.Forms.Button LsdRadixSortBtn;
        private System.Windows.Forms.Button MsdRadixSortBtn;
        private System.Windows.Forms.Button MergeSortBtn;
    }
}

