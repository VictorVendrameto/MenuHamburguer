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
    public partial class Terceiro : ContentPage
    {
        public Terceiro()
        {
            InitializeComponent();
        }
        private void btn_SSI(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Segurança de Sistemas de Informação  ",
                    AtbResponsa = "Implementar rotinas de segurança da informação. ",
                    ValoresAtitudes = "Estimular atitudes respeitosas. • Incentivar comportamentos éticos. • Desenvolver a criticidade.  "
                };
                Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                DisplayAlert("Eita!", ex.Message, "OK");
            }
        }

        private void btn_BD3(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Banco de Dados III  ",
                    AtbResponsa = "Realizar gestão de bancos de dados.  ",
                    ValoresAtitudes = "Incentivar a criatividade. • Desenvolver a criticidade. • Fortalecer a persistência e o interesse na resolução de situações-problema. "
                };
                Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                
                DisplayAlert("Eita!", ex.Message, "OK");
            }
        }

        private void btn_QTS(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Qualidade e Teste de Software  ",
                    AtbResponsa = "Testar softwares para melhoria da qualidade de sistemas. • Elaborar registros e planilhas de acompanhamento e controle das atividades.  ",
                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações. • Estimular a proatividade. • Desenvolver criticidade. • Incentivar comportamentos éticos "
                };
                Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                DisplayAlert("Eita!", ex.Message, "OK");
            }
        }

        private void btn_IP(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Internet e Protocolos ",
                    AtbResponsa = "Utilizar protocolos de redes e internet para comunicação de dados.  ",
                    ValoresAtitudes = "Incentivar comportamentos éticos. • Promover ações que considerem o respeito às normas estabelecidas. • Fortalecer a persistência e o interesse na resolução de situações-problema.  "
                };
                Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                DisplayAlert("Eita!", ex.Message, "OK");
            }
        }
        private void btn_APM2(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação de Aplicativos Mobile II ",
                    AtbResponsa = "Documentar, construir e manter sistemas de informação para plataformas móveis. ",
                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações. • Incentivar a criatividade. • Estimular a organização "
                };
                Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                DisplayAlert("Eita!", ex.Message, "OK");
            }
        }
        private void btn_PW3(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação Web III  ",
                    AtbResponsa = "Documentar, construir e manter sistemas de informação para web ",
                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações. • Fortalecer a persistência e o interesse na resolução de situações-problema. • Incentivar a criatividade. "
                };
                Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                DisplayAlert("Eita!", ex.Message, "OK");
            }
        }
        private void btn_TCC(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Desenvolvimento do Trabalho de Conclusão de Curso (TCC) em Desenvolvimento de Sistemas   ",
                    AtbResponsa = "Planejar e desenvolver projetos de sistemas computacionais.  ",
                    ValoresAtitudes = "Planejar ações mais eficazes no desenvolvimento de sistemas. • Demonstrar comprometimento com equipe e o trabalho.  "
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