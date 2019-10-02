namespace semester2_Final_Project
{
    partial class TemperatureConvert
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
            this.radio_CtoF = new System.Windows.Forms.RadioButton();
            this.radio_FtoC = new System.Windows.Forms.RadioButton();
            this.txt_From = new System.Windows.Forms.TextBox();
            this.txt_To = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_From = new System.Windows.Forms.Label();
            this.lbl_To = new System.Windows.Forms.Label();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_Message = new System.Windows.Forms.TextBox();
            this.btn_Read = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radio_CtoF
            // 
            this.radio_CtoF.AutoSize = true;
            this.radio_CtoF.Location = new System.Drawing.Point(212, 39);
            this.radio_CtoF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radio_CtoF.Name = "radio_CtoF";
            this.radio_CtoF.Size = new System.Drawing.Size(156, 29);
            this.radio_CtoF.TabIndex = 0;
            this.radio_CtoF.TabStop = true;
            this.radio_CtoF.Text = "From C to F";
            this.radio_CtoF.UseVisualStyleBackColor = true;
            this.radio_CtoF.CheckedChanged += new System.EventHandler(this.Radio_CtoF_CheckedChanged);
            // 
            // radio_FtoC
            // 
            this.radio_FtoC.AutoSize = true;
            this.radio_FtoC.Location = new System.Drawing.Point(212, 106);
            this.radio_FtoC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radio_FtoC.Name = "radio_FtoC";
            this.radio_FtoC.Size = new System.Drawing.Size(156, 29);
            this.radio_FtoC.TabIndex = 1;
            this.radio_FtoC.TabStop = true;
            this.radio_FtoC.Text = "From F to C";
            this.radio_FtoC.UseVisualStyleBackColor = true;
            this.radio_FtoC.CheckedChanged += new System.EventHandler(this.Radio_FtoC_CheckedChanged);
            // 
            // txt_From
            // 
            this.txt_From.Location = new System.Drawing.Point(40, 223);
            this.txt_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_From.Name = "txt_From";
            this.txt_From.Size = new System.Drawing.Size(188, 31);
            this.txt_From.TabIndex = 2;
            // 
            // txt_To
            // 
            this.txt_To.Location = new System.Drawing.Point(363, 223);
            this.txt_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_To.Name = "txt_To";
            this.txt_To.ReadOnly = true;
            this.txt_To.Size = new System.Drawing.Size(188, 31);
            this.txt_To.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "to";
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_From.Location = new System.Drawing.Point(66, 278);
            this.lbl_From.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(41, 37);
            this.lbl_From.TabIndex = 5;
            this.lbl_From.Text = "C";
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_To.Location = new System.Drawing.Point(399, 278);
            this.lbl_To.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(38, 37);
            this.lbl_To.TabIndex = 6;
            this.lbl_To.Text = "F";
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(40, 592);
            this.btn_Convert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(138, 56);
            this.btn_Convert.TabIndex = 7;
            this.btn_Convert.Text = "&Convert";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.Btn_Convert_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(406, 592);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(138, 56);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "&Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 356);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Message:";
            // 
            // txtbox_Message
            // 
            this.txtbox_Message.Location = new System.Drawing.Point(45, 389);
            this.txtbox_Message.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbox_Message.Multiline = true;
            this.txtbox_Message.Name = "txtbox_Message";
            this.txtbox_Message.ReadOnly = true;
            this.txtbox_Message.Size = new System.Drawing.Size(498, 192);
            this.txtbox_Message.TabIndex = 10;
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(212, 592);
            this.btn_Read.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(153, 55);
            this.btn_Read.TabIndex = 11;
            this.btn_Read.Text = "&Read File";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.Btn_Read_Click);
            // 
            // TemperatureConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 677);
            this.Controls.Add(this.btn_Read);
            this.Controls.Add(this.txtbox_Message);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.lbl_To);
            this.Controls.Add(this.lbl_From);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_To);
            this.Controls.Add(this.txt_From);
            this.Controls.Add(this.radio_FtoC);
            this.Controls.Add(this.radio_CtoF);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TemperatureConvert";
            this.Text = "TemperatureConvert";
            this.Load += new System.EventHandler(this.TemperatureConvert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_CtoF;
        private System.Windows.Forms.RadioButton radio_FtoC;
        private System.Windows.Forms.TextBox txt_From;
        private System.Windows.Forms.TextBox txt_To;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_Message;
        private System.Windows.Forms.Button btn_Read;
    }
}