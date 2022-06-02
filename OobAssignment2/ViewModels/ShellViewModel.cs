using Caliburn.Micro;
using OobAssignment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Components;
using Decorator.Decorators;

namespace OobAssignment2.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        //public string charge;
        private string _ticket;
        private string _addon;
        private string _bill;
        private EntryModel _selectedticket;
        private AdditionalModel _selectedaddon;
        private BindableCollection<EntryModel> _entry = new BindableCollection<EntryModel>();
        private BindableCollection<AdditionalModel> _add = new BindableCollection<AdditionalModel>();


        //Creating instances of the decorator components
        readonly Adult adult = new Adult();
        readonly Child child = new Child();
        readonly Members member = new Members();

        //sending the data to shellviewmodel to put into the combo boxes
        public ShellViewModel()
        {
            Entry.Add(new EntryModel { Ticket = adult.Description}) ;
            Entry.Add(new EntryModel { Ticket = child.Description});
            Entry.Add(new EntryModel { Ticket = member.Description});
            Add.Add(new AdditionalModel { Addon = "Horn" });
            Add.Add(new AdditionalModel { Addon = "Pie and Pint" });
            Add.Add(new AdditionalModel { Addon = "Tour" });
        }
        //Creating public objects that gets and sets variables on what being shown depending on the drop item users choose
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
            }
        }
        //fetching the collections of data for these objects
        public BindableCollection<EntryModel> Entry
        {
            get { return _entry; }
            set { _entry = value; }
        }

        public BindableCollection<AdditionalModel> Add
        {
            get { return _add; }
            set { _add = value; }
        }

        //Code to fetch the variables selected in the drop boxes and check if they get changed throughout the process using notifyofchange
        public EntryModel SelectedTicket
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


        private void Bill()
        {
            
        }

    }
}
