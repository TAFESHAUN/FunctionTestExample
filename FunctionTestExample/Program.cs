//AS A CLASS LETS FIGURE OUT THE LOGIC
//DO WE NEED CHANGES BEFORE WE START?

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Select a department role to calculate salary:");
            Console.WriteLine("1. Manager");
            Console.WriteLine("2. Developer");
            Console.WriteLine("3. Salesperson");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice (1-4): ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                // Process the user's choice using a switch statement
                switch (choice)
                {
                    case 1:
                        CalculateManagerSalary(); // Calls the function to calculate the Manager's salary
                        break;
                    case 2:
                        CalculateDeveloperSalary(); // Calls the function to calculate the Developer's salary
                        break;
                    case 3:
                        CalculateSalespersonSalary(); // Calls the function to calculate the Salesperson's salary
                        break;
                    case 4:
                        Console.WriteLine("Exiting the program.");
                        return; // Exits the program if the user chooses to exit
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }

    static void CalculateManagerSalary()
    {
        Console.Write("Enter the manager's base salary: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal baseSalary))
        {
            // Calculate the total salary for a Manager with a 20% bonus
            decimal totalSalary = baseSalary + (baseSalary * 0.2m);
            Console.WriteLine($"Manager's total salary: {totalSalary:C}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid salary amount.");
        }
    }

    static void CalculateDeveloperSalary()
    {
        Console.Write("Enter the developer's base salary: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal baseSalary))
        {
            // Calculate the total salary for a Developer with a 10% bonus
            decimal totalSalary = baseSalary + (baseSalary * 0.1m);
            Console.WriteLine($"Developer's total salary: {totalSalary:C}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid salary amount.");
        }
    }

    static void CalculateSalespersonSalary()
    {
        Console.Write("Enter the salesperson's base salary: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal baseSalary))
        {
            // Calculate the total salary for a Salesperson with a 15% bonus
            decimal totalSalary = baseSalary + (baseSalary * 0.15m);
            Console.WriteLine($"Salesperson's total salary: {totalSalary:C}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid salary amount.");
        }
    }
}
