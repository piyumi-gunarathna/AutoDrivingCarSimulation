using AutoDrivingCarSimulation.Domain.ValueObjects;

namespace AutoDrivingCarSimulation.Domain.Entities;

public class Car
{
    public Coordinate Position { get; private set; }
    public Direction FacingDirection { get; private set; }

    public Car(int x, int y, Direction facingDirection)
    {
        Position = new Coordinate(x, y);
        FacingDirection = facingDirection;
    }

}

