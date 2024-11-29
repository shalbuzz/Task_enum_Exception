using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Exception
{
    public class Rooms
    {
        private static int _id;
        
        public int Id { get; }

        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }

        public bool IsAvailable { get; set; } = true;
            
            
             

        public void ShowInfo() {

            Console.WriteLine($"Room ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Person Capacity: {PersonCapacity}");
            Console.WriteLine($"Is Available: {IsAvailable}");
        }

        public override string ToString()
        {
            ShowInfo();
            return "";
        }
        public Rooms(string name, double price, int personCapacity )
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name boş ola bilməz.");
            if (price <= 0)
                throw new ArgumentException("Price 0-dan böyük olmalıdır.");
            if (personCapacity <= 0)
                throw new ArgumentException("PersonCapacity 0-dan böyük olmalıdır.");
            Id = ++_id;
            Name = name ; 
            Price = price ;
            PersonCapacity = personCapacity ;
        }
    }
}
