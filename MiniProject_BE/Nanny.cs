using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class Nanny :IComparable
    {
        public int Id { get; set; }
        public int PhoneNumber { get; set; }
        public int Floor/*=Koma*/{ get; set; }
        public int YearsOfExperience { get; set; }
        public int MaxChildrens { get; set; }
        public int minAge { get; set; }
        public int MaxAge {get;set;}
        public int [,] WeekSchedule = new int[2,6]; //example format: 0800 == 08:00.

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Recommendations { get; set; }

        bool isElevator, isPayPerHoure, isTamat;
        bool[] workingDays = new bool[6];

        public double PaymentPerHour { get; set; } //example format: 20.0
        public double PaymentPerMonth { get; set; }
        public double PaymentPerOverHour { get; set; } //תשלום עבור כל שעה מעבר לשעות התעסוקה, דהיינו עבור שעת איחור

        DateTime birthDay = new DateTime();

        Age age;
        Nanny(int year, int month, int day)
        {
            //set nannys age
            birthDay = new DateTime(year, month, day);
            age = new Age(birthDay);
        }

        public override string ToString()
        {
            string tmp = "Nanny's name: " + FirstName + " " + LastName + ", Birthday: " + birthDay.ToString("dd/mm/yyyy") + "( " + age.ToString() + " )\n";
            tmp += "Location: " + Address + " floor No. " + Floor;
            if (isElevator)
                tmp += " (with elevator)";
            else
                tmp += " (without elevator)";
            tmp += " \nHave " + YearsOfExperience + " years of experience. \n";
            tmp += "Acceptings chidlrens between " + minAge + " to " + MaxAge + ", maximum of " + MaxChildrens + " chidlrens.";
            if (isPayPerHoure)
                tmp += "\nPayment only per hour, " + PaymentPerHour + "NIS per hour.";
            else
                tmp += "\nPayment per month " + PaymentPerMonth + " NIS, payment per hour " + PaymentPerHour + "NIS.";

            tmp += "\n\nWorking times during the week:\n";

            //Sunday, Monday, Tuesday, Wednesday, Thursday, Friday

            for (int i=0;i<6;i++)
            {
                //switch (i)
                //{
                //    case 0:
                //        tmp+= 
                //        break;
                //}
            }
            return tmp;
        }

        public int CompareTo(object obj)
        {
            Nanny tmp = obj as Nanny;
            return Id.CompareTo(tmp.Id);
        }
    }
}
