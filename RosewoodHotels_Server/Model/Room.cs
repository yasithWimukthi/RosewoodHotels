using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RosewoodHotels_Server.Model
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomName { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
    }
}
