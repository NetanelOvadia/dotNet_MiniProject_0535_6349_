using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class Nanny
    {
        int id, phoneNumber, floor/*=Koma*/, yearsOfExperience, maxChildrens, minAge, maxAge ;

        string firstName, lastName, birthDate, address;
        List<string> Recommendations = new List<string>();

        bool isElevator, isPayPerHoure, isTamat;
        bool[] workingDays = new bool[6];

        float paymentPerHour, paymentPerMonth;
        float[,] weekSchedule = new float[2,6];
        
        Nanny()
        {

        }
        public override string ToString()
        {
            string tmp="aa";
            return tmp;
        }

    }
}
