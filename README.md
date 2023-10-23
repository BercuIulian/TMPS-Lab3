# Structural Design Patterns


## Author: Bercu Iulian

----

## Objectives:

* Study and understand the Structural Design Patterns.

* As a continuation of the previous laboratory work, think about the functionalities that your system will need to provide to the user.

* Implement some additional functionalities, or create a new project using structural design patterns.


## Used Design Patterns: 

* Adapter Pattern
* Bridge Pattern
* Composite Pattern
* Decorator Pattern


## Implementation

The Adapter pattern is used to adapt the Triangle class to the IShape interface using the TriangleAdapter.

The Bridge pattern separates the Shape abstraction from the IDrawingAPI implementation, allowing different drawing APIs to be used with different shapes.

The Composite pattern is used to create a composite graphic that can contain other graphics, allowing you to treat individual and composite graphics uniformly.

The Decorator pattern is used to add a border color to a shape, where RedShapeDecorator decorates a shape with a red border.


* Snippets from my files.


```
// Adapter Pattern
interface IShape
{
    void Draw();
}

class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Rectangle");
    }
}

class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }
}

class Triangle
{
    public void Display()
    {
        Console.WriteLine("Displaying a Triangle");
    }
}

class TriangleAdapter : IShape
{
    private Triangle triangle;

    public TriangleAdapter(Triangle triangle)
    {
        this.triangle = triangle;
    }

    public void Draw()
    {
        triangle.Display();
    }
}

```


## Conclusions / Screenshots / Results

In this C# project, we've successfully implemented four structural design patterns: Adapter, Bridge, Composite, and Decorator. These patterns allow us to adapt, separate, compose, and decorate objects, respectively, providing a flexible and modular approach to design and development. Each pattern serves a specific purpose in enhancing code structure and maintainability.


* The result of running the program

  ![image](https://github.com/BercuIulian/TMPS-Lab3/assets/113422203/c61051fc-f409-4e04-899a-3e4e43b39cab)


