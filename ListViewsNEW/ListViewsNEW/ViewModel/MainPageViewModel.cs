using ListViewsNEW.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListViewsNEW.ViewModel
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Person> People { get; set; } =
        new ObservableCollection<Person>();

        public ICommand ItemSelectedCommand { get; private set; }

        private string SelectedItemText
        {
            get { return SelectedItemText; }
            set
            {
                SelectedItemText = value;
                RaisePropertyChanged();
            }
         }
        public MainPageViewModel()
        {
            Random rand = new Random();
            for (int i = 1; i < 8; i++)
            {
                Person person = new Person();
                //person.Name = "Bob Liberty" + i.ToString();
                //person.Age = (decimal)(35 + rand.NextDouble());
                //person.ImageSource = "man" + i.ToString() + ".jpeg";
                person.FirstName = $"Bob {i.ToString()}";
                person.LastName = $"Liberty {i.ToString()}";
                person.Address = i.ToString() + " Main Street";
                People.Add(person);

            }

            ItemSelectedCommand = new Command<Person>(HandleItemSelected);

        }

        private void HandleItemSelected(Person person)
        {
            SelectedItemText = $"{person.FirstName} {person.LastName}";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(
        [CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }

    }
}
