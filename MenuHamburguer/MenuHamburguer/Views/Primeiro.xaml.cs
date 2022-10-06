using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MenuHamburguer.Model;

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
                var c = new Componente
                {
                    Nome = "Linguagem, Trabalho e Tecnologia",

                    AtbResponsa = "Comunicar-se em língua portuguesa, utilizando o vocabulário técnico da área e " +
                                                   "Elaborar registros e planilhas de acompanhamento e controle de atividades",

                    ValoresAtitudes = "Incentivar o dialogo e a interlocução. * Responsabilizar-se pela produção, utilização e " +
                                      "divulgação de informações. * Estimular a proatividade. "
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
                var c = new Componente
                {
                    Nome = "Programação e Algoritmos",

                    AtbResponsa = "Comunicar-se em língua portuguesa, utilizando o vocabulário técnico da área e " +
                                                   "Elaborar registros e planilhas de acompanhamento e controle de atividades",

                    ValoresAtitudes = "Incentivar o dialogo e a interlocução. * Responsabilizar-se pela produção, utilização e " +
                                      "divulgação de informações. * Estimular a proatividade. "
                };
                 Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                 DisplayAlert("Eita!", ex.Message, "OK");
            }
        }

        //Banco
        private void btn_BD1(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Banco de Dados I",

                    AtbResponsa = "Modelar Banco de Dados ",
                                                   

                    ValoresAtitudes = "Estimular a organização. * Fortalecer a persistência e o interesse na resolução " +
                                      "de situações-problema. * Promover ações que considerem o respeito às normas estabelecidas. "
                };
                 Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                 DisplayAlert("Eita!", ex.Message, "OK");
            }
        }

        //Análise
        private void btn_APS(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Análise e Projeto de Sistemas",

                    AtbResponsa = "Elaborar projetos de sistema de informação. ",


                    ValoresAtitudes = "Estimular a organização. *Incentivar a criatividade. * Fortalecer a persistência " +
                                      "e o interesse na resolução de situações-problema.  ",
                };
                 Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                 DisplayAlert("Eita!", ex.Message, "OK");
            }
        }

        //Design
        private void btn_Design(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Design Digital",

                    AtbResponsa = "Desenvolver elementos gráficos para aplicativos e sites. ",


                    ValoresAtitudes = "Incentivar a criatividade. * Respeitar as manifestações culturais de outros povos. " +
                                      "* Incentivar ações que promovam a cooperação. ",
                };
                 Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                 DisplayAlert("Eita!", ex.Message, "OK");
            }
        }

        //ProWeb
        private void btn_PW1(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação Web I",

                    AtbResponsa = "Desenvolver sites para Web. ",


                    ValoresAtitudes = "Incentivar a criatividade. * Estimular a organização. * Fortalecer a persistencia " +
                                      "e o interesse na resolução de situações-problema. ",
                };
                Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                DisplayAlert("Eita!", ex.Message, "OK");
            }
        }

        //Fundamentos
        private void btn_FI(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Fundamentos da Informática",
                    AtbResponsa = "Operar sistemas computacionais.  ",
                    ValoresAtitudes = "Desenvolver a criticidade. * Incentivar comportamentos éticos. * Promover ações que considerem o respeito às normas estabelecidas.  "
                };
                 Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                 DisplayAlert("Eita!", ex.Message, "OK");
            }
        }

        //Tecnicas de Programação
        private void btn_TP(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Técnicas de Programação",

                    AtbResponsa = "Desenvolver programas de computador, utilizando princípios de boas práticas. • Realizar versionamento no desenvolvimento de programas.  • Verificar usabilidade no desenvolvimento de programas.  ",
                    
                    ValoresAtitudes = "Incentivar a criatividade. • Incentivar comportamentos éticos. • Fortalecer a persistência e o interesse na resolução de situações-problema. "
                };
                 Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                 DisplayAlert("Eita!", ex.Message, "OK");
            }
        }

        
              
    }
}