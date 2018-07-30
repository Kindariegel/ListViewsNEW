using ListViewsNEW.Model;
using ListViewsNEW.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewsNEW
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
         }



        /*void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //catch deselection
            }
            Person person = e.SelectedItem as Person;
            DisplayAlert("Selected", person.LastName, "OK");

        }
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
            {
                if (e.SelectedItem == null)
                {
                    return; //catch deselection
                }
                Person person = e.SelectedItem as Person;
                DisplayAlert("Selected", person.LastName, "OK");
          }
          */
     }
}

