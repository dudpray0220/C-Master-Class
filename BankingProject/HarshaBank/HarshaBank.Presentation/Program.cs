class Program
{
    static void Main()
    {
        // display title
        System.Console.WriteLine("*****************Harsha Bank*****************");
        System.Console.WriteLine("::Login Page::");

        // declare variable userName, password
        string userName, password = null;

        //  read userName from keyboard
        System.Console.Write("userName: ");
        userName = System.Console.ReadLine();
        if (userName != "")
        {
            //  read password from keyboard
            System.Console.Write("password: ");
            password = System.Console.ReadLine();
        }

        // check userName and password
        if (userName == "system" && password == "manager")
        {
            // declare variable to store mainmenu choice
            int mainMenuChoice = -1;    // -1은 사용자가 선택 항목을 입력하지 않음을 나타냄. 0은 종료이므로.

            // do while loop
            do
            {
                System.Console.WriteLine("\n:::Main Menu:::");
                System.Console.WriteLine("1. Customers");
                System.Console.WriteLine("2. Accounts");
                System.Console.WriteLine("3. Funds Transfer");
                System.Console.WriteLine("4. Funds Transfer Statement");
                System.Console.WriteLine("5. Account Statement");
                System.Console.WriteLine("0. Exit");

                System.Console.Write("Enter: ");
                mainMenuChoice = int.Parse(System.Console.ReadLine());

                // switch case to check main menu
                switch (mainMenuChoice)
                {
                    case 1: CustomersMenu(); break;
                    case 2: AccountsMenu(); break;
                    case 3: break;
                    case 4: break;
                    case 5: break;
                    case 0: break;
                }
            } while (mainMenuChoice != 0);
        }
        else
        {
            System.Console.WriteLine("Invaild userName or password");
        }

        System.Console.WriteLine("\nThankyou! Visit Again");
        System.Console.ReadKey();
    }


    static void CustomersMenu()
    {
        // variable delcare
        int customerMenuChoice = -1;

        // do while loop
        do
        {
            System.Console.WriteLine("\n:::Customers Menu:::");
            System.Console.WriteLine("1. Add Customers");
            System.Console.WriteLine("2. Delete Customers");
            System.Console.WriteLine("3. Update Customers");
            System.Console.WriteLine("4. View Customers");
            System.Console.WriteLine("0. Back to Main Menu");

            System.Console.Write("Enter Choice: ");
            customerMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());  
        } while (customerMenuChoice != 0);
    }

    static void AccountsMenu()
    {
        // variable delcare
        int accountsMenuChoice = -1;

        // do while loop
        do
        {
            System.Console.WriteLine("\n:::Accounts Menu:::");
            System.Console.WriteLine("1. Add Accounts");
            System.Console.WriteLine("2. Delete Accounts");
            System.Console.WriteLine("3. Update Accounts");
            System.Console.WriteLine("4. View Accounts");
            System.Console.WriteLine("0. Back to Main Menu");

            System.Console.Write("Enter Choice: ");
            accountsMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());
        } while (accountsMenuChoice != 0);
    }
}