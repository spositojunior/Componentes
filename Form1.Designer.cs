namespace Sposito
{
    partial class F_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Principal));
            this.tb_veiculo = new System.Windows.Forms.TextBox();
            this.lb_texto = new System.Windows.Forms.Label();
            this.tb_listaVeiculos = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btn_valNum = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskedTextBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuNotificacoes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_Restaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Mensagem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Fechar = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.MenuNotificacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_veiculo
            // 
            this.tb_veiculo.Location = new System.Drawing.Point(9, 57);
            this.tb_veiculo.Name = "tb_veiculo";
            this.tb_veiculo.Size = new System.Drawing.Size(165, 23);
            this.tb_veiculo.TabIndex = 2;
            // 
            // lb_texto
            // 
            this.lb_texto.AutoSize = true;
            this.lb_texto.Location = new System.Drawing.Point(12, 34);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(100, 15);
            this.lb_texto.TabIndex = 1;
            this.lb_texto.Text = "Digite um Veiculo";
            // 
            // tb_listaVeiculos
            // 
            this.tb_listaVeiculos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_listaVeiculos.Location = new System.Drawing.Point(9, 86);
            this.tb_listaVeiculos.Multiline = true;
            this.tb_listaVeiculos.Name = "tb_listaVeiculos";
            this.tb_listaVeiculos.ReadOnly = true;
            this.tb_listaVeiculos.Size = new System.Drawing.Size(275, 231);
            this.tb_listaVeiculos.TabIndex = 4;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(9, 323);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(275, 25);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(180, 57);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(104, 23);
            this.btn_adicionar.TabIndex = 3;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(9, 354);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(275, 25);
            this.btn_mostrar.TabIndex = 6;
            this.btn_mostrar.Text = "Mostrar Veiculos";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btn_valNum
            // 
            this.btn_valNum.Location = new System.Drawing.Point(9, 385);
            this.btn_valNum.Name = "btn_valNum";
            this.btn_valNum.Size = new System.Drawing.Size(275, 25);
            this.btn_valNum.TabIndex = 7;
            this.btn_valNum.Text = "Valor na variavel Num";
            this.btn_valNum.UseVisualStyleBackColor = true;
            this.btn_valNum.Click += new System.EventHandler(this.btn_valNum_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(296, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkboxToolStripMenuItem,
            this.checkedListBoxToolStripMenuItem,
            this.comboBoxToolStripMenuItem,
            this.dateTimePickerToolStripMenuItem,
            this.labelToolStripMenuItem,
            this.listBoxToolStripMenuItem,
            this.listViewToolStripMenuItem,
            this.maskedTextBoxToolStripMenuItem,
            this.monthCalendarToolStripMenuItem,
            this.progressBarToolStripMenuItem,
            this.numericUpDownToolStripMenuItem,
            this.radioButtonToolStripMenuItem});
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.componentesToolStripMenuItem.Text = "Componentes";
            // 
            // checkboxToolStripMenuItem
            // 
            this.checkboxToolStripMenuItem.Name = "checkboxToolStripMenuItem";
            this.checkboxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkboxToolStripMenuItem.Text = "Checkbox";
            this.checkboxToolStripMenuItem.Click += new System.EventHandler(this.checkboxToolStripMenuItem_Click);
            // 
            // checkedListBoxToolStripMenuItem
            // 
            this.checkedListBoxToolStripMenuItem.Name = "checkedListBoxToolStripMenuItem";
            this.checkedListBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkedListBoxToolStripMenuItem.Text = "CheckedListBox";
            this.checkedListBoxToolStripMenuItem.Click += new System.EventHandler(this.checkedListBoxToolStripMenuItem_Click);
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comboBoxToolStripMenuItem.Text = "ComboBox";
            this.comboBoxToolStripMenuItem.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click);
            // 
            // dateTimePickerToolStripMenuItem
            // 
            this.dateTimePickerToolStripMenuItem.Name = "dateTimePickerToolStripMenuItem";
            this.dateTimePickerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dateTimePickerToolStripMenuItem.Text = "DateTimePicker";
            this.dateTimePickerToolStripMenuItem.Click += new System.EventHandler(this.dateTimePickerToolStripMenuItem_Click);
            // 
            // labelToolStripMenuItem
            // 
            this.labelToolStripMenuItem.Name = "labelToolStripMenuItem";
            this.labelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.labelToolStripMenuItem.Text = "Label / LinkLabel";
            this.labelToolStripMenuItem.Click += new System.EventHandler(this.labelToolStripMenuItem_Click);
            // 
            // listBoxToolStripMenuItem
            // 
            this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listBoxToolStripMenuItem.Text = "ListBox";
            this.listBoxToolStripMenuItem.Click += new System.EventHandler(this.listBoxToolStripMenuItem_Click);
            // 
            // listViewToolStripMenuItem
            // 
            this.listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            this.listViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listViewToolStripMenuItem.Text = "ListView";
            this.listViewToolStripMenuItem.Click += new System.EventHandler(this.listViewToolStripMenuItem_Click);
            // 
            // maskedTextBoxToolStripMenuItem
            // 
            this.maskedTextBoxToolStripMenuItem.Name = "maskedTextBoxToolStripMenuItem";
            this.maskedTextBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maskedTextBoxToolStripMenuItem.Text = "MaskedTextBox";
            this.maskedTextBoxToolStripMenuItem.Click += new System.EventHandler(this.maskedTextBoxToolStripMenuItem_Click);
            // 
            // monthCalendarToolStripMenuItem
            // 
            this.monthCalendarToolStripMenuItem.Name = "monthCalendarToolStripMenuItem";
            this.monthCalendarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.monthCalendarToolStripMenuItem.Text = "MonthCalendar";
            this.monthCalendarToolStripMenuItem.Click += new System.EventHandler(this.monthCalendarToolStripMenuItem_Click);
            // 
            // numericUpDownToolStripMenuItem
            // 
            this.numericUpDownToolStripMenuItem.Name = "numericUpDownToolStripMenuItem";
            this.numericUpDownToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.numericUpDownToolStripMenuItem.Text = "NumericUpDown";
            this.numericUpDownToolStripMenuItem.Click += new System.EventHandler(this.numericUpDownToolStripMenuItem_Click);
            // 
            // radioButtonToolStripMenuItem
            // 
            this.radioButtonToolStripMenuItem.Name = "radioButtonToolStripMenuItem";
            this.radioButtonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.radioButtonToolStripMenuItem.Text = "RadioButton";
            this.radioButtonToolStripMenuItem.Click += new System.EventHandler(this.radioButtonToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.MenuNotificacoes;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Sposito";
            this.notifyIcon1.Visible = true;
            // 
            // MenuNotificacoes
            // 
            this.MenuNotificacoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Restaurar,
            this.tsmi_Mensagem,
            this.tsmi_Fechar});
            this.MenuNotificacoes.Name = "contextMenuStrip1";
            this.MenuNotificacoes.Size = new System.Drawing.Size(134, 70);
            this.MenuNotificacoes.Text = "Restaurar";
            this.MenuNotificacoes.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuNotificacoes_ItemClicked);
            // 
            // tsmi_Restaurar
            // 
            this.tsmi_Restaurar.Name = "tsmi_Restaurar";
            this.tsmi_Restaurar.Size = new System.Drawing.Size(133, 22);
            this.tsmi_Restaurar.Text = "Restaurar";
            // 
            // tsmi_Mensagem
            // 
            this.tsmi_Mensagem.Name = "tsmi_Mensagem";
            this.tsmi_Mensagem.Size = new System.Drawing.Size(133, 22);
            this.tsmi_Mensagem.Text = "Mensagem";
            // 
            // tsmi_Fechar
            // 
            this.tsmi_Fechar.Name = "tsmi_Fechar";
            this.tsmi_Fechar.Size = new System.Drawing.Size(133, 22);
            this.tsmi_Fechar.Text = "Fechar";
            // 
            // progressBarToolStripMenuItem
            // 
            this.progressBarToolStripMenuItem.Name = "progressBarToolStripMenuItem";
            this.progressBarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.progressBarToolStripMenuItem.Text = "ProgressBar";
            this.progressBarToolStripMenuItem.Click += new System.EventHandler(this.progressBarToolStripMenuItem_Click);
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 422);
            this.Controls.Add(this.btn_valNum);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.tb_listaVeiculos);
            this.Controls.Add(this.lb_texto);
            this.Controls.Add(this.tb_veiculo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "F_Principal";
            this.Text = "Formulario Sposito";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MenuNotificacoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tb_veiculo;
        private Label lb_texto;
        private Button btn_clear;
        private Button btn_adicionar;
        private Button btn_mostrar;
        private Button btn_valNum;
        public TextBox tb_listaVeiculos;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem componentesToolStripMenuItem;
        private ToolStripMenuItem checkboxToolStripMenuItem;
        private ToolStripMenuItem checkedListBoxToolStripMenuItem;
        private ToolStripMenuItem comboBoxToolStripMenuItem;
        private ToolStripMenuItem dateTimePickerToolStripMenuItem;
        private ToolStripMenuItem labelToolStripMenuItem;
        private ToolStripMenuItem listBoxToolStripMenuItem;
        private ToolStripMenuItem listViewToolStripMenuItem;
        private ToolStripMenuItem maskedTextBoxToolStripMenuItem;
        private ToolStripMenuItem monthCalendarToolStripMenuItem;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip MenuNotificacoes;
        private ToolStripMenuItem tsmi_Mensagem;
        private ToolStripMenuItem tsmi_Restaurar;
        private ToolStripMenuItem tsmi_Fechar;
        private ToolStripMenuItem numericUpDownToolStripMenuItem;
        private ToolStripMenuItem radioButtonToolStripMenuItem;
        private ToolStripMenuItem progressBarToolStripMenuItem;
    }
}