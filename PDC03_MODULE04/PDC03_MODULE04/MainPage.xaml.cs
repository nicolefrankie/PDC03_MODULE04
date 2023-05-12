using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDC03_MODULE04
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public async void OpenActivity01(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity01());
        }
        public async void OpenActivity02(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity02());
        }
        public async void OpenActivity03(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity03());
        }
        public async void OpenActivity04(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity04());
        }
        public async void OpenActivity05(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity05());
        }
    }
}
