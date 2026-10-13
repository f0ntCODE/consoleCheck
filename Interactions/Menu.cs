namespace interaction
{
    public class Menu
    {
        public void MainMenu()
        {

            Console.WriteLine("""
         |WELLCOME TO THE
                        ULTIMATE CONSOLECHECK!|
         """);

            Console.WriteLine("""
                Choose an option below

                1) Create a task;
                2) List all tasks;
                3) Exit program;

            """);

            int option = GetUserInput();

            if (option == 1)
            {
                
            }
            else if (option == 2)
            {
                
            }
            else if (option == 3)
            {
                
            }

        }

        private static int GetUserInput()
        {

            while (true)
            {

                string? option = Console.ReadLine();

                int optionConverted = int.Parse(option);

                if (optionConverted <= 0 || optionConverted >= 4)
                {
                    Console.WriteLine("Invalid option. Try again\n");
                }
                else
                {
                 return optionConverted;   
                }
            }

        }
    }
}