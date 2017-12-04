using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class Contract 
    {
        static int counter=00000000;
        int id, nannysId, childrensId;

        bool haveMeeting, haveDeal, isContractByHour;

        float paymentPerHour, paymentPerMonth;

        string startDate, endDate;

        Contract()
        {
            id = counter++;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

}
