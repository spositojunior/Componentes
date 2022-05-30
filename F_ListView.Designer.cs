namespace Sposito
{
    partial class F_ListView
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Mouse",
            "120",
            "19,99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Teclado",
            "85",
            "39,99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Monitor",
            "38",
            "500,00"}, -1);
            this.lv_produtos = new System.Windows.Forms.ListView();
            this.col_id = new System.Windows.Forms.ColumnHeader();
            this.col_produto = new System.Windows.Forms.ColumnHeader();
            this.col_qtde = new System.Windows.Forms.ColumnHeader();
            this.col_preco = new System.Windows.Forms.ColumnHeader();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_produto = new System.Windows.Forms.TextBox();
            this.tb_qtde = new System.Windows.Forms.TextBox();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_obter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_produtos
            // 
            this.lv_produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_produto,
            this.col_qtde,
            this.col_preco});
            this.lv_produtos.FullRowSelect = true;
            listViewItem2.Tag = "";
            this.lv_produtos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lv_produtos.Location = new System.Drawing.Point(12, 12);
            this.lv_produtos.MultiSelect = false;
            this.lv_produtos.Name = "lv_produtos";
            this.lv_produtos.Size = new System.Drawing.Size(414, 147);
            this.lv_produtos.TabIndex = 0;
            this.lv_produtos.UseCompatibleStateImageBehavior = false;
            this.lv_produtos.View = System.Windows.Forms.View.Details;
            this.lv_produtos.SelectedIndexChanged += new System.EventHandler(this.lv_produtos_SelectedIndexChanged);
            // 
            // col_id
            // 
            this.col_id.Text = "ID";
            this.col_id.Width = 35;
            // 
            // col_produto
            // 
            this.col_produto.Text = "Produto";
            this.col_produto.Width = 125;
            // 
            // col_qtde
            // 
            this.col_qtde.Text = "Quantidade";
            this.col_qtde.Width = 125;
            // 
            // col_preco
            // 
            this.col_preco.Text = "Preço";
            this.col_preco.Width = 125;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(12, 191);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(52, 23);
            this.tb_id.TabIndex = 1;
            // 
            // tb_produto
            // 
            this.tb_produto.Location = new System.Drawing.Point(70, 191);
            this.tb_produto.Name = "tb_produto";
            this.tb_produto.Size = new System.Drawing.Size(109, 23);
            this.tb_produto.TabIndex = 2;
            // 
            // tb_qtde
            // 
            this.tb_qtde.Location = new System.Drawing.Point(185, 191);
            this.tb_qtde.Name = "tb_qtde";
            this.tb_qtde.Size = new System.Drawing.Size(106, 23);
            this.tb_qtde.TabIndex = 3;
            this.tb_qtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_qtde_KeyPress);
            // 
            // tb_preco
            // 
            this.tb_preco.Location = new System.Drawing.Point(297, 191);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(125, 23);
            this.tb_preco.TabIndex = 4;
            this.tb_preco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_preco_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Preço";
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(12, 220);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(115, 23);
            this.btn_adicionar.TabIndex = 9;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(12, 249);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(115, 23);
            this.btn_remover.TabIndex = 10;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_obter
            // 
            this.btn_obter.Location = new System.Drawing.Point(12, 278);
            this.btn_obter.Name = "btn_obter";
            this.btn_obter.Size = new System.Drawing.Size(115, 23);
            this.btn_obter.TabIndex = 11;
            this.btn_obter.Text = "Obter";
            this.btn_obter.UseVisualStyleBackColor = true;
            this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
            // 
            // F_ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 369);
            this.Controls.Add(this.btn_obter);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_preco);
            this.Controls.Add(this.tb_qtde);
            this.Controls.Add(this.tb_produto);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lv_produtos);
            this.Name = "F_ListView";
            this.Text = "F_ListView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lv_produtos;
        private ColumnHeader col_id;
        private ColumnHeader col_produto;
        private ColumnHeader col_qtde;
        private ColumnHeader col_preco;
        private TextBox tb_id;
        private TextBox tb_produto;
        private TextBox tb_qtde;
        private TextBox tb_preco;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_adicionar;
        private Button btn_remover;
        private Button btn_obter;
    }
}