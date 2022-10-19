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
    public partial class Vestibulinho : ContentPage
    {
        public Vestibulinho()
        {
            InitializeComponent();
        }
        private void btnVest(object sender, EventArgs e)
        {
            try
            {
                //acessa um link
                Device.OpenUri(new Uri("https://www.vestibulinhoetec.com.br"));
            }
            catch (Exception ex)
            {
                DisplayAlert("Eita!", ex.Message, "OK");
            }
        }
    }
}