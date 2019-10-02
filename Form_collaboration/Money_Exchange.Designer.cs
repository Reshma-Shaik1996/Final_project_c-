namespace semester2_Final_Project
{
    partial class Money_Exchange
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioFrom_INR = new System.Windows.Forms.RadioButton();
            this.radioFrom_GBP = new System.Windows.Forms.RadioButton();
            this.radioFrom_EUR = new System.Windows.Forms.RadioButton();
            this.radioFrom_USD = new System.Windows.Forms.RadioButton();
            this.radioFrom_CAD = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioTo_INR = new System.Windows.Forms.RadioButton();
            this.radioTo_GBP = new System.Windows.Forms.RadioButton();
            this.radioTo_EUR = new System.Windows.Forms.RadioButton();
            this.radioTo_USD = new System.Windows.Forms.RadioButton();
            this.radioTo_CAD = new System.Windows.Forms.RadioButton();
            this.txtBox_From = new System.Windows.Forms.TextBox();
            this.txtBox_To = new System.Windows.Forms.TextBox();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.btn_Read = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioFrom_INR);
            this.groupBox1.Controls.Add(this.radioFrom_GBP);
            this.groupBox1.Controls.Add(this.radioFrom_EUR);
            this.groupBox1.Controls.Add(this.radioFrom_USD);
            this.groupBox1.Controls.Add(this.radioFrom_CAD);
            this.groupBox1.Location = new System.Drawing.Point(105, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(224, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From";
            // 
            // radioFrom_INR
            // 
            this.radioFrom_INR.AutoSize = true;
            this.radioFrom_INR.Location = new System.Drawing.Point(38, 333);
            this.radioFrom_INR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioFrom_INR.Name = "radioFrom_INR";
            this.radioFrom_INR.Size = new System.Drawing.Size(78, 29);
            this.radioFrom_INR.TabIndex = 4;
            this.radioFrom_INR.TabStop = true;
            this.radioFrom_INR.Text = "INR";
            this.radioFrom_INR.UseVisualStyleBackColor = true;
            this.radioFrom_INR.CheckedChanged += new System.EventHandler(this.RadioFrom_INR_CheckedChanged);
            // 
            // radioFrom_GBP
            // 
            this.radioFrom_GBP.AutoSize = true;
            this.radioFrom_GBP.Location = new System.Drawing.Point(38, 267);
            this.radioFrom_GBP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioFrom_GBP.Name = "radioFrom_GBP";
            this.radioFrom_GBP.Size = new System.Drawing.Size(87, 29);
            this.radioFrom_GBP.TabIndex = 3;
            this.radioFrom_GBP.TabStop = true;
            this.radioFrom_GBP.Text = "GBP";
            this.radioFrom_GBP.UseVisualStyleBackColor = true;
            this.radioFrom_GBP.CheckedChanged += new System.EventHandler(this.RadioFrom_GBP_CheckedChanged);
            // 
            // radioFrom_EUR
            // 
            this.radioFrom_EUR.AutoSize = true;
            this.radioFrom_EUR.Location = new System.Drawing.Point(38, 194);
            this.radioFrom_EUR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioFrom_EUR.Name = "radioFrom_EUR";
            this.radioFrom_EUR.Size = new System.Drawing.Size(87, 29);
            this.radioFrom_EUR.TabIndex = 2;
            this.radioFrom_EUR.TabStop = true;
            this.radioFrom_EUR.Text = "EUR";
            this.radioFrom_EUR.UseVisualStyleBackColor = true;
            this.radioFrom_EUR.CheckedChanged += new System.EventHandler(this.RadioFrom_EUR_CheckedChanged);
            // 
            // radioFrom_USD
            // 
            this.radioFrom_USD.AutoSize = true;
            this.radioFrom_USD.Location = new System.Drawing.Point(38, 131);
            this.radioFrom_USD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioFrom_USD.Name = "radioFrom_USD";
            this.radioFrom_USD.Size = new System.Drawing.Size(87, 29);
            this.radioFrom_USD.TabIndex = 1;
            this.radioFrom_USD.TabStop = true;
            this.radioFrom_USD.Text = "USD";
            this.radioFrom_USD.UseVisualStyleBackColor = true;
            this.radioFrom_USD.CheckedChanged += new System.EventHandler(this.RadioFrom_USD_CheckedChanged);
            // 
            // radioFrom_CAD
            // 
            this.radioFrom_CAD.AutoSize = true;
            this.radioFrom_CAD.Location = new System.Drawing.Point(38, 62);
            this.radioFrom_CAD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioFrom_CAD.Name = "radioFrom_CAD";
            this.radioFrom_CAD.Size = new System.Drawing.Size(87, 29);
            this.radioFrom_CAD.TabIndex = 0;
            this.radioFrom_CAD.TabStop = true;
            this.radioFrom_CAD.Text = "CAD";
            this.radioFrom_CAD.UseVisualStyleBackColor = true;
            this.radioFrom_CAD.CheckedChanged += new System.EventHandler(this.RadioFrom_CAD_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioTo_INR);
            this.groupBox2.Controls.Add(this.radioTo_GBP);
            this.groupBox2.Controls.Add(this.radioTo_EUR);
            this.groupBox2.Controls.Add(this.radioTo_USD);
            this.groupBox2.Controls.Add(this.radioTo_CAD);
            this.groupBox2.Location = new System.Drawing.Point(416, 88);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(224, 402);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // radioTo_INR
            // 
            this.radioTo_INR.AutoSize = true;
            this.radioTo_INR.Location = new System.Drawing.Point(33, 333);
            this.radioTo_INR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioTo_INR.Name = "radioTo_INR";
            this.radioTo_INR.Size = new System.Drawing.Size(78, 29);
            this.radioTo_INR.TabIndex = 5;
            this.radioTo_INR.TabStop = true;
            this.radioTo_INR.Text = "INR";
            this.radioTo_INR.UseVisualStyleBackColor = true;
            // 
            // radioTo_GBP
            // 
            this.radioTo_GBP.AutoSize = true;
            this.radioTo_GBP.Location = new System.Drawing.Point(33, 267);
            this.radioTo_GBP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioTo_GBP.Name = "radioTo_GBP";
            this.radioTo_GBP.Size = new System.Drawing.Size(87, 29);
            this.radioTo_GBP.TabIndex = 4;
            this.radioTo_GBP.TabStop = true;
            this.radioTo_GBP.Text = "GBP";
            this.radioTo_GBP.UseVisualStyleBackColor = true;
            // 
            // radioTo_EUR
            // 
            this.radioTo_EUR.AutoSize = true;
            this.radioTo_EUR.Location = new System.Drawing.Point(34, 194);
            this.radioTo_EUR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioTo_EUR.Name = "radioTo_EUR";
            this.radioTo_EUR.Size = new System.Drawing.Size(87, 29);
            this.radioTo_EUR.TabIndex = 3;
            this.radioTo_EUR.TabStop = true;
            this.radioTo_EUR.Text = "EUR";
            this.radioTo_EUR.UseVisualStyleBackColor = true;
            // 
            // radioTo_USD
            // 
            this.radioTo_USD.AutoSize = true;
            this.radioTo_USD.Location = new System.Drawing.Point(34, 131);
            this.radioTo_USD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioTo_USD.Name = "radioTo_USD";
            this.radioTo_USD.Size = new System.Drawing.Size(87, 29);
            this.radioTo_USD.TabIndex = 2;
            this.radioTo_USD.TabStop = true;
            this.radioTo_USD.Text = "USD";
            this.radioTo_USD.UseVisualStyleBackColor = true;
            // 
            // radioTo_CAD
            // 
            this.radioTo_CAD.AutoSize = true;
            this.radioTo_CAD.Location = new System.Drawing.Point(34, 62);
            this.radioTo_CAD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioTo_CAD.Name = "radioTo_CAD";
            this.radioTo_CAD.Size = new System.Drawing.Size(87, 29);
            this.radioTo_CAD.TabIndex = 1;
            this.radioTo_CAD.TabStop = true;
            this.radioTo_CAD.Text = "CAD";
            this.radioTo_CAD.UseVisualStyleBackColor = true;
            // 
            // txtBox_From
            // 
            this.txtBox_From.Location = new System.Drawing.Point(105, 545);
            this.txtBox_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBox_From.Name = "txtBox_From";
            this.txtBox_From.Size = new System.Drawing.Size(222, 31);
            this.txtBox_From.TabIndex = 2;
            // 
            // txtBox_To
            // 
            this.txtBox_To.Location = new System.Drawing.Point(416, 545);
            this.txtBox_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBox_To.Name = "txtBox_To";
            this.txtBox_To.ReadOnly = true;
            this.txtBox_To.Size = new System.Drawing.Size(222, 31);
            this.txtBox_To.TabIndex = 3;
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(78, 614);
            this.btn_Convert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(150, 50);
            this.btn_Convert.TabIndex = 4;
            this.btn_Convert.Text = "&Convert";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.Btn_Convert_Click);
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(264, 614);
            this.btn_Read.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(154, 48);
            this.btn_Read.TabIndex = 5;
            this.btn_Read.Text = "&Read File";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.Btn_Read_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(450, 616);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 48);
            this.button2.TabIndex = 6;
            this.button2.Text = "&Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Money_Exchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 697);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Read);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.txtBox_To);
            this.Controls.Add(this.txtBox_From);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Money_Exchange";
            this.Text = "Money_Exchange";
            this.Load += new System.EventHandler(this.Money_Exchange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioFrom_GBP;
        private System.Windows.Forms.RadioButton radioFrom_EUR;
        private System.Windows.Forms.RadioButton radioFrom_USD;
        private System.Windows.Forms.RadioButton radioFrom_CAD;
        private System.Windows.Forms.RadioButton radioTo_INR;
        private System.Windows.Forms.RadioButton radioTo_GBP;
        private System.Windows.Forms.RadioButton radioTo_EUR;
        private System.Windows.Forms.RadioButton radioTo_USD;
        private System.Windows.Forms.RadioButton radioTo_CAD;
        private System.Windows.Forms.TextBox txtBox_From;
        private System.Windows.Forms.TextBox txtBox_To;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.RadioButton radioFrom_INR;
        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.Button button2;
    }
}