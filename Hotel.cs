using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Exception
{
    public class Hotel
    {
        public string Name { get; set; }
        private Rooms[] _rooms = new Rooms[0];
        

    
        
        public void AddRoom(Rooms room)
        {
            Array.Resize(ref _rooms, _rooms.Length+1);
            _rooms[_rooms.Length-1] = room;
        }

        public Hotel(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Hotel adı boş ola bilməz.");
            Name = name;
          
        }

        public void  MakeReservation(int? roomId)
        {
           
            if (roomId == null)
            {
                throw new NullReferenceException("roomId null ola bilmez.");
            }




            Rooms room = null;
            foreach (var r in _rooms)
            {
                if (r.Id == roomId)
                {
                    room = r;
                    break;
                }
            }

            if (room == null)
            {
                throw new NotAvailableException($"Room ID {roomId} tapilmadi.");
            }
            if (!room.IsAvailable)
            {
                throw new NotAvailableException ($"Room ID {roomId} rezervasiya ucun movcud deyil.");

            }

              room.IsAvailable = false;


        }
    }
}
