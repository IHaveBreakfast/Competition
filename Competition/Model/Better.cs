using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Phone.Model
{
    public delegate void PercentChangedHandler();
    public class Better : INotifyPropertyChanged
    {

        private double best1;
        private double best2;
        private double best3;
        private double best4;

        public double Best1
        {
            get { return best1; }
            set
            {
                best1 = value;
                OnPropertyChanged("Best1");
            }
        }
        public double Best2
        {
            get { return best2; }
            set
            {
                best2 = value;
                OnPropertyChanged("Best2");
            }
        }
        public double Best3
        {
            get { return best3; }
            set
            {
                best3 = value;
                OnPropertyChanged("Best3");
            }
        }
        public double Best4
        {
            get { return best4; }
            set
            {
                best4 = value;
                OnPropertyChanged("Best4");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
