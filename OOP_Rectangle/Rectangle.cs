namespace OOP_Rectangle;

public class Rectangle
{
    private double _height;
    private double _width;

    public double Height
    {

        get => _height;
        set
        {
            if (value <= 0) 
                throw new ArgumentException("Height must be greater than zero");
            _height = value;
            
        }
    }

    public double Width
    {
        get => _width;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Width must be greater than zero");
            _width = value;
        }
    }

    public Rectangle(double height, double width)
    {
        Width = width;
        Height = height;
    }

    public double GetArea() => Width * Height;

    public double GetPerimeter() => 2 * (Width + Height);

    public bool IsSquare() => Width == Height;
    
    public override string ToString() => $"Rectangle({Width} x {Height}) - Area: {GetArea()}, Perimeter: {GetPerimeter()}," +
                                         $" And it is {(IsSquare() ? "a square" : "a rectangle")}";
}
