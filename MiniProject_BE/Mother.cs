using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class Mother:IComparable
    {
        public int Id { get; set; }
        public int PhoneNumber { get; set; }
        public int[,] RequiredSavingHours = new int[2, 6];

        string FirstName { get; set; }
        string LastName { get; set; }
        public string Address { get; set; }
        public string AddressLookingFor { get; set; }
        public string Notes { get; set; }

        bool[] requiredSavingDays /*days the mother looking for nanny*/ = new bool[6];

        public override string ToString()
        {
            return base.ToString();
        }

        public int CompareTo(object obj)
        {
            Mother tmp = obj as Mother;
            return Id.CompareTo(tmp.Id);
        }
    }
}
