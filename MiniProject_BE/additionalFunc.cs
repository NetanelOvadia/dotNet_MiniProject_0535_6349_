using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class additionalFunc
    {
        // private float ageCalculate(DateTime birthDate, DateTime secondDate = new DateTime())
        //  {
        //float tmp;

        //int year, month, day;

        //year = (DateTime.Now.Year - birthDate.Year);//עבור לידה של אורטל גיל 30
        //month = (DateTime.Now.Month - birthDate.Month);//עבור לידה של אורטל חודש 0 דהיינו 30 שלם

        //if (DateTime.Now.Month <= birthDate.Month)//אם התנאי מתקיים אז לא השלים את אותה שנה וצריך להוריד שנה
        //{
        //    if(DateTime.Now.Day < birthDate.Day)//עבור לידה של אורטל 
        //    {
        //        year--;
        //        month
        //    }
        //    year--;
        //}

        //  return tmp;
        //}


        public static string ageCalculate(DateTime birthDate, DateTime now = new DateTime(), bool showYears = true)
        {
            int birthDay, birthMonth, birthYear;
            int sum, temp = 0;
            string age;

            
            //חישוב כמה ימים
            sum = (30 - now.Day) + birthDate.Day;
            birthDay = sum % 10;
            if ((sum / 10) >= 3)
                temp = 1;
            age = birthDay + " ";

            //חישוב כמה חודשים
            sum = (12 - now.Month) + birthDate.Month;
            sum += temp;
            temp = 0;
            if (sum > 12)
            {
                temp = 1;
                birthMonth = sum = 12;
            }
            else
                birthMonth = sum;

            age += birthMonth + " ";

            //חישוב כמה שנים
            sum = (now.Year - 2000) + (2000 - birthDate.Year);
            birthYear = sum + temp;
            age += birthYear;


            return age;
        }

    }
}
