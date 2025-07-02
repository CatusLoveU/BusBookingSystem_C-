using BookingBus.Models;

namespace BusBookingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[]
            {
                new XeGheNgoi("51A-12345", "Nguyen Van A", "TPHCM - Da Lat", new DateTime(2025, 7, 2, 8, 0, 0), 20),
                new XeGiuongNam("51B-67890", "Tran Van B", "TPHCM - Nha Trang", new DateTime(2025, 7, 2, 9, 0, 0), 30)
            };

            vehicles[1].BookSeat(4);
            vehicles[0].BookSeat(7);
            vehicles[0].BookSeat(8);


            bool running = true;

            while (running)
            {
                Console.WriteLine("\n========== MENU ==========");
                Console.WriteLine("1. Xem danh sach xe");
                Console.WriteLine("2. Dat ve");
                Console.WriteLine("3. Huy ve");
                Console.WriteLine("4. Xem so ghe trong");
                Console.WriteLine("0. Thoat");
                Console.Write("Chon chuc nang: ");
                string choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1":
                        for (int i = 0; i < vehicles.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {vehicles[i].LicensePlate} - {vehicles[i].Route} - Gio di: {vehicles[i].DepartureTime}");
                        }
                        break;

                    case "2":
                        Console.Write("Chon so xe (1 hoac 2): ");
                        int xeDat = int.Parse(Console.ReadLine()!) - 1;
                        Console.Write("Nhap so ghe muon dat: ");
                        int soGhe = int.Parse(Console.ReadLine()!);
                        Console.Write("Nhap ten hanh khach: ");
                        string tenKhach = Console.ReadLine()!;
                        if (vehicles[xeDat].BookSeat(soGhe))
                        {
                            Console.WriteLine("Dat ve thanh cong \n");
                            vehicles[xeDat].PrintAvailableSeats(soGhe, tenKhach);
                        }
                        else Console.WriteLine("❌ Ghe da duoc dat hoac thong tin khong hop le \n");
                        break;

                    case "3":
                        Console.Write("Chon so xe (1 hoac 2): ");
                        int xeHuy = int.Parse(Console.ReadLine()!) - 1;
                        Console.Write("Nhap so ghe muon huy: ");
                        int gheHuy = int.Parse(Console.ReadLine()!);
                        if (vehicles[xeHuy].CancelSeat(gheHuy))
                            Console.WriteLine("Huy ve thanh cong");
                        else
                            Console.WriteLine("Ghe chua duoc dat hoac sai thong tin \n");
                        break;

                    case "4":
                        for (int i = 0; i < vehicles.Length; i++)
                        {
                            Console.WriteLine($"Xe {vehicles[i].LicensePlate}: con {vehicles[i].GetAvailableSeatsCount()} ghe trong. \n");
                        }
                        break;

                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            }

            Console.WriteLine("Ket thuc chuong trinh.");
        }
    }
}