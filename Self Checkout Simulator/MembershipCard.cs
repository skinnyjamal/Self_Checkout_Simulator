using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Checkout_Simulator
{
    class MembershipCard
    {
        
        private int MemberIDNo;

         public Membership GetRandomMemberID()
        {
            Random rng = new Random();
            MemberIDNo = rng.Next(1, 5);
             return MembershipDAO.SearchUsingIDNo(MemberIDNo);
        }
    }


    
}
