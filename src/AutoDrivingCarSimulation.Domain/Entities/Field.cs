using AutoDrivingCarSimulation.Domain.Exceptions;
using AutoDrivingCarSimulation.Shared;

namespace AutoDrivingCarSimulation.Domain.Entities;

public class Field
{
    public int Width { get; }
    public int Height { get; }

    public Field(int width, int height)
    {
        if (width <= 0 || height <= 0)
        {
            throw new AutoDrivingCarSimulationException(Constants.FIELD_DIMENSTION_ERROR);
        }

        Width = width;
        Height = height;
    }
}

