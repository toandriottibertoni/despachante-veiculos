namespace App.Forms.Forms.Pesquisa
{
    partial class FormPresquisaVeiculo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLACA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROPRIETARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPFCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBusca = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPropNome = new MetroFramework.Controls.MetroTextBox();
            this.chkIncluirInativos = new MetroFramework.Controls.MetroCheckBox();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(773, 151);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(772, 212);
            this.metroButton2.Size = new System.Drawing.Size(53, 43);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(773, 279);
            this.metroButton3.Size = new System.Drawing.Size(50, 42);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(773, 453);
            this.metroButton4.Size = new System.Drawing.Size(52, 43);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(775, 54);
            this.metroButton5.Size = new System.Drawing.Size(50, 38);
            this.metroButton5.Text = "";
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.Location = new System.Drawing.Point(11, 480);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PLACA,
            this.DESCRICAO,
            this.PROPRIETARIO,
            this.CPFCNPJ});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(23, 127);
            this.metroGrid1.MultiSelect = false;
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(730, 335);
            this.metroGrid1.TabIndex = 8;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 55;
            // 
            // PLACA
            // 
            this.PLACA.DataPropertyName = "placa";
            this.PLACA.HeaderText = "PLACA";
            this.PLACA.Name = "PLACA";
            this.PLACA.ReadOnly = true;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.DataPropertyName = "descricao";
            this.DESCRICAO.HeaderText = "DESCRIÇÃO";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.ReadOnly = true;
            this.DESCRICAO.Width = 150;
            // 
            // PROPRIETARIO
            // 
            this.PROPRIETARIO.DataPropertyName = "PropNome";
            this.PROPRIETARIO.HeaderText = "PROPRIETÁRIO";
            this.PROPRIETARIO.Name = "PROPRIETARIO";
            this.PROPRIETARIO.ReadOnly = true;
            this.PROPRIETARIO.Width = 250;
            // 
            // CPFCNPJ
            // 
            this.CPFCNPJ.DataPropertyName = "CpfCnpj";
            this.CPFCNPJ.HeaderText = "CPF/CNPJ";
            this.CPFCNPJ.Name = "CPFCNPJ";
            this.CPFCNPJ.ReadOnly = true;
            this.CPFCNPJ.Width = 130;
            // 
            // txtBusca
            // 
            this.txtBusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtBusca.CustomButton.Image = null;
            this.txtBusca.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtBusca.CustomButton.Name = "";
            this.txtBusca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBusca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBusca.CustomButton.TabIndex = 1;
            this.txtBusca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBusca.CustomButton.UseSelectable = true;
            this.txtBusca.CustomButton.Visible = false;
            this.txtBusca.Lines = new string[0];
            this.txtBusca.Location = new System.Drawing.Point(23, 81);
            this.txtBusca.MaxLength = 32767;
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.PasswordChar = '\0';
            this.txtBusca.PromptText = "DIGITE PARA PESQUISAR";
            this.txtBusca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBusca.SelectedText = "";
            this.txtBusca.SelectionLength = 0;
            this.txtBusca.SelectionStart = 0;
            this.txtBusca.ShortcutsEnabled = true;
            this.txtBusca.Size = new System.Drawing.Size(163, 23);
            this.txtBusca.TabIndex = 9;
            this.txtBusca.UseSelectable = true;
            this.txtBusca.WaterMark = "DIGITE PARA PESQUISAR";
            this.txtBusca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBusca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 59);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "PLACA";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(203, 59);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(98, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "PROPRIETÁRIO";
            // 
            // txtPropNome
            // 
            this.txtPropNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtPropNome.CustomButton.Image = null;
            this.txtPropNome.CustomButton.Location = new System.Drawing.Point(374, 1);
            this.txtPropNome.CustomButton.Name = "";
            this.txtPropNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPropNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPropNome.CustomButton.TabIndex = 1;
            this.txtPropNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPropNome.CustomButton.UseSelectable = true;
            this.txtPropNome.CustomButton.Visible = false;
            this.txtPropNome.Lines = new string[0];
            this.txtPropNome.Location = new System.Drawing.Point(203, 81);
            this.txtPropNome.MaxLength = 32767;
            this.txtPropNome.Name = "txtPropNome";
            this.txtPropNome.PasswordChar = '\0';
            this.txtPropNome.PromptText = "DIGITE PARA PESQUISAR";
            this.txtPropNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPropNome.SelectedText = "";
            this.txtPropNome.SelectionLength = 0;
            this.txtPropNome.SelectionStart = 0;
            this.txtPropNome.ShortcutsEnabled = true;
            this.txtPropNome.Size = new System.Drawing.Size(396, 23);
            this.txtPropNome.TabIndex = 11;
            this.txtPropNome.UseSelectable = true;
            this.txtPropNome.WaterMark = "DIGITE PARA PESQUISAR";
            this.txtPropNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPropNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkIncluirInativos
            // 
            this.chkIncluirInativos.AutoSize = true;
            this.chkIncluirInativos.Location = new System.Drawing.Point(617, 89);
            this.chkIncluirInativos.Name = "chkIncluirInativos";
            this.chkIncluirInativos.Size = new System.Drawing.Size(100, 15);
            this.chkIncluirInativos.TabIndex = 13;
            this.chkIncluirInativos.Text = "Incluir Inativos";
            this.chkIncluirInativos.UseSelectable = true;
            // 
            // metroButton6
            // 
            this.metroButton6.BackgroundImage = global::App.Forms.Properties.Resources.printer;
            this.metroButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton6.Location = new System.Drawing.Point(772, 337);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(51, 48);
            this.metroButton6.TabIndex = 14;
            this.metroButton6.UseSelectable = true;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // FormPresquisaVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(848, 508);
            this.Controls.Add(this.metroButton6);
            this.Controls.Add(this.chkIncluirInativos);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtPropNome);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.metroGrid1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FormPresquisaVeiculo";
            this.Text = "MENU VEICULO";
            this.Load += new System.EventHandler(this.FormPesquisaVeiculo_Load);
            this.Controls.SetChildIndex(this.metroGrid1, 0);
            this.Controls.SetChildIndex(this.txtBusca, 0);
            this.Controls.SetChildIndex(this.metroLabel1, 0);
            this.Controls.SetChildIndex(this.txtPropNome, 0);
            this.Controls.SetChildIndex(this.metroLabel2, 0);
            this.Controls.SetChildIndex(this.metroButton1, 0);
            this.Controls.SetChildIndex(this.metroButton2, 0);
            this.Controls.SetChildIndex(this.metroButton3, 0);
            this.Controls.SetChildIndex(this.metroButton4, 0);
            this.Controls.SetChildIndex(this.metroButton5, 0);
            this.Controls.SetChildIndex(this.LblTotal, 0);
            this.Controls.SetChildIndex(this.chkIncluirInativos, 0);
            this.Controls.SetChildIndex(this.metroButton6, 0);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTextBox txtBusca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLACA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROPRIETARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFCNPJ;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPropNome;
        private MetroFramework.Controls.MetroCheckBox chkIncluirInativos;
        private MetroFramework.Controls.MetroButton metroButton6;
    }
}
