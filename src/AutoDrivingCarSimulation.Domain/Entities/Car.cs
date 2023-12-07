using AutoDrivingCarSimulation.Domain.Exceptions;
using AutoDrivingCarSimulation.Domain.ValueObjects;
using AutoDrivingCarSimulation.Shared;

namespace AutoDrivingCarSimulation.Domain.Entities
{
    public class Car
    {
        public Coordinates Position { get; private set; }
        public Direction FacingDirection { get; private set; }

        public Car(int x, int y, Direction facingDirection)
        {
            ValidateInitialPosition(x, y);
            Position = new Coordinates(x, y);
            FacingDirection = facingDirection;
        }

        public void TurnLeft()
        {
            Rotate(-1);
        }

        public void TurnRight()
        {
            Rotate(1);
        }

        public void MoveForward(Field field)
        {
            Coordinates newPosition = CalculateNewPosition();
            Position = AdjustPosition(newPosition, field);
        }

        private void Rotate(int step)
        {
            int directionsCount = 4;
            int newDirectionValue = ((int)FacingDirection + directionsCount + step) % directionsCount;
            FacingDirection = (Direction)newDirectionValue;
        }

        private Coordinates CalculateNewPosition()
        {
            int newX = Position.X;
            int newY = Position.Y;

            switch (FacingDirection)
            {
                case Direction.North:
                    newY++;
                    break;
                case Direction.East:
                    newX++;
                    break;
                case Direction.South:
                    newY = newY > 0 ? newY - 1 : 0;
                    break;
                case Direction.West:
                    newX = newX > 0 ? newX - 1 : 0;
                    break;
                default:
                    throw new AutoDrivingCarException(Constants.INVALID_DIRECTION);
            }

            return new Coordinates(newX, newY);
        }

        private Coordinates AdjustPosition(Coordinates position, Field field)
        {
            int adjustedX = position.X >= field.Width ? field.Width - 1 : position.X;
            int adjustedY = position.Y >= field.Height ? field.Height - 1 : position.Y;

            return new Coordinates(adjustedX, adjustedY);
        }

        private void ValidateInitialPosition(int x, int y)
        {
            if (x < 0 || y < 0)
            {
                throw new AutoDrivingCarException(Constants.CAR_POSITION_ERROR);
            }
        }
    }
}
