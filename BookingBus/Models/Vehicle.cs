using BookingBus.Interfaces;

namespace BookingBus.Models
{
    public class Vehicle : IBookable
    {
        public string LicensePlate { get; set; }
        public string DriverName { get; set; }
        public string Route { get; set; }
        public DateTime DepartureTime { get; set; }

        protected bool[] Seats;

        public Vehicle(string licensePlate, string driverName, string route, DateTime departureTime, int seats)
        {
            LicensePlate = licensePlate;
            DriverName = driverName;
            Route = route;
            DepartureTime = departureTime;
            Seats = new bool[seats];
        }

        public virtual bool BookSeat(int seatNumber)
        {
            if (seatNumber < 0 || seatNumber > Seats.Length || Seats[seatNumber]) return false;
            Seats[seatNumber] = true;
            return true;
        }
        public virtual bool BookSeats()
        {
            for (int i = 0; i < Seats.Length; i++)
            {
                if (!Seats[i])
                {
                    Seats[i] = true;
                    return true;
                }
            }
            return true;
        }

        public virtual bool CancelSeat(int seatNumber)
        {
            if (seatNumber < 0 | seatNumber > Seats.Length || !Seats[seatNumber]) return false;
            Seats[seatNumber] = false;
            return true;
        }

        public virtual void PrintAvailableSeats(int seatNumber, string customerName)
        {
            Console.WriteLine($"--- HÓA ĐƠN ---\nKhách: {customerName}\nXe: {LicensePlate}\nGhế: {seatNumber}\nLái xe: {DriverName}\nTuyến: {Route}\nGiờ khởi hành: {DepartureTime} \n");
        }
        public virtual int GetAvailableSeatsCount()
        {
            int count = 0;
            foreach (var seat in Seats)
            {
                if (!seat)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
