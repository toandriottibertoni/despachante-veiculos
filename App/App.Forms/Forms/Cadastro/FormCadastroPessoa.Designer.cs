namespace App.Forms.Forms.Cadastro
{
    partial class FormCadastroPessoa
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
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.txtCpfCnpj = new MetroFramework.Controls.MetroTextBox();
            this.lblCpfCnpj = new MetroFramework.Controls.MetroLabel();
            this.txtRgIe = new MetroFramework.Controls.MetroTextBox();
            this.lblRgIE = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btSelecionarCidade = new MetroFramework.Controls.MetroButton();
            this.txtEnderecoCidade = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtEnderecoCaixaPostal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtEnderecoCEP = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtEnderecoComplemento = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtEnderecoBairro = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtEnderecoNumero = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtEnderecoLogradouro = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.rdPj = new MetroFramework.Controls.MetroRadioButton();
            this.rdPf = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtCnhRegistro = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtCnhLetra = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtCnhValidade = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtNomePai = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.txtNomeMae = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.txtTelefone2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(530, 606);
            this.btSalvar.TabIndex = 12;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(36, 85);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(52, 19);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "NOME:";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(575, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(36, 107);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(597, 23);
            this.txtNome.TabIndex = 0;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtCpfCnpj.CustomButton.Image = null;
            this.txtCpfCnpj.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.txtCpfCnpj.CustomButton.Name = "";
            this.txtCpfCnpj.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCpfCnpj.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCpfCnpj.CustomButton.TabIndex = 1;
            this.txtCpfCnpj.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCpfCnpj.CustomButton.UseSelectable = true;
            this.txtCpfCnpj.CustomButton.Visible = false;
            this.txtCpfCnpj.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCpfCnpj.Lines = new string[0];
            this.txtCpfCnpj.Location = new System.Drawing.Point(36, 160);
            this.txtCpfCnpj.MaxLength = 32767;
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.PasswordChar = '\0';
            this.txtCpfCnpj.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCpfCnpj.SelectedText = "";
            this.txtCpfCnpj.SelectionLength = 0;
            this.txtCpfCnpj.SelectionStart = 0;
            this.txtCpfCnpj.ShortcutsEnabled = true;
            this.txtCpfCnpj.Size = new System.Drawing.Size(178, 23);
            this.txtCpfCnpj.TabIndex = 1;
            this.txtCpfCnpj.UseSelectable = true;
            this.txtCpfCnpj.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCpfCnpj.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCpfCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpfCnpj_KeyPress);
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Location = new System.Drawing.Point(36, 138);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(72, 19);
            this.lblCpfCnpj.TabIndex = 3;
            this.lblCpfCnpj.Text = "CPF/CNPJ:";
            // 
            // txtRgIe
            // 
            this.txtRgIe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtRgIe.CustomButton.Image = null;
            this.txtRgIe.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.txtRgIe.CustomButton.Name = "";
            this.txtRgIe.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRgIe.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRgIe.CustomButton.TabIndex = 1;
            this.txtRgIe.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRgIe.CustomButton.UseSelectable = true;
            this.txtRgIe.CustomButton.Visible = false;
            this.txtRgIe.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRgIe.Lines = new string[0];
            this.txtRgIe.Location = new System.Drawing.Point(419, 160);
            this.txtRgIe.MaxLength = 32767;
            this.txtRgIe.Name = "txtRgIe";
            this.txtRgIe.PasswordChar = '\0';
            this.txtRgIe.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRgIe.SelectedText = "";
            this.txtRgIe.SelectionLength = 0;
            this.txtRgIe.SelectionStart = 0;
            this.txtRgIe.ShortcutsEnabled = true;
            this.txtRgIe.Size = new System.Drawing.Size(214, 23);
            this.txtRgIe.TabIndex = 3;
            this.txtRgIe.UseSelectable = true;
            this.txtRgIe.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRgIe.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRgIe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRgIe_KeyPress);
            // 
            // lblRgIE
            // 
            this.lblRgIE.AutoSize = true;
            this.lblRgIE.Location = new System.Drawing.Point(419, 138);
            this.lblRgIE.Name = "lblRgIE";
            this.lblRgIE.Size = new System.Drawing.Size(44, 19);
            this.lblRgIE.TabIndex = 5;
            this.lblRgIE.Text = "RG/IE:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.btSelecionarCidade);
            this.metroPanel1.Controls.Add(this.txtEnderecoCidade);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.txtEnderecoCaixaPostal);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.txtEnderecoCEP);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.txtEnderecoComplemento);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.txtEnderecoBairro);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.txtEnderecoNumero);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.txtEnderecoLogradouro);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(36, 405);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(597, 184);
            this.metroPanel1.TabIndex = 11;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btSelecionarCidade
            // 
            this.btSelecionarCidade.BackColor = System.Drawing.Color.White;
            this.btSelecionarCidade.BackgroundImage = global::App.Forms.Properties.Resources.search16;
            this.btSelecionarCidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSelecionarCidade.Location = new System.Drawing.Point(531, 141);
            this.btSelecionarCidade.Name = "btSelecionarCidade";
            this.btSelecionarCidade.Size = new System.Drawing.Size(52, 23);
            this.btSelecionarCidade.TabIndex = 7;
            this.btSelecionarCidade.UseSelectable = true;
            this.btSelecionarCidade.Click += new System.EventHandler(this.btSelecionarCidade_Click);
            // 
            // txtEnderecoCidade
            // 
            this.txtEnderecoCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtEnderecoCidade.CustomButton.Image = null;
            this.txtEnderecoCidade.CustomButton.Location = new System.Drawing.Point(244, 1);
            this.txtEnderecoCidade.CustomButton.Name = "";
            this.txtEnderecoCidade.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEnderecoCidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEnderecoCidade.CustomButton.TabIndex = 1;
            this.txtEnderecoCidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEnderecoCidade.CustomButton.UseSelectable = true;
            this.txtEnderecoCidade.CustomButton.Visible = false;
            this.txtEnderecoCidade.Enabled = false;
            this.txtEnderecoCidade.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEnderecoCidade.Lines = new string[0];
            this.txtEnderecoCidade.Location = new System.Drawing.Point(259, 141);
            this.txtEnderecoCidade.MaxLength = 32767;
            this.txtEnderecoCidade.Name = "txtEnderecoCidade";
            this.txtEnderecoCidade.PasswordChar = '\0';
            this.txtEnderecoCidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEnderecoCidade.SelectedText = "";
            this.txtEnderecoCidade.SelectionLength = 0;
            this.txtEnderecoCidade.SelectionStart = 0;
            this.txtEnderecoCidade.ShortcutsEnabled = true;
            this.txtEnderecoCidade.Size = new System.Drawing.Size(266, 23);
            this.txtEnderecoCidade.TabIndex = 6;
            this.txtEnderecoCidade.UseSelectable = true;
            this.txtEnderecoCidade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEnderecoCidade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(259, 119);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(55, 19);
            this.metroLabel8.TabIndex = 19;
            this.metroLabel8.Text = "CIDADE";
            // 
            // txtEnderecoCaixaPostal
            // 
            this.txtEnderecoCaixaPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtEnderecoCaixaPostal.CustomButton.Image = null;
            this.txtEnderecoCaixaPostal.CustomButton.Location = new System.Drawing.Point(60, 1);
            this.txtEnderecoCaixaPostal.CustomButton.Name = "";
            this.txtEnderecoCaixaPostal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEnderecoCaixaPostal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEnderecoCaixaPostal.CustomButton.TabIndex = 1;
            this.txtEnderecoCaixaPostal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEnderecoCaixaPostal.CustomButton.UseSelectable = true;
            this.txtEnderecoCaixaPostal.CustomButton.Visible = false;
            this.txtEnderecoCaixaPostal.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEnderecoCaixaPostal.Lines = new string[0];
            this.txtEnderecoCaixaPostal.Location = new System.Drawing.Point(156, 141);
            this.txtEnderecoCaixaPostal.MaxLength = 32767;
            this.txtEnderecoCaixaPostal.Name = "txtEnderecoCaixaPostal";
            this.txtEnderecoCaixaPostal.PasswordChar = '\0';
            this.txtEnderecoCaixaPostal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEnderecoCaixaPostal.SelectedText = "";
            this.txtEnderecoCaixaPostal.SelectionLength = 0;
            this.txtEnderecoCaixaPostal.SelectionStart = 0;
            this.txtEnderecoCaixaPostal.ShortcutsEnabled = true;
            this.txtEnderecoCaixaPostal.Size = new System.Drawing.Size(82, 23);
            this.txtEnderecoCaixaPostal.TabIndex = 5;
            this.txtEnderecoCaixaPostal.UseSelectable = true;
            this.txtEnderecoCaixaPostal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEnderecoCaixaPostal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(156, 119);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(34, 19);
            this.metroLabel7.TabIndex = 17;
            this.metroLabel7.Text = "CXP";
            // 
            // txtEnderecoCEP
            // 
            this.txtEnderecoCEP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtEnderecoCEP.CustomButton.Image = null;
            this.txtEnderecoCEP.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtEnderecoCEP.CustomButton.Name = "";
            this.txtEnderecoCEP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEnderecoCEP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEnderecoCEP.CustomButton.TabIndex = 1;
            this.txtEnderecoCEP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEnderecoCEP.CustomButton.UseSelectable = true;
            this.txtEnderecoCEP.CustomButton.Visible = false;
            this.txtEnderecoCEP.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEnderecoCEP.Lines = new string[0];
            this.txtEnderecoCEP.Location = new System.Drawing.Point(12, 141);
            this.txtEnderecoCEP.MaxLength = 32767;
            this.txtEnderecoCEP.Name = "txtEnderecoCEP";
            this.txtEnderecoCEP.PasswordChar = '\0';
            this.txtEnderecoCEP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEnderecoCEP.SelectedText = "";
            this.txtEnderecoCEP.SelectionLength = 0;
            this.txtEnderecoCEP.SelectionStart = 0;
            this.txtEnderecoCEP.ShortcutsEnabled = true;
            this.txtEnderecoCEP.Size = new System.Drawing.Size(127, 23);
            this.txtEnderecoCEP.TabIndex = 4;
            this.txtEnderecoCEP.UseSelectable = true;
            this.txtEnderecoCEP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEnderecoCEP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEnderecoCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnderecoCEP_KeyPress);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(12, 119);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(36, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "CEP:";
            // 
            // txtEnderecoComplemento
            // 
            this.txtEnderecoComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtEnderecoComplemento.CustomButton.Image = null;
            this.txtEnderecoComplemento.CustomButton.Location = new System.Drawing.Point(302, 1);
            this.txtEnderecoComplemento.CustomButton.Name = "";
            this.txtEnderecoComplemento.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEnderecoComplemento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEnderecoComplemento.CustomButton.TabIndex = 1;
            this.txtEnderecoComplemento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEnderecoComplemento.CustomButton.UseSelectable = true;
            this.txtEnderecoComplemento.CustomButton.Visible = false;
            this.txtEnderecoComplemento.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEnderecoComplemento.Lines = new string[0];
            this.txtEnderecoComplemento.Location = new System.Drawing.Point(259, 82);
            this.txtEnderecoComplemento.MaxLength = 32767;
            this.txtEnderecoComplemento.Name = "txtEnderecoComplemento";
            this.txtEnderecoComplemento.PasswordChar = '\0';
            this.txtEnderecoComplemento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEnderecoComplemento.SelectedText = "";
            this.txtEnderecoComplemento.SelectionLength = 0;
            this.txtEnderecoComplemento.SelectionStart = 0;
            this.txtEnderecoComplemento.ShortcutsEnabled = true;
            this.txtEnderecoComplemento.Size = new System.Drawing.Size(324, 23);
            this.txtEnderecoComplemento.TabIndex = 3;
            this.txtEnderecoComplemento.UseSelectable = true;
            this.txtEnderecoComplemento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEnderecoComplemento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(259, 60);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(111, 19);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "COMPLEMENTO:";
            // 
            // txtEnderecoBairro
            // 
            this.txtEnderecoBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtEnderecoBairro.CustomButton.Image = null;
            this.txtEnderecoBairro.CustomButton.Location = new System.Drawing.Point(204, 1);
            this.txtEnderecoBairro.CustomButton.Name = "";
            this.txtEnderecoBairro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEnderecoBairro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEnderecoBairro.CustomButton.TabIndex = 1;
            this.txtEnderecoBairro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEnderecoBairro.CustomButton.UseSelectable = true;
            this.txtEnderecoBairro.CustomButton.Visible = false;
            this.txtEnderecoBairro.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEnderecoBairro.Lines = new string[0];
            this.txtEnderecoBairro.Location = new System.Drawing.Point(12, 82);
            this.txtEnderecoBairro.MaxLength = 32767;
            this.txtEnderecoBairro.Name = "txtEnderecoBairro";
            this.txtEnderecoBairro.PasswordChar = '\0';
            this.txtEnderecoBairro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEnderecoBairro.SelectedText = "";
            this.txtEnderecoBairro.SelectionLength = 0;
            this.txtEnderecoBairro.SelectionStart = 0;
            this.txtEnderecoBairro.ShortcutsEnabled = true;
            this.txtEnderecoBairro.Size = new System.Drawing.Size(226, 23);
            this.txtEnderecoBairro.TabIndex = 2;
            this.txtEnderecoBairro.UseSelectable = true;
            this.txtEnderecoBairro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEnderecoBairro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(12, 60);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "BAIRRO:";
            // 
            // txtEnderecoNumero
            // 
            this.txtEnderecoNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtEnderecoNumero.CustomButton.Image = null;
            this.txtEnderecoNumero.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtEnderecoNumero.CustomButton.Name = "";
            this.txtEnderecoNumero.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEnderecoNumero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEnderecoNumero.CustomButton.TabIndex = 1;
            this.txtEnderecoNumero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEnderecoNumero.CustomButton.UseSelectable = true;
            this.txtEnderecoNumero.CustomButton.Visible = false;
            this.txtEnderecoNumero.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEnderecoNumero.Lines = new string[0];
            this.txtEnderecoNumero.Location = new System.Drawing.Point(456, 32);
            this.txtEnderecoNumero.MaxLength = 32767;
            this.txtEnderecoNumero.Name = "txtEnderecoNumero";
            this.txtEnderecoNumero.PasswordChar = '\0';
            this.txtEnderecoNumero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEnderecoNumero.SelectedText = "";
            this.txtEnderecoNumero.SelectionLength = 0;
            this.txtEnderecoNumero.SelectionStart = 0;
            this.txtEnderecoNumero.ShortcutsEnabled = true;
            this.txtEnderecoNumero.Size = new System.Drawing.Size(127, 23);
            this.txtEnderecoNumero.TabIndex = 1;
            this.txtEnderecoNumero.UseSelectable = true;
            this.txtEnderecoNumero.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEnderecoNumero.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(456, 10);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "NUMERO:";
            // 
            // txtEnderecoLogradouro
            // 
            this.txtEnderecoLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtEnderecoLogradouro.CustomButton.Image = null;
            this.txtEnderecoLogradouro.CustomButton.Location = new System.Drawing.Point(404, 1);
            this.txtEnderecoLogradouro.CustomButton.Name = "";
            this.txtEnderecoLogradouro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEnderecoLogradouro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEnderecoLogradouro.CustomButton.TabIndex = 1;
            this.txtEnderecoLogradouro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEnderecoLogradouro.CustomButton.UseSelectable = true;
            this.txtEnderecoLogradouro.CustomButton.Visible = false;
            this.txtEnderecoLogradouro.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEnderecoLogradouro.Lines = new string[0];
            this.txtEnderecoLogradouro.Location = new System.Drawing.Point(12, 32);
            this.txtEnderecoLogradouro.MaxLength = 32767;
            this.txtEnderecoLogradouro.Name = "txtEnderecoLogradouro";
            this.txtEnderecoLogradouro.PasswordChar = '\0';
            this.txtEnderecoLogradouro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEnderecoLogradouro.SelectedText = "";
            this.txtEnderecoLogradouro.SelectionLength = 0;
            this.txtEnderecoLogradouro.SelectionStart = 0;
            this.txtEnderecoLogradouro.ShortcutsEnabled = true;
            this.txtEnderecoLogradouro.Size = new System.Drawing.Size(426, 23);
            this.txtEnderecoLogradouro.TabIndex = 0;
            this.txtEnderecoLogradouro.UseSelectable = true;
            this.txtEnderecoLogradouro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEnderecoLogradouro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 10);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(216, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "LOGRADOURO (RUA, AVENIDA ... )";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(36, 383);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "ENDEREÇO:";
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.rdPj);
            this.metroPanel2.Controls.Add(this.rdPf);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(433, 61);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(200, 40);
            this.metroPanel2.TabIndex = 13;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // rdPj
            // 
            this.rdPj.AutoSize = true;
            this.rdPj.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdPj.Location = new System.Drawing.Point(97, 13);
            this.rdPj.Name = "rdPj";
            this.rdPj.Size = new System.Drawing.Size(84, 19);
            this.rdPj.TabIndex = 1;
            this.rdPj.Text = "JURIDÍCA";
            this.rdPj.UseSelectable = true;
            // 
            // rdPf
            // 
            this.rdPf.AutoSize = true;
            this.rdPf.Checked = true;
            this.rdPf.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdPf.Location = new System.Drawing.Point(26, 13);
            this.rdPf.Name = "rdPf";
            this.rdPf.Size = new System.Drawing.Size(65, 19);
            this.rdPf.TabIndex = 0;
            this.rdPf.TabStop = true;
            this.rdPf.Text = "FISÍCA";
            this.rdPf.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(433, 39);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(91, 19);
            this.metroLabel9.TabIndex = 9;
            this.metroLabel9.Text = "TIPO PESSOA";
            // 
            // txtCnhRegistro
            // 
            this.txtCnhRegistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtCnhRegistro.CustomButton.Image = null;
            this.txtCnhRegistro.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.txtCnhRegistro.CustomButton.Name = "";
            this.txtCnhRegistro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCnhRegistro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCnhRegistro.CustomButton.TabIndex = 1;
            this.txtCnhRegistro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCnhRegistro.CustomButton.UseSelectable = true;
            this.txtCnhRegistro.CustomButton.Visible = false;
            this.txtCnhRegistro.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCnhRegistro.Lines = new string[0];
            this.txtCnhRegistro.Location = new System.Drawing.Point(36, 278);
            this.txtCnhRegistro.MaxLength = 32767;
            this.txtCnhRegistro.Name = "txtCnhRegistro";
            this.txtCnhRegistro.PasswordChar = '\0';
            this.txtCnhRegistro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCnhRegistro.SelectedText = "";
            this.txtCnhRegistro.SelectionLength = 0;
            this.txtCnhRegistro.SelectionStart = 0;
            this.txtCnhRegistro.ShortcutsEnabled = true;
            this.txtCnhRegistro.Size = new System.Drawing.Size(128, 23);
            this.txtCnhRegistro.TabIndex = 6;
            this.txtCnhRegistro.UseSelectable = true;
            this.txtCnhRegistro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCnhRegistro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(36, 256);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(104, 19);
            this.metroLabel10.TabIndex = 11;
            this.metroLabel10.Text = "CNH REGISTRO:";
            // 
            // txtCnhLetra
            // 
            this.txtCnhLetra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtCnhLetra.CustomButton.Image = null;
            this.txtCnhLetra.CustomButton.Location = new System.Drawing.Point(59, 1);
            this.txtCnhLetra.CustomButton.Name = "";
            this.txtCnhLetra.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCnhLetra.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCnhLetra.CustomButton.TabIndex = 1;
            this.txtCnhLetra.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCnhLetra.CustomButton.UseSelectable = true;
            this.txtCnhLetra.CustomButton.Visible = false;
            this.txtCnhLetra.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCnhLetra.Lines = new string[0];
            this.txtCnhLetra.Location = new System.Drawing.Point(179, 278);
            this.txtCnhLetra.MaxLength = 32767;
            this.txtCnhLetra.Name = "txtCnhLetra";
            this.txtCnhLetra.PasswordChar = '\0';
            this.txtCnhLetra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCnhLetra.SelectedText = "";
            this.txtCnhLetra.SelectionLength = 0;
            this.txtCnhLetra.SelectionStart = 0;
            this.txtCnhLetra.ShortcutsEnabled = true;
            this.txtCnhLetra.Size = new System.Drawing.Size(81, 23);
            this.txtCnhLetra.TabIndex = 7;
            this.txtCnhLetra.UseSelectable = true;
            this.txtCnhLetra.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCnhLetra.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(179, 256);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(81, 19);
            this.metroLabel11.TabIndex = 13;
            this.metroLabel11.Text = "CNH LETRA:";
            // 
            // txtCnhValidade
            // 
            this.txtCnhValidade.Location = new System.Drawing.Point(280, 281);
            this.txtCnhValidade.Mask = "99/99/9999";
            this.txtCnhValidade.Name = "txtCnhValidade";
            this.txtCnhValidade.Size = new System.Drawing.Size(94, 20);
            this.txtCnhValidade.TabIndex = 8;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(280, 256);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(103, 19);
            this.metroLabel12.TabIndex = 15;
            this.metroLabel12.Text = "CNH VALIDADE:";
            // 
            // txtNomePai
            // 
            this.txtNomePai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtNomePai.CustomButton.Image = null;
            this.txtNomePai.CustomButton.Location = new System.Drawing.Point(283, 1);
            this.txtNomePai.CustomButton.Name = "";
            this.txtNomePai.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomePai.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomePai.CustomButton.TabIndex = 1;
            this.txtNomePai.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomePai.CustomButton.UseSelectable = true;
            this.txtNomePai.CustomButton.Visible = false;
            this.txtNomePai.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNomePai.Lines = new string[0];
            this.txtNomePai.Location = new System.Drawing.Point(36, 217);
            this.txtNomePai.MaxLength = 32767;
            this.txtNomePai.Name = "txtNomePai";
            this.txtNomePai.PasswordChar = '\0';
            this.txtNomePai.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomePai.SelectedText = "";
            this.txtNomePai.SelectionLength = 0;
            this.txtNomePai.SelectionStart = 0;
            this.txtNomePai.ShortcutsEnabled = true;
            this.txtNomePai.Size = new System.Drawing.Size(305, 23);
            this.txtNomePai.TabIndex = 4;
            this.txtNomePai.UseSelectable = true;
            this.txtNomePai.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomePai.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(36, 195);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(74, 19);
            this.metroLabel13.TabIndex = 17;
            this.metroLabel13.Text = "NOME PAI:";
            // 
            // txtNomeMae
            // 
            this.txtNomeMae.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtNomeMae.CustomButton.Image = null;
            this.txtNomeMae.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.txtNomeMae.CustomButton.Name = "";
            this.txtNomeMae.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomeMae.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeMae.CustomButton.TabIndex = 1;
            this.txtNomeMae.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeMae.CustomButton.UseSelectable = true;
            this.txtNomeMae.CustomButton.Visible = false;
            this.txtNomeMae.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNomeMae.Lines = new string[0];
            this.txtNomeMae.Location = new System.Drawing.Point(359, 217);
            this.txtNomeMae.MaxLength = 32767;
            this.txtNomeMae.Name = "txtNomeMae";
            this.txtNomeMae.PasswordChar = '\0';
            this.txtNomeMae.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeMae.SelectedText = "";
            this.txtNomeMae.SelectionLength = 0;
            this.txtNomeMae.SelectionStart = 0;
            this.txtNomeMae.ShortcutsEnabled = true;
            this.txtNomeMae.Size = new System.Drawing.Size(279, 23);
            this.txtNomeMae.TabIndex = 5;
            this.txtNomeMae.UseSelectable = true;
            this.txtNomeMae.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeMae.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(359, 195);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(84, 19);
            this.metroLabel14.TabIndex = 19;
            this.metroLabel14.Text = "NOME MÃE:";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(248, 138);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(130, 19);
            this.metroLabel15.TabIndex = 21;
            this.metroLabel15.Text = "DATA NASCIMENTO:";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(248, 163);
            this.txtDataNascimento.Mask = "99/99/9999";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(94, 20);
            this.txtDataNascimento.TabIndex = 2;
            // 
            // txtTelefone1
            // 
            this.txtTelefone1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtTelefone1.CustomButton.Image = null;
            this.txtTelefone1.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.txtTelefone1.CustomButton.Name = "";
            this.txtTelefone1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelefone1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelefone1.CustomButton.TabIndex = 1;
            this.txtTelefone1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelefone1.CustomButton.UseSelectable = true;
            this.txtTelefone1.CustomButton.Visible = false;
            this.txtTelefone1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTelefone1.Lines = new string[0];
            this.txtTelefone1.Location = new System.Drawing.Point(36, 342);
            this.txtTelefone1.MaxLength = 32767;
            this.txtTelefone1.Name = "txtTelefone1";
            this.txtTelefone1.PasswordChar = '\0';
            this.txtTelefone1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelefone1.SelectedText = "";
            this.txtTelefone1.SelectionLength = 0;
            this.txtTelefone1.SelectionStart = 0;
            this.txtTelefone1.ShortcutsEnabled = true;
            this.txtTelefone1.Size = new System.Drawing.Size(128, 23);
            this.txtTelefone1.TabIndex = 9;
            this.txtTelefone1.UseSelectable = true;
            this.txtTelefone1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelefone1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(36, 320);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(83, 19);
            this.metroLabel16.TabIndex = 23;
            this.metroLabel16.Text = "TELEFONE 1:";
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtTelefone2.CustomButton.Image = null;
            this.txtTelefone2.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.txtTelefone2.CustomButton.Name = "";
            this.txtTelefone2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelefone2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelefone2.CustomButton.TabIndex = 1;
            this.txtTelefone2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelefone2.CustomButton.UseSelectable = true;
            this.txtTelefone2.CustomButton.Visible = false;
            this.txtTelefone2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTelefone2.Lines = new string[0];
            this.txtTelefone2.Location = new System.Drawing.Point(193, 342);
            this.txtTelefone2.MaxLength = 32767;
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.PasswordChar = '\0';
            this.txtTelefone2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelefone2.SelectedText = "";
            this.txtTelefone2.SelectionLength = 0;
            this.txtTelefone2.SelectionStart = 0;
            this.txtTelefone2.ShortcutsEnabled = true;
            this.txtTelefone2.Size = new System.Drawing.Size(128, 23);
            this.txtTelefone2.TabIndex = 10;
            this.txtTelefone2.UseSelectable = true;
            this.txtTelefone2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelefone2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(193, 320);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(85, 19);
            this.metroLabel17.TabIndex = 25;
            this.metroLabel17.Text = "TELEFONE 2:";
            // 
            // FormCadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(661, 672);
            this.Controls.Add(this.txtTelefone2);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.txtTelefone1);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.txtNomeMae);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.txtNomePai);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.txtCnhValidade);
            this.Controls.Add(this.txtCnhLetra);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.txtCnhRegistro);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.txtRgIe);
            this.Controls.Add(this.lblRgIE);
            this.Controls.Add(this.txtCpfCnpj);
            this.Controls.Add(this.lblCpfCnpj);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "FormCadastroPessoa";
            this.Text = "Form Pessoa";
            this.Load += new System.EventHandler(this.FormCadastroPessoa_Load);
            this.Controls.SetChildIndex(this.btSalvar, 0);
            this.Controls.SetChildIndex(this.lblNome, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.lblCpfCnpj, 0);
            this.Controls.SetChildIndex(this.txtCpfCnpj, 0);
            this.Controls.SetChildIndex(this.lblRgIE, 0);
            this.Controls.SetChildIndex(this.txtRgIe, 0);
            this.Controls.SetChildIndex(this.metroPanel1, 0);
            this.Controls.SetChildIndex(this.metroLabel1, 0);
            this.Controls.SetChildIndex(this.metroPanel2, 0);
            this.Controls.SetChildIndex(this.metroLabel9, 0);
            this.Controls.SetChildIndex(this.metroLabel10, 0);
            this.Controls.SetChildIndex(this.txtCnhRegistro, 0);
            this.Controls.SetChildIndex(this.metroLabel11, 0);
            this.Controls.SetChildIndex(this.txtCnhLetra, 0);
            this.Controls.SetChildIndex(this.txtCnhValidade, 0);
            this.Controls.SetChildIndex(this.metroLabel12, 0);
            this.Controls.SetChildIndex(this.metroLabel13, 0);
            this.Controls.SetChildIndex(this.txtNomePai, 0);
            this.Controls.SetChildIndex(this.metroLabel14, 0);
            this.Controls.SetChildIndex(this.txtNomeMae, 0);
            this.Controls.SetChildIndex(this.txtDataNascimento, 0);
            this.Controls.SetChildIndex(this.metroLabel15, 0);
            this.Controls.SetChildIndex(this.metroLabel16, 0);
            this.Controls.SetChildIndex(this.txtTelefone1, 0);
            this.Controls.SetChildIndex(this.metroLabel17, 0);
            this.Controls.SetChildIndex(this.txtTelefone2, 0);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblNome;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroTextBox txtCpfCnpj;
        private MetroFramework.Controls.MetroLabel lblCpfCnpj;
        private MetroFramework.Controls.MetroTextBox txtRgIe;
        private MetroFramework.Controls.MetroLabel lblRgIE;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtEnderecoCidade;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtEnderecoCaixaPostal;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtEnderecoCEP;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtEnderecoComplemento;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtEnderecoBairro;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtEnderecoNumero;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtEnderecoLogradouro;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroRadioButton rdPj;
        private MetroFramework.Controls.MetroRadioButton rdPf;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton btSelecionarCidade;
        private MetroFramework.Controls.MetroTextBox txtCnhRegistro;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtCnhLetra;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.MaskedTextBox txtCnhValidade;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txtNomePai;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox txtNomeMae;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private MetroFramework.Controls.MetroTextBox txtTelefone1;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox txtTelefone2;
        private MetroFramework.Controls.MetroLabel metroLabel17;
    }
}
