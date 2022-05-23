using Caliburn.Micro;
using OobAssignment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OobAssignment2.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private string _firstname = "Tim";
        private string _Lastname;
        private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();
        private PersonModel _selectedperson;

        public ShellViewModel()
        {
            People.Add(new PersonModel { Firstname = "Tim", Lastname = "Corey" });
            People.Add(new PersonModel { Firstname = "Bob", Lastname = "Smith" });
            People.Add(new PersonModel { Firstname = "Phill", Lastname = "Cook" });
        }

        public string Firstname
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
                NotifyOfPropertyChange(() => Firstname);
                NotifyOfPropertyChange(() => Fullname);
            }
        }

        public string Lastname
        {
            get { return _Lastname;  }
            set
            {
                _Lastname = value;
                NotifyOfPropertyChange(() => Lastname);
                NotifyOfPropertyChange(() => Fullname);
            }
        }

        public string Fullname
        {
            get { return $"{ Firstname } { Lastname }"; }
        }

        public BindableCollection<PersonModel> People
        {
            get { return _people; }
            set { _people = value; }
        }
        
        public PersonModel SelectedPerson
        {
            get { return _selectedperson; }
            set 
            { 
                _selectedperson = value;
                NotifyOfPropertyChange(() => SelectedPerson);
            }
        }

        public bool CanClearText(string firstname, string lastname)
        {
            //returns true if both firstname and lastname are empty
            return !String.IsNullOrWhiteSpace(firstname) || !String.IsNullOrWhiteSpace(lastname);
        }

        public void ClearText(string firstname, string lastname)
        {
            Firstname = "";
            Lastname = "";
        }

        public void LoadPageOne()
        {
            ActivateItemAsync(new FirstChildViewModel());
        }
        
        public void LoadPageTwo()
        {
            ActivateItemAsync(new SecondChildViewModel());
        }
    }
}
