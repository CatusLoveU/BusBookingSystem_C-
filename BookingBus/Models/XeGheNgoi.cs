namespace BookingBus.Models
{
    public class XeGheNgoi : Vehicle
    {
        public XeGheNgoi(string licensePlate, string driverName, string route, DateTime departureTime, int seats)
          : base(licensePlate, driverName, route, departureTime, seats)
        {
        }
    }
}
