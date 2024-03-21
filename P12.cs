using System;

// Define the Resizable interface 
interface Resizable 
{ 
    void ResizeWidth(int width);
    void ResizeHeight(int height);
} 

// Implement the Resizable interface in the Rectangle class 
class Rectangle : Resizable 
{ 
    private int width;
    private int height;

    public Rectangle(int width, int height) 
    { 
        this.width = width;
        this.height = height;
    } 

    public void ResizeWidth(int newWidth) 
    {
        width = newWidth;
        Console.WriteLine($"Width resized to: {width}");
    } 

    public void ResizeHeight(int newHeight) 
    { 
        height = newHeight;
        Console.WriteLine($"Height resized to: {height}");
    } 

    public void DisplayDimensions() 
    { 
        Console.WriteLine($"Rectangle Dimensions - Width: {width}, Height: {height}");
    } 
} 

class Program 
{ 
    static void Main() 
    { 
        // Create an instance of the Rectangle class 
        Rectangle rectangle = new Rectangle(10, 5);

        // Display original dimensions 
        Console.WriteLine("Original Dimensions:");
        rectangle.DisplayDimensions();

        // Resize width and height 
        rectangle.ResizeWidth(15);
        rectangle.ResizeHeight(8);

        // Display updated dimensions 
        Console.WriteLine("\nUpdated Dimensions:");
        rectangle.DisplayDimensions();
    } 
}
