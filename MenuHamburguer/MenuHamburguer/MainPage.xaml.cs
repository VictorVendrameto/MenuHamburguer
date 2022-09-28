﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using AppNovaGuiaCursoDS.Views;

namespace AppNovaGuiaCursoDS
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Inicial)));
        }

        private void Open_Inicial(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Inicial)));
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Eita", ex.Message, "OK");
            }
        }

        private void Open_Primeiro(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Primeiro)));
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Eita", ex.Message, "OK");
            }
        }

        private void Open_Segundo(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Segundo)));
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Eita", ex.Message, "OK");
            }
        }

        private void Open_Terceiro(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Terceiro)));
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Eita", ex.Message, "OK");
            }
        }

        private void Open_Vestibulinho(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Vestibulinho)));
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Eita", ex.Message, "OK");
            }
        }

        private void Open_Contato(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Contato)));
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Eita", ex.Message, "OK");
            }
        }
    }
}
