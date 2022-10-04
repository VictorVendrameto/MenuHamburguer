using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MenuHamburguer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Primeiro : ContentPage
    {
        public Primeiro()
        {
            InitializeComponent();
        }

        //Linguagem, Trabalho e Tecnologia
        private async void btn_LTT(object sender, EventArgs e)
        {
            try
            {
                var c = new VerComponente
                {
                    Nome = "Linguagem, Trabalho e Tecnologia",

                    AtribuicoesResponsabilidades = "Comunicar-se em língua portuguesa, utilizando o vocabulário técnico da área e " +
                                                   "Elaborar registros e planilhas de acompanhamento e controle de atividades",

                    ValoresAtitudes = "Incentivar o dialogo e a interlocução. * Responsabilizar-se pela produção, utilização e " +
                                      "divulgação de informações. * Estimular a proatividade. ",
                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Eita!", ex.Message, "OK");
            }
        }

        //ProAlg
        private void btn_PA(object sender, EventArgs e)
        {
            try
            {
                var c = new VerComponente
                {
                    Nome = "Programação e Algoritmos",

                    AtribuicoesResponsabilidades = "Comunicar-se em língua portuguesa, utilizando o vocabulário técnico da área e " +
                                                   "Elaborar registros e planilhas de acompanhamento e controle de atividades",

                    ValoresAtitudes = "Incentivar o dialogo e a interlocução. * Responsabilizar-se pela produção, utilização e " +
                                      "divulgação de informações. * Estimular a proatividade. ",
                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Eita!", ex.Message, "OK");
            }
        }

        //Banco
        private void btn_BD1(object sender, EventArgs e)
        {

        }

        //Análise
        private void btn_APS(object sender, EventArgs e)
        {

        }

        //Design
        private void btn_Design(object sender, EventArgs e)
        {

        }

        //ProWeb
        private void btn_PW1(object sender, EventArgs e)
        {

        }

        //Fundamentos
        private void btn_FI(object sender, EventArgs e)
        {

        }

        //Tecnicas de Programação
        private void btn_TP(object sender, EventArgs e)
        {

        }

        
              
    }
}