
using ShapeMaster.Domain.Entities;
using ShapeMaster.Infrastructure.Services;
using System.Drawing;

Circle circle1 = new()
{
    Radius = 3,
};

Rectangle rectangle1 = new() //rectangleyi neden çağıramadığını sor
{

};

Square square1 = new()
{ OneSide = 5

};

Triangle triangle1 = new()
{
    TSide = 5,
    Fside = 9,
    Base = 7.5,
    Height = 10,
};

NotepadService notepadService = new();
notepadService.SaveToNotpad(square1);
