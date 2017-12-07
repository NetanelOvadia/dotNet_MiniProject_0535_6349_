using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class Nanny
    {
        int id, phoneNumber, floor/*=Koma*/, yearsOfExperience, maxChildrens, minAge, maxAge ;

        string firstName, lastName, address;
        List<string> Recommendations = new List<string>();

        bool isElevator, isPayPerHoure, isTamat;
        bool[] workingDays = new bool[6];

        float paymentPerHour, paymentPerMonth, paymentPerOverHour;
        float[,] weekSchedule = new float[2,6];

        DateTime birthDay = new DateTime();

        Nanny(int year, int month, int day)
        {
            //set nannys age
            birthDay = new DateTime(year, month, day);
        }



        public override string ToString()
        {
            string tmp = "Nanny's name: " + firstName + " " + lastName + ", Birthday: " + birthDay.ToString("dd/mm/yyyy") + "( " + additionalFunc.ageCalculate(birthDay, birthDay) + " )\n";
            tmp += "Location: " + address + " floor No. " + floor;
            if (isElevator)
                tmp += " (with elevator)";
            else
                tmp += " (without elevator)";
            tmp += " \nHave " + yearsOfExperience + " years of experience. \n";
            tmp += "Acceptings chidlrens between " + minAge + " to " + maxAge + ", maximum of " + maxChildrens + " chidlrens.";
            if (isPayPerHoure)
                tmp += "\nPayment only per hour, " + paymentPerHour + "NIS per hour.";
            else
                tmp += "\nPayment per month " + paymentPerMonth + " NIS, payment per hour " + paymentPerHour + "NIS.";

            tmp += "\n\nWorking times during the week:\n";

            //Sunday, Monday, Tuesday, Wednesday, Thursday, Friday

            for (int i=0;i<6;i++)
            {
                switch (i)
                {
                    case 0:
                        tmp+= 
                        break;
                }
            }
            return tmp;
        }

    }
}
