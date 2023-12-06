namespace AutoDrivingCarSimulation.Domain.Entities;

public class Field
{
    public int Width { get; }
    public int Height { get; }

    public Field(int width, int height)
    {
        if (width <= 0 || height <= 0)
        {
            throw new ArgumentException("Field dimensions must be positive integers.");
        }

        Width = width;
        Height = height;
    }
}

