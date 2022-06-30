using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using Aula19WPFApp.ViewModels;

namespace Aula19WPFApp
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            base.Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            base.DisplayRootViewFor<MainViewModel>();
        }
    }
}
