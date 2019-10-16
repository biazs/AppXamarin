using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AppXamarin.Servico.Modelo;
using AppXamarin.Servico;

namespace AppXamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            botao.Clicked += buscarCEP;
        }

        private void buscarCEP(object sender, EventArgs args)
        {
            //TODO - Lógica do programa
            //TODO - Validações

            string Cep = cep.Text.Trim();
            Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(Cep);

            resultado.Text = string.Format("Endereço: {0} - {1} \n {2}, {3}", end.logradouro, end.bairro, end.localidade, end.uf );

        }
    }
}
