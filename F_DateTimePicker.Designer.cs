namespace Sposito
{
    partial class F_DateTimePicker
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
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.btn_obterData = new System.Windows.Forms.Button();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_dia = new System.Windows.Forms.TextBox();
            this.tb_mes = new System.Windows.Forms.TextBox();
            this.tb_ano = new System.Windows.Forms.TextBox();
            this.btn_setarData = new System.Windows.Forms.Button();
            this.btn_hoje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(12, 12);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(280, 23);
            this.dtp_data.TabIndex = 0;
            // 
            // btn_obterData
            // 
            this.btn_obterData.Location = new System.Drawing.Point(298, 12);
            this.btn_obterData.Name = "btn_obterData";
            this.btn_obterData.Size = new System.Drawing.Size(131, 23);
            this.btn_obterData.TabIndex = 1;
            this.btn_obterData.Text = "Obter Data";
            this.btn_obterData.UseVisualStyleBackColor = true;
            this.btn_obterData.Click += new System.EventHandler(this.btn_obterData_Click);
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(12, 41);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(280, 23);
            this.tb_data.TabIndex = 2;
            // 
            // tb_dia
            // 
            this.tb_dia.Location = new System.Drawing.Point(12, 70);
            this.tb_dia.Name = "tb_dia";
            this.tb_dia.Size = new System.Drawing.Size(89, 23);
            this.tb_dia.TabIndex = 3;
            // 
            // tb_mes
            // 
            this.tb_mes.Location = new System.Drawing.Point(108, 70);
            this.tb_mes.Name = "tb_mes";
            this.tb_mes.Size = new System.Drawing.Size(89, 23);
            this.tb_mes.TabIndex = 4;
            // 
            // tb_ano
            // 
            this.tb_ano.Location = new System.Drawing.Point(203, 70);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(89, 23);
            this.tb_ano.TabIndex = 5;
            // 
            // btn_setarData
            // 
            this.btn_setarData.Location = new System.Drawing.Point(298, 70);
            this.btn_setarData.Name = "btn_setarData";
            this.btn_setarData.Size = new System.Drawing.Size(131, 23);
            this.btn_setarData.TabIndex = 9;
            this.btn_setarData.Text = "Setar Data";
            this.btn_setarData.UseVisualStyleBackColor = true;
            this.btn_setarData.Click += new System.EventHandler(this.btn_setarData_Click);
            // 
            // btn_hoje
            // 
            this.btn_hoje.Location = new System.Drawing.Point(298, 99);
            this.btn_hoje.Name = "btn_hoje";
            this.btn_hoje.Size = new System.Drawing.Size(131, 23);
            this.btn_hoje.TabIndex = 10;
            this.btn_hoje.Text = "Hoje";
            this.btn_hoje.UseVisualStyleBackColor = true;
            this.btn_hoje.Click += new System.EventHandler(this.btn_hoje_Click);
            // 
            // F_DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 328);
            this.Controls.Add(this.btn_hoje);
            this.Controls.Add(this.btn_setarData);
            this.Controls.Add(this.tb_ano);
            this.Controls.Add(this.tb_mes);
            this.Controls.Add(this.tb_dia);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.btn_obterData);
            this.Controls.Add(this.dtp_data);
            this.Name = "F_DateTimePicker";
            this.Text = "F_DateTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtp_data;
        private Button btn_obterData;
        private TextBox tb_data;
        private TextBox tb_dia;
        private TextBox tb_mes;
        private TextBox tb_ano;
        private Button btn_setarData;
        private Button btn_hoje;
    }
}