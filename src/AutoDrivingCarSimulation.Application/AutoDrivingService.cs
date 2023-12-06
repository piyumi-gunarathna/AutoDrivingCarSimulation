using AutoDrivingCarSimulation.Application.DTOs;
using AutoDrivingCarSimulation.Domain.Entities;
using AutoDrivingCarSimulation.Domain.ValueObjects;
using AutoDrivingCarSimulation.Shared;

namespace AutoDrivingCarSimulation.Application.Services;

public class AutoDrivingService
{
    private readonly Field _field;
    private readonly Car _car;
    private static readonly Dictionary<string, Direction> directionMap = new Dictionary<string, Direction>
        {
            { Constants.DIRECTION_NORTH, Direction.North },
            { Constants.DIRECTION_EAST, Direction.East },
            { Constants.DIRECTION_SOUTH, Direction.South },
            { Constants.DIRECTION_WEST, Direction.West }
        };

    public AutoDrivingService(CarDTO car, FieldDTO field)
    {
        _car = new Car(car.X, car.Y, directionMap[car.Direction]);
        _field = new Field(field.Hight, field.Width);

    }

    public void ProcessCommands(string commands)
    {
        foreach (char command in commands)
        {
            switch ((Commands)command)
            {
                case Commands.Forward:
                    _car.MoveForward(_field);
                    break;
                case Commands.Left:
                    _car.TurnLeft();
                    break;
                case Commands.Right:
                    _car.TurnRight();
                    break;
            }
        }
    }

    public CarDTO GetCarStatus()
    {
        var facingDirection = directionMap.FirstOrDefault(x => x.Value == _car.FacingDirection).Key;

        return new CarDTO
        {
            X = _car.Position.X,
            Y = _car.Position.Y,
            Direction = facingDirection
        };
    }

}
