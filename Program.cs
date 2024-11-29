namespace Task_Exception
{
    public class Program
    {
        static void Main(string[] args)
        {

            try
            {
                
                Rooms room1 = new Rooms("Luxury Suite", 150, 3);
                Rooms room2 = new Rooms("Economy Room", 50, 1);

                
                Hotel hotel = new Hotel("Comfort Hotel");

                
                hotel.AddRoom(room1);
                hotel.AddRoom(room2);

                

                Console.WriteLine("Add a new rooms.");
                Console.WriteLine("-----");
                room1.ShowInfo();
                Console.WriteLine("-----------------------");
                room2.ShowInfo();

                
                Console.WriteLine("\nFirst room reservation-1");
                try
                {
                    hotel.MakeReservation(1); 
                    Console.WriteLine("first room is reserved.");
                }
                catch (NotAvailableException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

               
                Console.WriteLine("\nReservation first room again-1");
                try
                {
                    hotel.MakeReservation(1); 
                }
                catch (NotAvailableException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

               
                Console.WriteLine("\nattempt add a room 3 (not a have this room)");
                try
                {
                    hotel.MakeReservation(3); 
                }
                catch (NotAvailableException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}");
            }

        }
    }
}


