using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class Child : IComparable
    {
        public int Id { get; set; }
        public int MothersId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SpecialNeeds { get; set; }

        public DateTime birthDate;

        public Age age;

        bool isSpecialNeeds;

        Child()
        {

            age = new Age(birthDate);
        }
        public int CompareTo(object obj)
        {
            Child tmp = obj as Child;
            return Id.CompareTo(tmp.Id);
        }
    }
}
