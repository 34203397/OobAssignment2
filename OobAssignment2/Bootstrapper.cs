using Caliburn.Micro;
using OobAssignment2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OobAssignment2
{
    public class Bootstrapper : BootstrapperBase//creating bootstrapper class that inheritences from bootstrapperbase
    {
        public Bootstrapper()//constructor that calls the initializer method
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)//method called when app starts displaying the main view
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
