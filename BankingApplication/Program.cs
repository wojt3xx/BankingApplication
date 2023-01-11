

namespace BankingApplication
{
    class Program
    {
        private static List<Customers> customers = new List<Customers>();

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***********************************");
            Console.WriteLine("******* Banking Application *******");
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;

            string userSelection;

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("********************");
                Console.WriteLine("* Select an action *");
                Console.WriteLine("********************");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("1: Register a customer");
                Console.WriteLine("2: List all customers");
                Console.WriteLine("3: List customer details");
                Console.WriteLine("4: Add funds to the customer");
                Console.WriteLine("5: Remove funds from the customer");
                Console.WriteLine("9: Quit application");

                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case "1":
                        RegisterCustomer();
                        break;
                    case "2":
                        ListAllCustomers();
                        break;
                    case "3":
                        ListCustomerDetails();
                        break;
                    case "4":
                        AddFunds();
                        break;
                    case "5":
                        RemoveFunds();
                        break;
                    case "9": break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                }
            }
            while (userSelection != "9");

            Console.WriteLine("Thanks for using the application");
            Console.Read();

        }
        private static void RegisterCustomer()
        {
            Console.WriteLine("Creating a customer");
            Console.WriteLine("Enter the first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter the last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter the email address: ");
            string email = Console.ReadLine();

            Console.WriteLine("Enter the phone number: ");
            int phoneNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the money amount customer has: ");
            int moneyAmount = int.Parse(Console.ReadLine());


            Customers customer = new Customers(firstName, lastName, email, phoneNumber, moneyAmount);
            customers.Add(customer);

            Console.WriteLine("Employee created!\n\n");
        }

        private static void ListAllCustomers()
        {
            Console.WriteLine("Listing all the customers");
            for (int i = 1; i <= customers.Count; i++)
            {
                Console.Write($"Customer number: {i - 1}");
                Console.WriteLine($"First name: {customers[i - 1].FirstName}");
                Console.WriteLine($"Last name:  {customers[i - 1].LastName}");
                Console.WriteLine($"Email:  {customers[i - 1].Email}");
                Console.WriteLine($"Phone number:  {customers[i - 1].PhoneNumber}");
                Console.WriteLine($"Money amount:  {customers[i - 1].MoneyAmount}");
                Console.WriteLine("----------------------------------------------");
            }
        }

        private static void ListCustomerDetails()
        {

        }

        private static void AddFunds()
        {

        }

        private static void RemoveFunds()
        {

        }
    }
}