using System;
using System.Collections.Generic;

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

// Bridge Pattern
interface IDrawingAPI
{
    void DrawShape();
}

class DrawingAPI1 : IDrawingAPI
{
    public void DrawShape()
    {
        Console.WriteLine("Using DrawingAPI1 to draw");
    }
}

class DrawingAPI2 : IDrawingAPI
{
    public void DrawShape()
    {
        Console.WriteLine("Using DrawingAPI2 to draw");
    }
}

abstract class Shape
{
    protected IDrawingAPI drawingAPI;

    protected Shape(IDrawingAPI drawingAPI)
    {
        this.drawingAPI = drawingAPI;
    }

    public abstract void Draw();
}

class CircleShape : Shape
{
    public CircleShape(IDrawingAPI drawingAPI) : base(drawingAPI) { }

    public override void Draw()
    {
        Console.Write("Circle ");
        drawingAPI.DrawShape();
    }
}

// Composite Pattern
abstract class Graphic
{
    public abstract void Draw();
}

class CompositeGraphic : Graphic
{
    private List<Graphic> childGraphics = new List<Graphic>();

    public void Add(Graphic graphic)
    {
        childGraphics.Add(graphic);
    }

    public override void Draw()
    {
        Console.WriteLine("Composite:");
        foreach (var graphic in childGraphics)
        {
            graphic.Draw();
        }
    }
}

class Ellipse : Graphic
{
    public override void Draw()
    {
        Console.WriteLine("Ellipse");
    }
}

// Decorator Pattern
abstract class ShapeDecorator : IShape
{
    protected IShape decoratedShape;

    public ShapeDecorator(IShape decoratedShape)
    {
        this.decoratedShape = decoratedShape;
    }

    public virtual void Draw()
    {
        decoratedShape.Draw();
    }
}

class RedShapeDecorator : ShapeDecorator
{
    public RedShapeDecorator(IShape decoratedShape) : base(decoratedShape) { }

    public override void Draw()
    {
        decoratedShape.Draw();
        Console.WriteLine("Border Color: Red");
    }
}

class Program
{
    static void Main()
    {
        // Adapter Pattern
        IShape rectangle = new Rectangle();
        IShape circle = new Circle();
        IShape triangleAdapter = new TriangleAdapter(new Triangle());

        rectangle.Draw();
        circle.Draw();
        triangleAdapter.Draw();

        // Bridge Pattern
        IDrawingAPI api1 = new DrawingAPI1();
        IDrawingAPI api2 = new DrawingAPI2();

        Shape circleShape1 = new CircleShape(api1);
        Shape circleShape2 = new CircleShape(api2);

        circleShape1.Draw();
        circleShape2.Draw();

        // Composite Pattern
        var composite = new CompositeGraphic();
        composite.Add(new Ellipse());
        composite.Add(new Ellipse());

        composite.Draw();

        // Decorator Pattern
        IShape decoratedCircle = new RedShapeDecorator(circle);
        decoratedCircle.Draw();
    }
}
