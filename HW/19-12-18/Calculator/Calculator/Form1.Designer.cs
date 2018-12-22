namespace Calculator
{
    partial class calcBody
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
            this.firstNumTxtBx = new System.Windows.Forms.MaskedTextBox();
            this.secondNumTxtBx = new System.Windows.Forms.MaskedTextBox();
            this.resultsList = new System.Windows.Forms.ListBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SubtractBtn = new System.Windows.Forms.Button();
            this.MultiplyBtn = new System.Windows.Forms.Button();
            this.DivideBtn = new System.Windows.Forms.Button();
            this.RootBtn = new System.Windows.Forms.Button();
            this.PowerBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNumTxtBx
            // 
            this.firstNumTxtBx.Location = new System.Drawing.Point(207, 61);
            this.firstNumTxtBx.Name = "firstNumTxtBx";
            this.firstNumTxtBx.Size = new System.Drawing.Size(106, 26);
            this.firstNumTxtBx.TabIndex = 0;
            this.firstNumTxtBx.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.firstNumTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstNumTxtBx_KeyPress);
            // 
            // secondNumTxtBx
            // 
            this.secondNumTxtBx.Location = new System.Drawing.Point(449, 61);
            this.secondNumTxtBx.Name = "secondNumTxtBx";
            this.secondNumTxtBx.Size = new System.Drawing.Size(106, 26);
            this.secondNumTxtBx.TabIndex = 1;
            this.secondNumTxtBx.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            this.secondNumTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secondNumTxtBx_KeyPress);
            // 
            // resultsList
            // 
            this.resultsList.FormattingEnabled = true;
            this.resultsList.ItemHeight = 20;
            this.resultsList.Location = new System.Drawing.Point(207, 165);
            this.resultsList.Name = "resultsList";
            this.resultsList.Size = new System.Drawing.Size(348, 164);
            this.resultsList.TabIndex = 2;
            this.resultsList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AddBtn.Location = new System.Drawing.Point(207, 365);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(106, 49);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "+";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SubtractBtn
            // 
            this.SubtractBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SubtractBtn.Location = new System.Drawing.Point(449, 365);
            this.SubtractBtn.Name = "SubtractBtn";
            this.SubtractBtn.Size = new System.Drawing.Size(106, 49);
            this.SubtractBtn.TabIndex = 4;
            this.SubtractBtn.Text = "-";
            this.SubtractBtn.UseVisualStyleBackColor = true;
            this.SubtractBtn.Click += new System.EventHandler(this.SubtractBtn_Click);
            // 
            // MultiplyBtn
            // 
            this.MultiplyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MultiplyBtn.Location = new System.Drawing.Point(207, 452);
            this.MultiplyBtn.Name = "MultiplyBtn";
            this.MultiplyBtn.Size = new System.Drawing.Size(106, 49);
            this.MultiplyBtn.TabIndex = 5;
            this.MultiplyBtn.Text = "*";
            this.MultiplyBtn.UseVisualStyleBackColor = true;
            this.MultiplyBtn.Click += new System.EventHandler(this.MultiplyBtn_Click);
            // 
            // DivideBtn
            // 
            this.DivideBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DivideBtn.Location = new System.Drawing.Point(449, 452);
            this.DivideBtn.Name = "DivideBtn";
            this.DivideBtn.Size = new System.Drawing.Size(106, 49);
            this.DivideBtn.TabIndex = 6;
            this.DivideBtn.Text = "/";
            this.DivideBtn.UseVisualStyleBackColor = true;
            this.DivideBtn.Click += new System.EventHandler(this.DivideBtn_Click);
            // 
            // RootBtn
            // 
            this.RootBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RootBtn.Location = new System.Drawing.Point(207, 539);
            this.RootBtn.Name = "RootBtn";
            this.RootBtn.Size = new System.Drawing.Size(106, 49);
            this.RootBtn.TabIndex = 7;
            this.RootBtn.Text = "Root";
            this.RootBtn.UseVisualStyleBackColor = true;
            this.RootBtn.Click += new System.EventHandler(this.RootBtn_Click);
            // 
            // PowerBtn
            // 
            this.PowerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PowerBtn.Location = new System.Drawing.Point(449, 539);
            this.PowerBtn.Name = "PowerBtn";
            this.PowerBtn.Size = new System.Drawing.Size(106, 49);
            this.PowerBtn.TabIndex = 8;
            this.PowerBtn.Text = "Power of";
            this.PowerBtn.UseVisualStyleBackColor = true;
            this.PowerBtn.Click += new System.EventHandler(this.PowerBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ClearBtn.Location = new System.Drawing.Point(207, 626);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(106, 49);
            this.ClearBtn.TabIndex = 9;
            this.ClearBtn.Text = "C";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Add.Location = new System.Drawing.Point(449, 626);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(106, 49);
            this.Add.TabIndex = 10;
            this.Add.Text = "Randomize";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Second Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Calculator Results";
            // 
            // calcBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 703);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.PowerBtn);
            this.Controls.Add(this.RootBtn);
            this.Controls.Add(this.DivideBtn);
            this.Controls.Add(this.MultiplyBtn);
            this.Controls.Add(this.SubtractBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.resultsList);
            this.Controls.Add(this.secondNumTxtBx);
            this.Controls.Add(this.firstNumTxtBx);
            this.Name = "calcBody";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox firstNumTxtBx;
        private System.Windows.Forms.MaskedTextBox secondNumTxtBx;
        private System.Windows.Forms.ListBox resultsList;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button SubtractBtn;
        private System.Windows.Forms.Button MultiplyBtn;
        private System.Windows.Forms.Button DivideBtn;
        private System.Windows.Forms.Button RootBtn;
        private System.Windows.Forms.Button PowerBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

