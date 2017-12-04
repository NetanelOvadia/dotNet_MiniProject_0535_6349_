using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class Mother
    {
        int id, phoneNumber;

        string firstName, lastName, address, addressLookingFor;
        List<string> notes = new List<string>();

        bool[] requiredSavingDays /*days the mother looking for nanny*/ = new bool[6];

        float[,] requiredSavingHours = new float[2, 6];

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
