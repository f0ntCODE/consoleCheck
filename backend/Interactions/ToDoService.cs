using System;
using consoleCheck.Persistence;
using task;

namespace consoleCheck.Interactions;

public class ToDoService
{
    private ToDoPersistence toDoPersistence = new ToDoPersistence();

    public void NewToDo()
    {

        string? toDoName = "";
        string? toDoDescr = "";

        Console.Write("Type the todo name -> ");
        toDoName = Console.ReadLine();

        Console.Write("Type a todo description -> ");
        toDoDescr = Console.ReadLine();

        createToDo(toDoName, toDoDescr);
    }

    public void listAllToDos()
    {
        List<ToDo> toDos = toDoPersistence.ListAll();

        Console.WriteLine("\t| SEE ALL YOU TODOS BELOW |\n\n");

        foreach (ToDo toDo in toDos)
        {
            Console.WriteLine(toDo.ToString() + "\n");
        }

        Console.WriteLine("\n\n");
    }

    /*
        private methods
    */
    private ToDo createToDo(string toDoName, string toDoDescr)
    {
        ToDo toDo = new ToDo(toDoName, toDoDescr);

        toDoPersistence.saveTask(toDo);

        return toDo;

    }
}
