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
            
            asdasd
        }
    }

}
