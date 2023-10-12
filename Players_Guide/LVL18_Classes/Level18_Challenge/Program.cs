// Challenge Vin Fletcher's Arrows

/*
Objectives:
• Define a new Arrow class with fields for arrowhead type, fletching type, and length. (Hint:
arrowhead types and fletching types might be good enumerations.)
• Allow a user to pick the arrowhead, fletching type, and length and then create a new Arrow instance.
• Add a GetCost method that returns its cost as a float based on the numbers above, and use this
to display the arrow’s cost.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

Arrow arrow = new Arrow( Arrow.ArrowHeadType.Steel, 80, Arrow.FletchingType.Goose);

Console.WriteLine(arrow.GetCost());
class Arrow
{
    public enum ArrowHeadType { Steel, Wood, Obsidian }
    public enum FletchingType { Plastic, Turkey, Goose}

    public ArrowHeadType _arrowHead;
    public float _shaft = 0;
    public FletchingType _fletch;

    public Arrow()
    { 
        // Default Constructor
    }

    public Arrow(ArrowHeadType arrowHead, float shaft, FletchingType fletching)
    {
        _arrowHead = arrowHead;
        _shaft = shaft;
        _fletch = fletching;
    }

    public float GetCost()
    {
        float arrowCost = 0;
        float shaftCost = (float)(_shaft * 0.05);
        float fletchCost = 0;

        if (_arrowHead == ArrowHeadType.Steel)
        {
            arrowCost = 10;
        }
        else if (_arrowHead == ArrowHeadType.Obsidian)
        {
            arrowCost = 5;
        }
        else if (_arrowHead == ArrowHeadType.Wood)
        {
            arrowCost = 3;
        }

        if (_fletch == FletchingType.Plastic)
        {
            fletchCost = 10;
        }
        else if (_fletch == FletchingType.Turkey)
        {
            fletchCost = 5;
        }
        else if (_fletch == FletchingType.Goose)
        {
            fletchCost = 3;
        }
        return arrowCost + shaftCost + fletchCost;
    }

}