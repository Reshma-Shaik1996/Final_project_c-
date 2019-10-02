namespace semester2_Final_Project
{
    partial class Lotto649
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
            this.btn_Read = new System.Windows.Forms.Button();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(273, 531);
            this.btn_Read.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(159, 55);
            this.btn_Read.TabIndex = 7;
            this.btn_Read.Text = "&Read";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.Btn_Read_Click);
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(74, 531);
            this.btn_Generate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(150, 55);
            this.btn_Generate.TabIndex = 6;
            this.btn_Generate.Text = "&Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.Btn_Generate_Click);
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(74, 120);
            this.txtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbox.Multiline = true;
            this.txtbox.Name = "txtbox";
            this.txtbox.ReadOnly = true;
            this.txtbox.Size = new System.Drawing.Size(556, 359);
            this.txtbox.TabIndex = 5;
            this.txtbox.TextChanged += new System.EventHandler(this.Txtbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "The winning numbers are:";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(480, 531);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(152, 55);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "&Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Lotto649
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Read);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Lotto649";
            this.Text = "Lotto649";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Exit;
    }
}