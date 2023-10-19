// OOP Principle #2: Information Hiding- Only the object itself should directly access its data.

public class Rectangle
{
    // By giving it a private keyword, it gives private accessibility, only usable within the class itself.
    private float _width;
    private float _height;
    private float _area;
    // By making our fields private, the outside world cannot directly interfere with these variables.
    public Rectangle(float width, float height, float area)
    {
        // Constructor
        _width = width;
        _height = height;
        _area = area;
    }

    public float GetWidth() => _width;
    public float GetHeight() => _height;
    public float GetArea() => _area;
    public void SetWidth(float value)
    {
        _width = value;
        _area = _width * _height;
    }
    public void SetHeight(float value)
    {
        _height = value;
        _area = _width * _height;
    }
}