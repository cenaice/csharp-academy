// LEVEL 20 PROPERTIES

/* SPEEDRUN
 
 * Properties give you field-like access while still protecting data with methods: public float
Width { get => width; set => width = value; }. To use a property: rectangle.Width
= 3;

 * Auto-properties are for when no extra logic is needed: public float Width { get; set; }
 
 * Properties can be read-only, only settable in a constructor: public float Width { get; }
 
 * Fields can also be read-only: private readonly float _width = 3;
 
 * With properties, objects can be initialized using initalizer syntax: new Rectangle() { Width = 2, Height = 3}
 
 * An init accessor is like a setter but only usable in object initializer syntax. public float Width {get; init;}
 */



/*  We can get the benefits of both information hiding and abstraction while keeping our code simple:
    PROPERTIES!:
    A property pairs a getter and setter under a shared name with field-like access.
 
 */

public class Rectangle
{
    private float _width;
    private float _height;

    public Rectangle(float width, float height)
    {
        _width = width;
        _height = height;
    }
    public float Width
    {
        get => _width;
        set => _width = value;
    }
    public float Height
    {
        get => _height;
        set => _height = value;
    }

}


// Auto-Implemented Properties

