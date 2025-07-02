namespace BookingBus.Interfaces
{
    public interface IBookable
    {
        bool BookSeat(int seatNumber);
        bool BookSeats();
        bool CancelSeat(int seatNumber);
        void PrintAvailableSeats(int seatNumber, string customerName);
        int GetAvailableSeatsCount();
    }
}
