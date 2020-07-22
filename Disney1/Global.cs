using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disney1
{
    static class Global
    {
        public static Account User;

        public static Boolean isHotelManager(Group group)
        {
            if(group.GroupNo == 5 || group.GroupNo == 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
