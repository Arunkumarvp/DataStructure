using System;

class Stack
{
    private int[] elements; // Array to store stack elements
    private int top;        // Index of the top element
    private int max;        // Maximum size of the stack

    public Stack(int size)
    {
        elements = new int[size]; // Initialize the stack with a fixed size
        top = -1;                 // Stack is initially empty
        max = size;
    }

    // Push operation to add an element to the stack
    public void Push(int data)
    {
        if (top == max - 1)
        {
            Console.WriteLine("Stack Overflow");
        }
        else
        {
            elements[++top] = data; // Increment top and add element
        }
    }

    // Pop operation to remove the top element from the stack
    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack Underflow");
            return -1; // Return -1 for underflow condition
        }
        else
        {
            return elements[top--]; // Return top element and decrement top
        }
    }

    // Peek operation to view the top element without removing it
    public int Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty");
            return -1;
        }
        else
        {
            return elements[top]; // Return the top element
        }
    }

    // Method to check if the stack is empty
    public bool IsEmpty()
    {
        return top == -1;
    }

    // Method to check if the stack is full
    public bool IsFull()
    {
        return top == max - 1;
    }

    // Method to display the stack elements
    public void Display()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty");
            return;
        }

        for (int i = top; i >= 0; i--)
        {
            Console.WriteLine(elements[i]);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Stack stack = new Stack(5); // Create a stack of size 5

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine("Stack elements:");
        stack.Display(); // Display stack contents

        Console.WriteLine($"Top element is: {stack.Peek()}");

        Console.WriteLine($"Popped element: {stack.Pop()}");

        Console.WriteLine("Stack after pop:");
        stack.Display();
    }
}
