namespace Sposito
{
    partial class F_LinkedLabel
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ll_canal = new System.Windows.Forms.LinkLabel();
            this.ll_calculadora = new System.Windows.Forms.LinkLabel();
            this.ll_multiplosLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu Nome";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 23);
            this.textBox1.TabIndex = 1;
            // 
            // ll_canal
            // 
            this.ll_canal.AutoSize = true;
            this.ll_canal.Location = new System.Drawing.Point(12, 53);
            this.ll_canal.Name = "ll_canal";
            this.ll_canal.Size = new System.Drawing.Size(37, 15);
            this.ll_canal.TabIndex = 2;
            this.ll_canal.TabStop = true;
            this.ll_canal.Text = "Canal";
            this.ll_canal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_canal_LinkClicked);
            // 
            // ll_calculadora
            // 
            this.ll_calculadora.AutoSize = true;
            this.ll_calculadora.Location = new System.Drawing.Point(12, 93);
            this.ll_calculadora.Name = "ll_calculadora";
            this.ll_calculadora.Size = new System.Drawing.Size(70, 15);
            this.ll_calculadora.TabIndex = 3;
            this.ll_calculadora.TabStop = true;
            this.ll_calculadora.Text = "Calculadora";
            this.ll_calculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_calculadora_LinkClicked);
            // 
            // ll_multiplosLink
            // 
            this.ll_multiplosLink.AutoSize = true;
            this.ll_multiplosLink.Location = new System.Drawing.Point(12, 137);
            this.ll_multiplosLink.Name = "ll_multiplosLink";
            this.ll_multiplosLink.Size = new System.Drawing.Size(141, 15);
            this.ll_multiplosLink.TabIndex = 4;
            this.ll_multiplosLink.TabStop = true;
            this.ll_multiplosLink.Text = "Google - Canal - Youtube";
            this.ll_multiplosLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_multiplosLink_LinkClicked);
            // 
            // F_LinkedLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 265);
            this.Controls.Add(this.ll_multiplosLink);
            this.Controls.Add(this.ll_calculadora);
            this.Controls.Add(this.ll_canal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "F_LinkedLabel";
            this.Text = "F_LinkedLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private LinkLabel ll_canal;
        private LinkLabel ll_calculadora;
        private LinkLabel ll_multiplosLink;
    }
}