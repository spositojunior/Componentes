namespace Sposito
{
    partial class F_ListBox
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
            this.lb_carros = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_carro = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_oter = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_carros
            // 
            this.lb_carros.FormattingEnabled = true;
            this.lb_carros.ItemHeight = 15;
            this.lb_carros.Location = new System.Drawing.Point(12, 12);
            this.lb_carros.Name = "lb_carros";
            this.lb_carros.Size = new System.Drawing.Size(190, 229);
            this.lb_carros.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carro";
            // 
            // tb_carro
            // 
            this.tb_carro.Location = new System.Drawing.Point(208, 30);
            this.tb_carro.Name = "tb_carro";
            this.tb_carro.Size = new System.Drawing.Size(100, 23);
            this.tb_carro.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(208, 59);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(208, 88);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(100, 23);
            this.btn_remove.TabIndex = 4;
            this.btn_remove.Text = "Remover";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_oter
            // 
            this.btn_oter.Location = new System.Drawing.Point(208, 117);
            this.btn_oter.Name = "btn_oter";
            this.btn_oter.Size = new System.Drawing.Size(100, 23);
            this.btn_oter.TabIndex = 5;
            this.btn_oter.Text = "Obter";
            this.btn_oter.UseVisualStyleBackColor = true;
            this.btn_oter.Click += new System.EventHandler(this.btn_oter_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(208, 146);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(100, 23);
            this.btn_limpar.TabIndex = 6;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // F_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 307);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_oter);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_carro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_carros);
            this.Name = "F_ListBox";
            this.Text = "F_ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lb_carros;
        private Label label1;
        private TextBox tb_carro;
        private Button btn_add;
        private Button btn_remove;
        private Button btn_oter;
        private Button btn_limpar;
    }
}