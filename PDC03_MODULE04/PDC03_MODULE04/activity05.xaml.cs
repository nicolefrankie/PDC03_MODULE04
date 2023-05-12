using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MODULE04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity05 : ContentPage
    {
        List<Contact> contacts;
        public activity05()
        {
            InitializeComponent();

            SetUpData();
            ListView.ItemsSource = contacts;
        }
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(ListView.SelectedItem != null)
            {
                var detailPage = new DetailPage();
                detailPage.BindingContext = e.SelectedItem as Contact;
                ListView.SelectedItem = null;
                await Navigation.PushModalAsync(detailPage);
            }
        }

        void SetUpData()
        {
            contacts = new List<Contact>();
            contacts.Add(new Contact
            {
                Name = "Juan Dela Cruz",
                Age = 30,
                Occupation = "Analyst",
                Country = "Philippines"
            });

            contacts.Add(new Contact
            {
                Name = "Stephanie Basilio",
                Age = 20,
                Occupation = "Boxer",
                Country = "Philippines"
            });

            contacts.Add(new Contact
            {
                Name = "Dan Isidrei Musni",
                Age = 20,
                Occupation = "Bouncer",
                Country = "Philippines"
            });
        }
    }
}