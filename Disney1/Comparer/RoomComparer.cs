using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disney1.Comparer
{
    public class RoomComparer : IEqualityComparer<Room>
    {
        public bool Equals(Room x, Room y)
        {
            return x.RoomNo == y.RoomNo;
        }

        public int GetHashCode(Room obj)
        {
            return obj.RoomNo.GetHashCode();
        }
    }
}
