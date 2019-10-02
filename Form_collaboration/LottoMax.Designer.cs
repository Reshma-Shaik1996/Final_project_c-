namespace semester2_Final_Project
{
    partial class LottoMax
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.btn_Read = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "The winning numbers are:";
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(53, 88);
            this.txtbox.Multiline = true;
            this.txtbox.Name = "txtbox";
            this.txtbox.ReadOnly = true;
            this.txtbox.Size = new System.Drawing.Size(372, 231);
            this.txtbox.TabIndex = 1;
            this.txtbox.TextChanged += new System.EventHandler(this.Txtbox_TextChanged);
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(53, 351);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(100, 35);
            this.btn_Generate.TabIndex = 2;
            this.btn_Generate.Text = "&Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.Btn_Generate_Click);
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(186, 351);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(106, 35);
            this.btn_Read.TabIndex = 3;
            this.btn_Read.Text = "&Read";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.Btn_Read_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(319, 351);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(111, 35);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "&Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // LottoMax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Read);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.label1);
            this.Name = "LottoMax";
            this.Text = "LottoMax";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.Button btn_Exit;
    }
}