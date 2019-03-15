using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Sukhoviy_01.Properties;

namespace Sukhoviy_01
{
    internal class SignInViewModel:INotifyPropertyChanged
    {
        private DateTime _date = DateTime.Today;
        private int _age;
        private bool _birthday;
        private string _western;
        private string _chinese;

        private RelayCommand<object> _calculateCommand;

        public User Model { get; private set; }

        public SignInViewModel()
        {
            Model = new User();
        }

        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = value;
                OnPropertyChanged();
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
            }
        }

        public bool Birthday
        {
            get { return _birthday; }
            set
            {
                _birthday = value;
            }
        }

        public string Western
        {
            get { return _western; }
            set
            {
                _western = value;
            }
        }

        public string Chinese
        {
            get { return _chinese; }
            set
            {
                _chinese = value;
            }
        }

        public RelayCommand<object> CalculateCommand
        {
            get
            {
                return _calculateCommand ?? (_calculateCommand = new RelayCommand<object>(
                           o =>
                           {
                               Refresh_data();

                           }, o => true));
            }
        }

        public void Refresh_data()
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            DateTime today = DateTime.Today;
            TimeSpan span = today - Date;
            if (DateTime.Today >= Date && (zeroTime + span).Year - 1 <= 135)
            {
                Age = Model.CalculateAge(Date);
                Model.CheckForBirthday(Date);
                Western = Model.WesternAstrological(Date);
                Chinese = Model.ChineseAstrological(Date);
                this.OnPropertyChanged("Age");
                this.OnPropertyChanged("Western");
                this.OnPropertyChanged("Chinese");
            }
            else
            {
                MessageBox.Show("Wrong birthday!");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        } 
    }
}
