namespace BookingBus.Models
{
    public class XeGiuongNam : Vehicle
    {
        public XeGiuongNam(string licensePlate, string driverName, string route, DateTime departureTime, int seats)
            : base(licensePlate, driverName, route, departureTime, seats)
        {
        }
    }
}
