using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Checkout_Simulator
{
   
    class Membership
    {
        private string MemberName;
        private int MemberIDNo;
        private string MemberPhone;
        private string MemberAddress;
        private int MemberPoints;

        public Membership(string Name, int IDNo, string Phone,string Address,int Points)
        {
            MemberName = Name;
            MemberIDNo = IDNo;
            MemberPhone = Phone;
            MemberAddress = Address;
            MemberPoints = Points;

        }
        public bool IsIDValid()
        {
            Random rng = new Random();
            if (rng.Next(0, 2) == 1)
            {
                return true;
            }
            else return false;
            
        }
        public string GetMemberName()
        {
            return MemberName;
        }
        public int GetMemberID()
        {
            return MemberIDNo;
        }
        public string GetMemberPhone()
        {
            return MemberPhone;
        }
        public string GetMemberAddress()
        {
            return MemberAddress;
        }
        public int GetPoints()
        {
            return MemberPoints;
        }
        public void AddPoints(int amount)
        {
            MemberPoints += amount;
        }
        
    }

}
