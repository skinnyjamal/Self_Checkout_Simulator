using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Checkout_Simulator
{
    class MembershipDAO
    {
        private static List<Membership> Members = new List<Membership>
        {
            
            new Membership("Joe Bloggs", 001, "013576887890", " 10 Downing Street",63),
            new Membership("John Doe",002,"07544332689", "1 tipsy lane", 150),
            new Membership("Jane Doe",003,"05647345237", "9 broad Street", 75),
            new Membership("Mehmet Ozcan",004,"95533567424","3 lecturer way", 149), 
        };

        public static Membership SearchUsingIDNo(int ID)
        {
            return Members.Find(p => p.GetMemberID() == ID);
        }


    }
}
