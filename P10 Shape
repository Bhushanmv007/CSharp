using System;

class Shape 

{ 

 public virtual void Draw() => Console.WriteLine("Drawing a generic shape");

 public virtual void Erase() => Console.WriteLine("Erasing a generic shape");

} 

class Circle : Shape 

{ 

 public override void Draw() => Console.WriteLine("Drawing a circle");

 public override void Erase() => Console.WriteLine("Erasing a circle");

} 

class Triangle : Shape 

{ 

 public override void Draw() => Console.WriteLine("Drawing a triangle");

 public override void Erase() => Console.WriteLine("Erasing a triangle");

} 

class Square : Shape 

{ 

 public override void Draw() => Console.WriteLine("Drawing a square");

 public override void Erase() => Console.WriteLine("Erasing a square");

} 

class Program 

{ 

 static void Main() 

 { 

 DisplayShapeDetails(new Circle());

 DisplayShapeDetails(new Triangle());

 DisplayShapeDetails(new Square());
} 

 static void DisplayShapeDetails(Shape shape) 

 { 

 Console.WriteLine("Shape Details:");

 shape.Draw();

 shape.Erase();

 Console.WriteLine();

 } 

}
