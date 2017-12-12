using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{/// <summary>
/// Two options of calculate.
/// 1. Calculate age, e.g the time that pass between the requested date and now.
/// 2. Calculate range, e.g. the range bewtween two requested date.
/// </summary>
    public class Age : IComparable
    {
        protected int Years;
        protected int Month;
        protected int Days;

        public Age(DateTime FirstDate, DateTime SecondDate = new DateTime())
        {
            TimeSpan tmp = SecondDate - FirstDate;
            int tmpCount = tmp.Days;

            Years = (tmpCount / 365);
            tmpCount = tmpCount % 365;
            Month = tmpCount / 30;
            tmpCount = tmpCount % 30;
            Days = tmpCount % 30;
        }

        public int CompareTo(object obj)
        {
            TimeSpan tmp = (TimeSpan)obj;
            return tmp.CompareTo(obj);
        }

        public override string ToString()
        {
            return "" + Years + "." + Month;
        }
    }
}
