using Phone.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Sportsmans
{

    public class Command : ICommand
    {
        private readonly Action action;

        public Command(Action action)
        {
            this.action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            action();
        }
    }


    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private Sportsmans selectedSportsmans;
        private Better selectedBetter;

        public ObservableCollection<Sportsmans> Sportsmans { get; set; }
        public ObservableCollection<Better> Better { get; set; }
        public Sportsmans SelectedSportsmans
        {
            get { return selectedSportsmans; }
            set
            {
                selectedSportsmans = value;
                OnPropertyChanged("SelectedSportsmans");
            }
        }
        public Better SelectedBetter
        {
            get { return selectedBetter; }
            set
            {
                selectedBetter = value;
                OnPropertyChanged("SelectedBetter");
            }
        }

        public ApplicationViewModel()
        {
            Sportsmans = new ObservableCollection<Sportsmans>
            {
                // 
                new Sportsmans { Name="Антонов Антон", Birth=2004, Type1="Отжимания", Res1=56, Type2="Спринт 60м", Res2=7.7, Type3="Спринт 200м", Res3=40.1, Type4="Прыжки в длину с места", Res4=2.39 },
                new Sportsmans { Name="Борисов Борис", Birth=2005, Type1="Отжимания", Res1=53, Type2="Спринт 60м", Res2=8.3, Type3="Спринт 200м", Res3=39.1, Type4="Прыжки в длину с места", Res4=2.11 },
                new Sportsmans { Name="Вальерев Велерий", Birth=2004, Type1="Отжимания", Res1=30, Type2="Спринт 60м", Res2=9.7, Type3="Спринт 200м", Res3=45.5, Type4="Прыжки в длину с места", Res4=2.49 },
                new Sportsmans { Name="Грибников Алексей", Birth=2004, Type1="Отжимания", Res1=110, Type2="Спринт 60м", Res2=9.0, Type3="Спринт 200м", Res3=55.0, Type4="Прыжки в длину с места", Res4=2.04 },
                new Sportsmans { Name="Домашний Дмитрий", Birth=2005, Type1="Отжимания", Res1=80, Type2="Спринт 60м", Res2=9.4, Type3="Спринт 200м", Res3=47.2, Type4="Прыжки в длину с места", Res4=2.28 },
                new Sportsmans { Name="Заморов Николай", Birth=2005, Type1="Отжимания", Res1=66, Type2="Спринт 60м", Res2=8.4, Type3="Спринт 200м", Res3=48.9, Type4="Прыжки в длину с места", Res4=2.20 },
                new Sportsmans { Name="Петров Иван", Birth=2005, Type1="Отжимания", Res1=84, Type2="Спринт 60м", Res2=8.7, Type3="Спринт 200м", Res3=50.7, Type4="Прыжки в длину с места", Res4=2.18 },
                new Sportsmans { Name="Сергеев Илья", Birth=2004, Type1="Отжимания", Res1=92, Type2="Спринт 60м", Res2=11.1, Type3="Спринт 200м", Res3=49.4, Type4="Прыжки в длину с места", Res4=2.03 },
                new Sportsmans { Name="Талиев Антон", Birth=2003, Type1="Отжимания", Res1=52, Type2="Спринт 60м", Res2=10.0, Type3="Спринт 200м", Res3=51.3, Type4="Прыжки в длину с места", Res4=2.00 },
                new Sportsmans { Name="Фазанов Андрей", Birth=2004, Type1="Отжимания", Res1=63, Type2="Спринт 60м", Res2=9.7, Type3="Спринт 200м", Res3=52.2, Type4="Прыжки в длину с места", Res4=2.05 },
                //
                new Sportsmans { Name="Аполова Татьяна", Birth=2004, Type1="Отжимания", Res1=64, Type2="Спринт 60м", Res2=7.9, Type3="Спринт 200м", Res3=41.3, Type4="Прыжки в длину с места", Res4=2.45 },
                new Sportsmans { Name="Беренгова Яна", Birth=2004, Type1="Отжимания", Res1=31, Type2="Спринт 60м", Res2=8.1, Type3="Спринт 200м", Res3=38.1, Type4="Прыжки в длину с места", Res4=1.89 },
                new Sportsmans { Name="Колиавская Елизавета", Birth=2004, Type1="Отжимания", Res1=56, Type2="Спринт 60м", Res2=9.7, Type3="Спринт 200м", Res3=39.9, Type4="Прыжки в длину с места", Res4=2.30 },
                new Sportsmans { Name="Мерианова Анастасия", Birth=2005, Type1="Отжимания", Res1=33, Type2="Спринт 60м", Res2=8.9, Type3="Спринт 200м", Res3=40.0, Type4="Прыжки в длину с места", Res4=1.96 },
                new Sportsmans { Name="Олейникова Анастасия", Birth=2005, Type1="Отжимания", Res1=32, Type2="Спринт 60м", Res2=8.5, Type3="Спринт 200м", Res3=45.6, Type4="Прыжки в длину с места", Res4=2.06 },
                new Sportsmans { Name="Степанова Дарья", Birth=2004, Type1="Отжимания", Res1=40, Type2="Спринт 60м", Res2=9.6, Type3="Спринт 200м", Res3=58.0, Type4="Прыжки в длину с места", Res4=2.10 },
                new Sportsmans { Name="Солеанова Мария", Birth=2004, Type1="Отжимания", Res1=74, Type2="Спринт 60м", Res2=8.8, Type3="Спринт 200м", Res3=44.4, Type4="Прыжки в длину с места", Res4=2.11 },
                new Sportsmans { Name="Ульянова Ульяна", Birth=2004, Type1="Отжимания", Res1=38, Type2="Спринт 60м", Res2=7.5, Type3="Спринт 200м", Res3=35.5, Type4="Прыжки в длину с места", Res4=2.12 },
                new Sportsmans { Name="Хочавоникова Алина", Birth=2004, Type1="Отжимания", Res1=50, Type2="Спринт 60м", Res2=8.8, Type3="Спринт 200м", Res3=36.7, Type4="Прыжки в длину с места", Res4=2.13 },
                new Sportsmans { Name="Якорева Ирина", Birth=2005, Type1="Отжимания", Res1=39, Type2="Спринт 60м", Res2=9.8, Type3="Спринт 200м", Res3=40.3, Type4="Прыжки в длину с места", Res4=2.04 },
            };
            Better = new ObservableCollection<Better>
            {
                new Better { Best1 = Sportsmans.Max(best => best.Res1), Best2 = Sportsmans.Min(best => best.Res2), Best3 = Sportsmans.Min(best => best.Res3), Best4 = Sportsmans.Max(best => best.Res4) },
            };

        }
        public ICommand AddCommand
        {
            get
            {
                return new Command(() => AddSportsman(Sportsmans));
            }
        }

        private void AddSportsman(ObservableCollection<Sportsmans> sportsmans)
        {
            throw new NotImplementedException();
        }

        public int GetSportsmansCount()
        {
            return Sportsmans.Count;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


    }
}
