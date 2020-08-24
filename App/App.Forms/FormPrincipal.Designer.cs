namespace App.Forms
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuMarca = new MetroFramework.Controls.MetroTile();
            this.MenuVeiculo = new MetroFramework.Controls.MetroTile();
            this.menuPessoa = new MetroFramework.Controls.MetroTile();
            this.menuCidade = new MetroFramework.Controls.MetroTile();
            this.MenuFicha = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.pesquisaVeiculo = new MetroFramework.Controls.MetroTile();
            this.cadastroCidade = new MetroFramework.Controls.MetroTile();
            this.cadastroMarca = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // menuMarca
            // 
            this.menuMarca.ActiveControl = null;
            this.menuMarca.Location = new System.Drawing.Point(413, 217);
            this.menuMarca.Name = "menuMarca";
            this.menuMarca.Size = new System.Drawing.Size(169, 112);
            this.menuMarca.TabIndex = 6;
            this.menuMarca.Text = "Menu Marca";
            this.menuMarca.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.menuMarca.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.menuMarca.UseSelectable = true;
            this.menuMarca.Click += new System.EventHandler(this.menuMarca_Click);
            // 
            // MenuVeiculo
            // 
            this.MenuVeiculo.ActiveControl = null;
            this.MenuVeiculo.Location = new System.Drawing.Point(211, 335);
            this.MenuVeiculo.Name = "MenuVeiculo";
            this.MenuVeiculo.Size = new System.Drawing.Size(230, 95);
            this.MenuVeiculo.TabIndex = 8;
            this.MenuVeiculo.Text = "Menu Veiculo";
            this.MenuVeiculo.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MenuVeiculo.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MenuVeiculo.UseSelectable = true;
            this.MenuVeiculo.Click += new System.EventHandler(this.MenuVeiculo_Click);
            // 
            // menuPessoa
            // 
            this.menuPessoa.ActiveControl = null;
            this.menuPessoa.Location = new System.Drawing.Point(302, 437);
            this.menuPessoa.Name = "menuPessoa";
            this.menuPessoa.Size = new System.Drawing.Size(280, 120);
            this.menuPessoa.TabIndex = 7;
            this.menuPessoa.Text = "Menu Pessoa";
            this.menuPessoa.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.menuPessoa.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.menuPessoa.UseSelectable = true;
            this.menuPessoa.Click += new System.EventHandler(this.menuPessoa_Click);
            // 
            // menuCidade
            // 
            this.menuCidade.ActiveControl = null;
            this.menuCidade.Location = new System.Drawing.Point(211, 217);
            this.menuCidade.Name = "menuCidade";
            this.menuCidade.Size = new System.Drawing.Size(196, 112);
            this.menuCidade.TabIndex = 4;
            this.menuCidade.Text = "Menu Cidade";
            this.menuCidade.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.menuCidade.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.menuCidade.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.menuCidade.UseSelectable = true;
            this.menuCidade.UseTileImage = true;
            this.menuCidade.Click += new System.EventHandler(this.menuCidade_Click);
            // 
            // MenuFicha
            // 
            this.MenuFicha.ActiveControl = null;
            this.MenuFicha.Location = new System.Drawing.Point(591, 374);
            this.MenuFicha.Name = "MenuFicha";
            this.MenuFicha.Size = new System.Drawing.Size(166, 182);
            this.MenuFicha.TabIndex = 9;
            this.MenuFicha.Text = "Ficha de Serviço";
            this.MenuFicha.TileImage = global::App.Forms.Properties.Resources.ficha_menu;
            this.MenuFicha.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MenuFicha.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MenuFicha.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MenuFicha.UseSelectable = true;
            this.MenuFicha.UseTileImage = true;
            this.MenuFicha.Click += new System.EventHandler(this.MenuFicha_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(23, 217);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(182, 213);
            this.metroTile3.TabIndex = 3;
            this.metroTile3.Text = "Cadastro Marca";
            this.metroTile3.TileImage = global::App.Forms.Properties.Resources.marca;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(588, 217);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(166, 151);
            this.metroTile2.TabIndex = 5;
            this.metroTile2.Text = "Cadastro Cidade";
            this.metroTile2.TileImage = global::App.Forms.Properties.Resources.city;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // pesquisaVeiculo
            // 
            this.pesquisaVeiculo.ActiveControl = null;
            this.pesquisaVeiculo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pesquisaVeiculo.Location = new System.Drawing.Point(489, 87);
            this.pesquisaVeiculo.Name = "pesquisaVeiculo";
            this.pesquisaVeiculo.Size = new System.Drawing.Size(265, 124);
            this.pesquisaVeiculo.TabIndex = 2;
            this.pesquisaVeiculo.Text = "Relatório Veiculo";
            this.pesquisaVeiculo.TileImage = global::App.Forms.Properties.Resources.report;
            this.pesquisaVeiculo.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pesquisaVeiculo.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.pesquisaVeiculo.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.pesquisaVeiculo.UseSelectable = true;
            this.pesquisaVeiculo.UseTileImage = true;
            this.pesquisaVeiculo.Click += new System.EventHandler(this.pesquisaVeiculo_Click);
            // 
            // cadastroCidade
            // 
            this.cadastroCidade.ActiveControl = null;
            this.cadastroCidade.Location = new System.Drawing.Point(256, 87);
            this.cadastroCidade.Name = "cadastroCidade";
            this.cadastroCidade.Size = new System.Drawing.Size(227, 124);
            this.cadastroCidade.TabIndex = 1;
            this.cadastroCidade.Text = "Cadastro Pessoas";
            this.cadastroCidade.TileImage = global::App.Forms.Properties.Resources.people;
            this.cadastroCidade.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cadastroCidade.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.cadastroCidade.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.cadastroCidade.UseSelectable = true;
            this.cadastroCidade.UseTileImage = true;
            this.cadastroCidade.Click += new System.EventHandler(this.cadastroPessoa_Click);
            // 
            // cadastroMarca
            // 
            this.cadastroMarca.ActiveControl = null;
            this.cadastroMarca.Location = new System.Drawing.Point(23, 87);
            this.cadastroMarca.Name = "cadastroMarca";
            this.cadastroMarca.Size = new System.Drawing.Size(227, 124);
            this.cadastroMarca.TabIndex = 0;
            this.cadastroMarca.Text = "Cadastro Veiculo";
            this.cadastroMarca.TileImage = global::App.Forms.Properties.Resources.car_menu_64px;
            this.cadastroMarca.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cadastroMarca.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.cadastroMarca.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.cadastroMarca.UseSelectable = true;
            this.cadastroMarca.UseTileImage = true;
            this.cadastroMarca.Click += new System.EventHandler(this.metroTile1_Click_1);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(447, 335);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(135, 96);
            this.metroTile1.TabIndex = 10;
            this.metroTile1.Text = "Backup";
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(23, 436);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(273, 120);
            this.metroTile4.TabIndex = 11;
            this.metroTile4.Text = "Relatório CNH";
            this.metroTile4.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 579);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.MenuFicha);
            this.Controls.Add(this.menuPessoa);
            this.Controls.Add(this.MenuVeiculo);
            this.Controls.Add(this.menuMarca);
            this.Controls.Add(this.menuCidade);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.pesquisaVeiculo);
            this.Controls.Add(this.cadastroCidade);
            this.Controls.Add(this.cadastroMarca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile cadastroMarca;
        private MetroFramework.Controls.MetroTile cadastroCidade;
        private MetroFramework.Controls.MetroTile pesquisaVeiculo;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile menuCidade;
        private MetroFramework.Controls.MetroTile menuMarca;
        private MetroFramework.Controls.MetroTile MenuVeiculo;
        private MetroFramework.Controls.MetroTile menuPessoa;
        private MetroFramework.Controls.MetroTile MenuFicha;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile4;
    }
}

