namespace FlightReservationSystemProject;

public class TutorialMenu
{
    public const string RESET = "\u001B[0m";
    public const string YELLOW = "\u001B[33m";
    public const string GREEN = "\u001B[32m";
    public const string CYAN = "\u001B[36m";

    public void Show()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine(YELLOW + "  ╔════════════════════════════════════════════╗");
        Console.WriteLine("  ║               System Tutorial              ║");
        Console.WriteLine("  ╚════════════════════════════════════════════╝" + RESET);
        Console.WriteLine();

        Console.WriteLine(CYAN + "Welcome to the Extreme Flight Reservation System!" + RESET);
        Console.WriteLine("\nThis is a console-based application designed to simulate a basic flight reservation system.");
        Console.WriteLine("Data is stored in plain text files and organized through a menu-based interface.");
        Console.WriteLine();

        Console.WriteLine(GREEN + "Features & Navigation:" + RESET);

        Console.WriteLine(CYAN + "\n1. Customers Menu" + RESET);
        Console.WriteLine("  - Add a customer with first name, last name, and phone number.");
        Console.WriteLine("  - View all customers currently saved.");
        Console.WriteLine("  - Delete a customer *only if they have no active bookings*.");

        Console.WriteLine(CYAN + "\n2. Flights Menu" + RESET);
        Console.WriteLine("  - Add a flight using flight number, origin, destination, and max seats (40–850).");
        Console.WriteLine("  - View all available flights or search for a flight by number.");
        Console.WriteLine("  - Delete a flight *only if no passengers are booked on it*.");

        Console.WriteLine(CYAN + "\n3. Bookings Menu" + RESET);
        Console.WriteLine("  - Book a flight by entering a valid customer ID and flight number.");
        Console.WriteLine("  - Each customer can only book one flight within a 1-hour window.");
        Console.WriteLine("  - View all bookings including customer ID, flight number, and booking timestamp.");
        Console.WriteLine("  - Cancel bookings, which will also decrement both flight and customer counters.");

        Console.WriteLine(CYAN + "\n4. Exit" + RESET);
        Console.WriteLine("  - Exits the program after confirmation.");
        
        Console.WriteLine();
        Console.WriteLine(GREEN + "Technical Notes:" + RESET);
        Console.WriteLine("  - All data is stored in: customers.txt, flights.txt, bookings.txt");
        Console.WriteLine("  - Inputs are validated for correctness (e.g., names, phone numbers, flight/passenger limits).");

        Console.WriteLine(CYAN + "\nPress any key to return to the main menu..." + RESET);
        Console.ReadKey();
    }
}
