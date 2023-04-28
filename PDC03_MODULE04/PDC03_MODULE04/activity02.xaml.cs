﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.ObjectModel;

namespace PDC03_MODULE04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity02 : ContentPage
    {
        ObservableCollection<employee> employees = new ObservableCollection<employee>();
        public ObservableCollection<employee> Employees { get { return employees; } }

        public activity02()
        {
            InitializeComponent();
            EmployeeView.ItemsSource = employees;

            employees.Add(new employee { DisplayName = "Juan Dela Cruz", Position = "President" });
            employees.Add(new employee { DisplayName = "John Doe", Position = "Vice President" });
            employees.Add(new employee { DisplayName = "Peter Cruz", Position = "Director" });
            employees.Add(new employee { DisplayName = "Mark Dela Cruz", Position = "Supervisor" });
        }
        private void Add_Item(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {

            }
        }
        private void Edit_Item(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {

            }
        }
        private void Delete_Item(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {

            }
        }
    }
}