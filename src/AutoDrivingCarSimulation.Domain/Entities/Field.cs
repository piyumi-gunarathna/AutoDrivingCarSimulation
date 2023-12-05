namespace AutoDrivingCarSimulation.Domain.Entities;

public class Field
{
    public int Width { get; private set; }
    public int Height { get; private set; }

    public Field(int width, int height)
    {
        Width = width;
        Height = height;
    }
}

