using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface Idal
    {
        //
        void addNanny(BE.Nanny nanny);
        void removeNanny(BE.Nanny nanny);
        void updateNanny(BE.Nanny nanny);

        void addMother(BE.Mother mother);
        void removeMother(BE.Mother mother);
        void updateMother(BE.Mother mother);

        void addChild(BE.Child child);
        void removeChild(BE.Child child);
        void updateChild(BE.Child child);

        List<BE.Nanny> nannysList();
        List<BE.Mother> mothersList();
        List<BE.Child> childrensList();
        List<BE.Contract> contractsList();
    }
}
