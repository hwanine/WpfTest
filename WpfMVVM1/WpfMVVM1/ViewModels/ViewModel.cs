using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMVVM1.ViewModels
{
    class ViewModel : Notifier
    {
        private decimal euros;
        public decimal Euros
        {
            get { return euros; }
            set
            {
                euros = value;
                OnEurosChanged();
                OnPropertyChanged("Euros");
                
            }
        }

        private decimal dollars;

        public decimal Dollars
        {
            get { return dollars; }
            set
            {
                dollars = value;
                OnPropertyChanged("Dollars");
            }
        }

        // This is where the magic hapens
        private void OnEurosChanged()
        {
            Dollars = Euros * 1.1M;
        }
    }
}
