using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Sportsmans
{
    public delegate void PercentChangedHandler();
    public class Sportsmans : INotifyPropertyChanged
    {

        private string name;
        private int birth;
        private string type1;
        private int res1;
        private string type2;
        private double res2;
        private string type3;
        private double res3;
        private string type4;
        private double res4;
        private double best1;
        private double best2;
        private double best3;
        private double best4;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public int Birth
        {
            get { return birth; }
            set
            {
                birth = value;
                OnPropertyChanged("Birth");
            }
        }
        public string Type1
        {
            get { return type1; }
            set
            {
                type1 = value;
                OnPropertyChanged("Type1");
            }
        }
        public int Res1
        {
            get { return res1; }
            set
            {
                res1 = value;
                OnPropertyChanged("Res1");
            }
        }
        public string Type2
        {
            get { return type2; }
            set
            {
                type2 = value;
                OnPropertyChanged("Type2");
            }
        }
        public double Res2
        {
            get { return res2; }
            set
            {
                res2 = value;
                OnPropertyChanged("Res2");
            }
        }
        public string Type3
        {
            get { return type3; }
            set
            {
                type3 = value;
                OnPropertyChanged("Type3");
            }
        }
        public double Res3
        {
            get { return res3; }
            set
            {
                res3 = value;
                OnPropertyChanged("Res3");
            }
        }
        public string Type4
        {
            get { return type4; }
            set
            {
                type4 = value;
                OnPropertyChanged("Type4");
            }
        }
        public double Res4
        {
            get { return res4; }
            set
            {
                res4 = value;
                OnPropertyChanged("Res4");
            }
        }
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

        public DbSet<Sportsmans> Sportsman { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
