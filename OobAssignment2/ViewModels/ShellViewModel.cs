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
        private string _ticket;
        private string _addon;
        private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();
        private BindableCollection<AdditionalModel> _add = new BindableCollection<AdditionalModel>();
        private PersonModel _selectedticket;
        private AdditionalModel _selectedaddon;

        public ShellViewModel()
        {
            People.Add(new PersonModel { Ticket = "Adult"});
            People.Add(new PersonModel { Ticket = "Child"});
            People.Add(new PersonModel { Ticket = "Members"});
            Add.Add(new AdditionalModel { Addon = "Pie and Pint" });
        }
        //Creating public objects that gets and sets variables on what being shown
        public string Ticket
        {
            get
            {
                return _ticket;
            }
            set
            {
                _ticket = value;
                NotifyOfPropertyChange(() => Ticket);
                NotifyOfPropertyChange(() => Fullname);
            }
        }
        public string Addon
        {
            get
            {
                return _addon;
            }
            set
            {
                _addon = value;
                NotifyOfPropertyChange(() => Addon);
                NotifyOfPropertyChange(() => Fullname);
            }
        }
        //fetching the full name created by what ever the other objects are set to
        public string Fullname
        {
            get { return $"{ Ticket } { Addon }"; }
        }
        //fetching the collections of data for these objects
        public BindableCollection<PersonModel> People
        {
            get { return _people; }
            set { _people = value; }
        }

        public BindableCollection<AdditionalModel> Add
        {
            get { return _add; }
            set { _add = value; }
        }

        //Code to fetch the variables selected in the drop boxes and check if they get changed throughout the process
        public PersonModel SelectedTicket
        {
            get { return _selectedticket; }
            set 
            { 
                _selectedticket = value;
                NotifyOfPropertyChange(() => SelectedTicket);
            }
        }

        public AdditionalModel SelectedAddon
        {
            get { return _selectedaddon; }
            set
            {
                _selectedaddon = value;
                NotifyOfPropertyChange(() => SelectedAddon);
            }
        }


        public bool CanClearText(string firstname, string lastname)
        {
            //returns true if both firstname and lastname are empty
            return !String.IsNullOrWhiteSpace(firstname) || !String.IsNullOrWhiteSpace(lastname);
        }

        //Loading Displat page to present the charges and prices
        public void LoadPageOne()
        {
            ActivateItemAsync(new FirstChildViewModel());
        }
    }
}
