using AutoDrivingCarSimulation.Domain.Exceptions;
using AutoDrivingCarSimulation.Domain.ValueObjects;
using AutoDrivingCarSimulation.Shared;

namespace AutoDrivingCarSimulation.Domain.Entities;

public class Car
{
    public Coordinates Position { get; private set; }
    public Direction FacingDirection { get; private set; }

    public Car(int x, int y, Direction facingDirection)
    {
        if (x <= 0 || y <= 0)
        {
            throw new AutoDrivingCarSimulationException(Constants.CAR_POSITION_ERROR);
        }

        Position = new Coordinates(x, y);
        FacingDirection = facingDirection;
    }

    public void TurnLeft()
    {
        FacingDirection = (Direction)(((int)FacingDirection + 3) % 4);
    }

    public void TurnRight()
    {
        FacingDirection = (Direction)(((int)FacingDirection + 1) % 4);
    }

    public void MoveForward(Field field)
    {
        Coordinates newPosition = CalculateNewPosition();
        newPosition = AdjustPosition(newPosition, field);
        Position = newPosition;
    }

    private Coordinates CalculateNewPosition()
    {
        switch (FacingDirection)
        {
            case Direction.North:
                return new Coordinates(Position.X, Position.Y + 1);
            case Direction.East:
                return new Coordinates(Position.X + 1, Position.Y);
            case Direction.South:
                return new Coordinates(Position.X, Position.Y - 1);
            case Direction.West:
                return new Coordinates(Position.X - 1, Position.Y);
            default:
                throw new AutoDrivingCarSimulationException(Constants.INVALID_DIRECTION);
        }
    }

    private Coordinates AdjustPosition(Coordinates position, Field field)
    {
        if (position.X < 0)
            position.X = 0;
        else if (position.X >= field.Width)
            position.X = field.Width - 1;

        if (position.Y < 0)
            position.Y = 0;
        else if (position.Y >= field.Height)
            position.Y = field.Height - 1;
        return position;
    }
}

