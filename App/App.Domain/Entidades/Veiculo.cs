using App.Domain.Entidades.Base;
using App.Domain.ObjetosDeValor;
using prmToolkit.NotificationPattern;
namespace App.Domain.Entidades
{
    public class Veiculo : EntidadeBase
    {
        public Veiculo()
        {
            SetValidations();
        } //construtor para EF

        public void SetValues(Placa placa, string renavam, string chassi, string motor, string AnoFab, string AnoMod, string descricaoModelo, string espelho, string combustivel, string cor, VeiculoCategoria categoria, VeiculoEspecie especie, VecimentoLicenciamento licenciamento, Endereco endereco, Pessoa pessoa, Marca marca, bool ativo, string NomeProprietarioAnterior, string CpfCnpjProprietarioAnterior, string DataDaCompra, string ValorDaCompra, string NumeroDaNotaDeCompra)
        {
            this.Placa = placa;
            this.Renavam = renavam.Trim().ToUpper();
            this.Chassi = chassi.Trim().ToUpper();
            this.Motor = motor.Trim().ToUpper();
            this.AnoFab = AnoFab.Trim().ToUpper();
            this.AnoModelo = AnoMod.Trim().ToUpper();
            this.DescricaoModelo = descricaoModelo.Trim().ToUpper();
            this.Espelho = espelho.Trim().ToUpper();
            this.Categoria = categoria;
            this.Especie = especie;
            this.Licenciamento = licenciamento;
            this.Endereco = endereco;
            this.Pessoa = pessoa;
            this.Cor = cor.Trim().ToUpper();
            this.Combustivel = combustivel.Trim().ToUpper();
            this.Marca = marca;
            this.Ativo = ativo;
            this.NomeProprietarioAnterior = NomeProprietarioAnterior;
            this.CpfCnpjProprietarioAnterior = CpfCnpjProprietarioAnterior;
            this.DataDaCompra = DataDaCompra.Trim().ToUpper();
            this.ValorDaCompra = ValorDaCompra.Trim().ToUpper();
            this.NumeroDaNotaDeCompra = NumeroDaNotaDeCompra;
            SetValidations();
        }


        private void SetValidations()
        {
            ClearNotifications();
            //validação dos campos especificos
            //o minimo para de cadastrar um veiculo é: placa, pessoa, especie, categoria e licenciamento
            if (this.Placa == null)
                this.Placa = new Placa("", TipoPlaca.Comum);
            AddNotifications(this.Placa);
            if (this.Pessoa == null)
                this.Pessoa = new Pessoa();
            AddNotifications(this.Pessoa);
            if (this.Endereco == null)
                this.Endereco = new Endereco();
            AddNotifications(this.Endereco);
            if (this.Marca == null)
                this.Marca = new Marca();
            AddNotifications(this.Marca);
            new AddNotifications<Veiculo>(this).IfNullOrWhiteSpace(p => p.Renavam); // verificar obrigatóriedade ainda
            // veirificar se endereco vai ser obrigatório
        }
        public int VeiculoId { get; set; }
        public Placa Placa { get; private set; }
        public string Renavam { get; private set; }
        public string Chassi { get; private set; }
        public string Motor { get; private set; }
        ////
        public string AnoFab { get; private set; }
        public string AnoModelo { get; private set; }
        public string DescricaoModelo { get; private set; }
        public bool Ativo { get;   set; } //não tem private para ref a desativação do anterior e cadastro do novo
        public string Espelho { get; private set; }
        public VeiculoCategoria Categoria { get; private set; }
        public VeiculoEspecie Especie { get; private set; }
        public VecimentoLicenciamento Licenciamento { get; private set; }
        //////
        public Endereco Endereco { get; private set; }
        public Pessoa Pessoa { get; private set; }
        public Marca Marca { get; private set; }
        public string Combustivel { get; private set; }
        public string Cor { get; private set; }
        //dados REFERENTE A COMPRA
        public string NomeProprietarioAnterior { get;  set; } //não tem private para ref a desativação do anterior e cadastro do novo
        public string CpfCnpjProprietarioAnterior { get;  set; } //não tem private para ref a desativação do anterior e cadastro do novo
        public string DataDaCompra { get; private set; }
        public string ValorDaCompra { get; private set; }
        public string NumeroDaNotaDeCompra { get; private set; }

        public string NomeComprador { get; set; }
        public string CpfCnpjComprador { get; set; } 
        public string DataVenda { get;  set; }
        public string ValorVenda { get; set; }

    }

}