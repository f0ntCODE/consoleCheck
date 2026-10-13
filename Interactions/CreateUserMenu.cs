using System;
using consoleCheck.Persistence;
using task;

namespace consoleCheck.Interactions;

public class CreateUserMenu
{
    private TaskPersistence taskPersistence = new TaskPersistence();
    public static void NewToDo()
    {

        string? toDoName = "";
        string? toDoDescr = "";

        Console.WriteLine("Type the todo name: ");
        toDoName = Console.ReadLine();

        Console.WriteLine("Type a todo description: ");
        toDoDescr = Console.ReadLine();



    }

    private ToDo createToDo(string toDoName, string toDoDescr)
    {
        ToDo todo = new ToDo(toDoName, toDoDescr);

        taskPersistence.saveTask(todo);

        return todo;

    }
}
