using consoleCheck.Interactions;

namespace interaction
{
    public class Menu
    {
        private ToDoService service = new ToDoService();
        public void MainMenu()
        {

            while (true)
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
                    service.NewToDo();
                }
                else if (option == 2)
                {
                    service.listAllToDos();
                }
                else if (option == 3)
                {
                    break;
                }

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