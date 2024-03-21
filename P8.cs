using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        CustomStack stack = new CustomStack();
        Console.WriteLine("Welcome to the Stack Program!");

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Push an element onto the stack");
            Console.WriteLine("2. Pop an element from the stack");
            Console.WriteLine("3. Print the current stack");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter an element to push onto the stack: ");
                    string element = Console.ReadLine();
                    stack.Push(element);
                    break;
                case "2":
                    stack.Pop();
                    break;
                case "3":
                    stack.PrintStack();
                    break;
                case "4":
                    Console.WriteLine("Exiting the program. Thank you!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }
        }
    }
}

class CustomStack
{
    private Stack<object> stack = new Stack<object>();

    public void Push(object item)
    {
        stack.Push(item);
        Console.WriteLine($"Pushed '{item}' onto the stack.");
    }

    public object Pop()
    {
        if (stack.Count == 0)
        {
            Console.WriteLine("Stack Underflow. Cannot pop from an empty stack.");
            return null;
        }

        object poppedItem = stack.Pop();
        Console.WriteLine($"Popped '{poppedItem}' from the stack.");
        return poppedItem;
    }

    public void PrintStack()
    {
        if (stack.Count == 0)
        {
            Console.WriteLine("Stack is empty.");
        }
        else
        {
            Console.Write("Current stack: ");
            foreach (var item in stack)
            {
                Console.Write("'" + item + "' ");
            }
            Console.WriteLine();
        }
    }
}
