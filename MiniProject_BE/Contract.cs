using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    //הכנסתי את כל הפרמטרים,
    //בנאי מעודכן
    //יש העמסה של ToString
    public class Contract 
    {
        static int counter=00000000;
        int id, nannysId, childrensId;

        bool haveMeeting, haveDeal, isContractByHour;

        double paymentPerHour, paymentPerMonth, paymentPerOverHour; //תשלום על שעות מעבר למסגרת - מחיר מוגדל
        
        DateTime startDate = new DateTime();//תאריך כניסת הילד למסגרת
        DateTime endDate = new DateTime();//תאריך סיום מסגרת הילד
        DateTime startDeal = new DateTime();//תאריך חתימה על החוזה

        Contract(int _nannysId, int _childresnId, bool _haveMeeting=false, bool _haveDeal=false,
            bool _isContractByHour=false, double _paymnentPerHour=0.0, double _paymentPerMonth=0.0, double _paymentPerOverHour=0.0 ,
            DateTime _startDate = new DateTime(), DateTime _endDate = new DateTime(), DateTime _startDeal = new DateTime())
            //הסיבה פרמטרים ברירת מחדל עבור חלק מהמשתנים, בהנחה שנרצה ליצור איזה אפשרות של הגדרה מה חובה למלאות ומה לא, אז אם נקבל משהו ריק יהיה לנו איך להתמודד עם זה
        {
            id = counter++;
            nannysId = _nannysId;
            childrensId = _childresnId;
            haveMeeting = _haveMeeting;
            haveDeal = _haveDeal;
            isContractByHour = _isContractByHour;
            paymentPerHour = _paymnentPerHour;
            paymentPerMonth = _paymentPerMonth;
            paymentPerOverHour = _paymentPerOverHour;
            startDate = _startDate;
            endDate = _endDate;
            startDeal = _startDeal;
        }

        public override string ToString()
        {
            string tmp = "פרטים אודות חוזה מספר " + id + " : ";
            tmp += "\nמספר תעודת זהות של המטפלת: " + nannysId;
            tmp += "\nמספר זהות של הילד: " + childrensId;
            tmp += "\nתאריך כניסת הילד למסגרת: " + startDate.ToString("dd/mm/yyyy") + ",תאריך סיום: " + endDate.ToString("dd/mm/yyyy");
            tmp += " (משך תקופה: " + additionalFunc.ageCalculate(startDate, endDate, false) + " חודשים ) ";
            tmp += "\nפרטים נוספים:";
            if (haveMeeting)
                tmp += "\nנערכה פגישת היכרות עם המטפלת.";
            else
                tmp += "\nלא נערכה פגישת היכרות עם המטפלת";
            if (isContractByHour)
                tmp += "\nהתשלום מתבצע לפי שעות, תעריף לשעה: " + paymentPerHour;
            else
                tmp += "\nהתשלום מתבצע לפי חודש, תעריף לחודש: " + paymentPerMonth;
            tmp += "תשלום בגין עבור כל שעת איחור: " + paymentPerOverHour;
            if (haveDeal)
                tmp += "\n\nהחוזה נכנס לתוקף החל מתאריך: " + startDeal.ToString("dd/mm/yyyy") + "." ;
            else
                tmp += "\n\nהחוזה עדיין לא נכנס לתוקף.";

            return base.ToString();
        }
    }

}
