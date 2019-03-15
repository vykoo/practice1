using System;
using System.Windows;

namespace Sukhoviy_01
{
    internal class User
    {
        public int CalculateAge(DateTime date)
        {
            DateTime zeroTime = new DateTime(1, 1, 1);

            DateTime today = DateTime.Today;
            TimeSpan span = today - date;
            int age = (zeroTime + span).Year - 1;

            return age;
        }

        public bool CheckForBirthday(DateTime date)
        {
            DateTime today = DateTime.Today;
            if (today.Month == date.Month && today.Day == date.Day)
            {
                MessageBox.Show("Happy Birthday!!!");
                return true;
            }
            else
            {
                return false;
            }
        }

        enum WesternNames
        {
            Козерог,
            Водолей,
            Рыбы,
            Овен,
            Телец,
            Близнецы,
            Рак,
            Лев,
            Дева,
            Весы,
            Скорпион,
            Стрелец
        }

        public string WesternAstrological(DateTime date)
        {
            switch (date.Month)
            {
                case 1: return ((date.Day <= 20) ? WesternNames.Козерог : WesternNames.Водолей).ToString(); break;
                case 2: return ((date.Day <= 19) ? WesternNames.Водолей : WesternNames.Рыбы).ToString(); break;
                case 3: return ((date.Day <= 21) ? WesternNames.Рыбы : WesternNames.Овен).ToString(); break;
                case 4: return ((date.Day <= 20) ? WesternNames.Овен : WesternNames.Телец).ToString(); break;
                case 5: return ((date.Day <= 21) ? WesternNames.Телец : WesternNames.Близнецы).ToString(); break;
                case 6: return ((date.Day <= 22) ? WesternNames.Близнецы : WesternNames.Рак).ToString(); break;
                case 7: return ((date.Day <= 23) ? WesternNames.Рак : WesternNames.Лев).ToString(); break;
                case 8: return ((date.Day <= 23) ? WesternNames.Лев : WesternNames.Дева).ToString(); break;
                case 9: return ((date.Day <= 24) ? WesternNames.Дева : WesternNames.Весы).ToString(); break;
                case 10: return ((date.Day <= 23) ? WesternNames.Весы : WesternNames.Скорпион).ToString(); break;
                case 11: return ((date.Day <= 23) ? WesternNames.Скорпион : WesternNames.Стрелец).ToString(); break;
                case 12: return ((date.Day <= 22) ? WesternNames.Стрелец : WesternNames.Козерог).ToString(); break;
                default: return "Error";
            }
        }

        public string ChineseAstrological(DateTime date)
        {
            int year = date.Year;
            int resultNumber = (year-4) % 12;

            switch (resultNumber)
            {
                case 0: return "Крыса";
                case 1: return "Бык";
                case 2: return "Тигр";
                case 3: return "Заяц";
                case 4: return "Дракон";
                case 5: return "Змея";
                case 6: return "Лошадь";
                case 7: return "Овца";
                case 8: return "Обезьяна";
                case 9: return "Петух";
                case 10: return "Собака";
                case 11: return "Кабан";
                default: return "Error";
            }
        }
    }
}
