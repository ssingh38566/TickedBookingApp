// See https://aka.ms/new-console-template for more information
using TickedBookingApp.Models;

Console.WriteLine("Hello, World!");
BookingAppDriver driver = new BookingAppDriver();
driver.Initialize();
driver.CreateBooking("Raipur", "Bahubali");
Console.Read();