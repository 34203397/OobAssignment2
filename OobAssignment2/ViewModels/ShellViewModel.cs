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
    public class ShellViewModel : Screen
    {
        //public string charge;
        private string _ticket;
        private string _addon;
        private EntryModel _selectedticket;
        _selectedticket.Ticket = "Adult";
        private AdditionalModel _selectedaddon;
        private BindableCollection<EntryModel> _entry = new BindableCollection<EntryModel>();
        private BindableCollection<AdditionalModel> _add = new BindableCollection<AdditionalModel>();
        private BindableCollection<BillModel> _cheq = new BindableCollection<BillModel>();


        //Creating instances of the decorator components
        readonly Adult adult = new Adult();
        readonly Child child = new Child();
        readonly Members member = new Members();

        //sending the data to shellviewmodel to put into the combo boxes
        public ShellViewModel()
        {
            Entry.Add(new EntryModel { Ticket = "Adult" }) ;
            Entry.Add(new EntryModel { Ticket = "Child"});
            Entry.Add(new EntryModel { Ticket = "Member" });
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
        

        public BindableCollection<BillModel> Bill
        {
            get { return _cheq; }
            set { _cheq = value; }
        }


        //Code to fetch the variables selected in the drop boxes and check if they get changed throughout the process using notifyofchange
        public EntryModel SelectedTicket
        {
            get { return _selectedticket; }
            set 
            { 
                _selectedticket = value;
                NotifyOfPropertyChange(() => SelectedTicket);
                NotifyOfPropertyChange(() => Cheque);
            }
        }

        public AdditionalModel SelectedAddon
        {
            get { return _selectedaddon; }
            set
            {
                _selectedaddon = value;
                NotifyOfPropertyChange(() => SelectedAddon);
                NotifyOfPropertyChange(() => Cheque);
            }
        }
        public void OnSubmitButtonClicked()
        {
            if (SelectedTicket != null)
            {
                public string Cheque;
                {
                    
            }
        }
public string Cheque
{
    get { return $"{SelectedTicket.Ticket} {SelectedAddon.Addon}"; }
}

    }
}
