//AS A CLASS LETS FIGURE OUT THE LOGIC
//DO WE NEED CHANGES BEFORE WE START?

class Program
{
    static void Main()
    {
        Calculators salCacl = new Calculators();

        decimal baseSalary = 0;
        string userChoice = "";
        bool loop = true;

        while (loop == true)
        {
            Console.WriteLine("Welcome to the salary calulator. Here are the menu options:");
            Console.WriteLine("Manager");
            Console.WriteLine("Developer");
            Console.WriteLine("Salesperson");
            Console.WriteLine("Default");
            Console.WriteLine("Exit");
            Console.WriteLine();

            Console.Write("Select a department role to calculate salary, or exit: ");
            userChoice = Console.ReadLine().ToLower();

            
            //if (decimal.TryParse(Console.ReadLine(), out decimal baseSalary)

            if (userChoice == "exit")
            {
                Console.WriteLine("Have a good day.");
                Environment.Exit(0);
            }

            Console.Write("Enter the base salary: ");

            try
            {
                baseSalary = Convert.ToDecimal(Console.ReadLine());
                if (baseSalary <= 0)
                {
                    Console.WriteLine("Please enter a number larger than 0");
                    Console.Clear();
                    continue;
                }
                else
                {
                    Console.WriteLine($"You entered {baseSalary}");
                    loop = false;
                    break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Enter a valid number");
                Console.Clear();
                continue;
            }

#region Switch Menu
            // Process the user's choice using a switch statement
            //switch (userChoice)
            //{
            //    case "1" or "manager":
            //        salCacl.CalculateSalary(baseSalary, "manager"); // Calls the function to calculate the Manager's salary
            //        break;
            //    case "2" or "developer":
            //        salCacl.CalculateSalary(baseSalary, "developer"); // Calls the function to calculate the Manager's salary
            //        break;
            //    case "3" or "salesperson":
            //        salCacl.CalculateSalary(baseSalary, "salesperson"); // Calls the function to calculate the Manager's salary
            //        break;
            //    case "4" or "default":
            //        Console.WriteLine("Exiting the program.");
            //        return; // Exits the program if the user chooses to exit
            //    default:
            //        Console.WriteLine("Invalid choice. Please select a valid option.");
            //        break;
            //}

            // 
#endregion


        }

        salCacl.CalculateSalary(baseSalary, userChoice);
    }


}

public class Calculators //Interface
{
    //0.2m, 0.1m, 0.15m
    protected decimal ManagerRate = 0.2m;
    protected decimal DeveloperRate = 0.1m; //Why we get paid less :'(
    protected decimal SalesRate = 0.15m;
    protected decimal DefaultRate = 0;
    // On second thought maybe we should use classes for roles that contain rates and name for editing the string

    //Red Opel Ino - Calcultor: ICalculators -> GELOS 
    //ROLES ? -> SOLID -> Decouple our roles

    public decimal CalculateSalary(decimal baseSalary, string userChoice)
    {
        decimal rate = 0;

        switch(userChoice)
        {
            case "manager":
                rate = ManagerRate;
                break;
            case "developer":
                rate = DeveloperRate;
                break;
            case "salesperson":
                rate = SalesRate;
                break;
            case "" or "default":
                rate = DefaultRate;
                break;
        }

        decimal totalSalary = baseSalary + (baseSalary * rate);
        Console.WriteLine($"Your salary is ${totalSalary}");
        return totalSalary;
    }


    /*public decimal CalculateManagerSalary()
    {
        Console.Write("Enter the manager's base salary: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal baseSalary))
        {
            // Calculate the total salary for a Manager with a 20% bonus
            decimal totalSalary = baseSalary + (baseSalary * 0.2m);
            Console.WriteLine($"Manager's total salary: {totalSalary:C}");
            return totalSalary;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid salary amount.");
        }
    }*/

    /*public decimal CalculateDeveloperSalary()
    {
        Console.Write("Enter the developer's base salary: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal baseSalary))
        {
            // Calculate the total salary for a Developer with a 10% bonus
            decimal totalSalary = baseSalary + (baseSalary * 0.1m);
            Console.WriteLine($"Developer's total salary: {totalSalary:C}");
            return totalSalary;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid salary amount.");
        }
    }

    public decimal CalculateSalespersonSalary()
    {
        Console.Write("Enter the salesperson's base salary: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal baseSalary))
        {
            // Calculate the total salary for a Salesperson with a 15% bonus
            decimal totalSalary = baseSalary + (baseSalary * 0.15m);
            Console.WriteLine($"Salesperson's total salary: {totalSalary:C}");
            return totalSalary;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid salary amount.");
        }
    }*/
}
