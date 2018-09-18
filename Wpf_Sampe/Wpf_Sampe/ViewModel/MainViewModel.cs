using System.Collections.Generic;
using GalaSoft.MvvmLight;
using Service.Model;
using Service.Service;

namespace Wpf_Sampe.ViewModel
{
    

    public class MainViewModel : ViewModelBase
    {

        private IEnumerable<Person> _persons;
        private Person _selectedPerson;
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            var personService = new PersonService();
            Persons = personService.GetPersons();
        }

        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set { Set(ref _selectedPerson, value); }
        }

        public IEnumerable<Person> Persons
        {
            get { return _persons; }
            set { Set(ref _persons, value); }
        }
    }
}