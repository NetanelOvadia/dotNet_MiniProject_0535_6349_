using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class Child
    {
        int id, mothersId;

        string firstName, lastName, birthDate;
        List<string> specialNeeds = new List<string>();

        bool isSpecialNeeds;
    }
}
