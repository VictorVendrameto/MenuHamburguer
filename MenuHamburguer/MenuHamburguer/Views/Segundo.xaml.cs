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
    public partial class Segundo : ContentPage
    {
        public Segundo()
        {
            InitializeComponent();
        }

        private void btn_Ing(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Inglês Instrumental",
                    AtbResponsa = "Comunicar-se em língua estrangeira – inglês, utilizando o vocabulário e a terminologia da área.  ",
                    ValoresAtitudes = "Respeitar as manifestações culturais de outros povos. * Estimular a comunicação nas relações interpessoais. * Socializar os saberes.  "
                };
                 Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                 DisplayAlert("Eita!", ex.Message, "OK");
            }
        }

        private void btn_DS(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Desenvolvimento de Sistemas",
                    AtbResponsa = "Analisar e projetar sistemas de informação, selecionando linguagens de programação e ambientes de desenvolvimento de acordo com as especificidades do projeto. • Codificar e depurar programas. ",
                    ValoresAtitudes = "Fortalecer a persistência e o interesse na resolução de situações-problema. • Incentivar ações que promovam a cooperação. • Desenvolver a criatividade. "
                };
                 Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                 DisplayAlert("Eita!", ex.Message, "OK");
            }
        }
        private void btn_BD2(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Banco de Dados II ",
                    AtbResponsa = "Implementar banco de dados. ",
                    ValoresAtitudes = "Incentivar a criatividade. • Desenvolver a criticidade. • Fortalecer a persistência e o interesse na resolução de situações-problema "
                };
                 Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                 DisplayAlert("Eita!", ex.Message, "OK");
            }
        }
        private void btn_ET(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Ética e Cidadania Organizacional  ",
                    AtbResponsa = "Atuar de acordo com princípios éticos nas relações de trabalho.  ",
                    ValoresAtitudes = "Estimular atitudes respeitosas. • Incentivar comportamentos éticos. • Comprometer-se com a igualdade de direitos.  "
                };

                 Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                 DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void btn_APM(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação de Aplicativos Mobile I ",
                    AtbResponsa = "Elaborar projetos de aplicativos para plataformas móveis. ",
                    ValoresAtitudes = "Incentivar a criatividade. • Responsabilizar-se pela produção, utilização e divulgação de informações. • Estimular a organização.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void btn_PW2(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação Web II",
                    AtbResponsa = "Planejar projetos de sistemas de informação para web ",
                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações. • Fortalecer a persistência e o interesse na resolução de situações-problema. • Incentivar a criatividade.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void btn_SE(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Sistemas Embarcados  ",
                    AtbResponsa = "Desenvolver sistemas embarcados.  ",
                    ValoresAtitudes = "Fortalecer a persistência e o interesse na resolução de situações-problema. • Estimular a organização. • Incentivar a criatividade. "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}
