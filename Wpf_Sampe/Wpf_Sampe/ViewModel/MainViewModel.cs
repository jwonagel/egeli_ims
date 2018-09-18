using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Service.Model;
using Service.Service;

namespace Wpf_Sampe.ViewModel
{
    

    public class MainViewModel : ViewModelBase
    {

        private ObservableCollection<Person> _persons;
        private Person _selectedPerson;
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            var personService = new PersonService();
            var persons = personService.GetPersons();
            Persons = new ObservableCollection<Person>(persons);
            AddNewPersonCommand = new RelayCommand(AddNewPerson);
        }

        public RelayCommand AddNewPersonCommand { get; private set; }


        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set { Set(ref _selectedPerson, value); }
        }

        public ObservableCollection<Person> Persons
        {
            get { return _persons; }
            set { Set(ref _persons, value); }
        }

        private void AddNewPerson()
        {
            var person = new Person
            {
                Nachname = "",
                Vorname = ""
            };
            Persons.Add(person);
            SelectedPerson = person;
        }
    }
}