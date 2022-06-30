using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace Aula19WPFApp.ViewModels
{
    public class MainViewModel: Screen
    {
        private string nomeCompleto;

        public string NomeCompleto
        {
            get
            {
                return nomeCompleto;
            }
            set
            {
                nomeCompleto = value;
                base.NotifyOfPropertyChange(() => NomeCompleto);
            }
        }
    }
}
