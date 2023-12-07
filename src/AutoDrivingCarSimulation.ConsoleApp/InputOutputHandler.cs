using AutoDrivingCarSimulation.Application.DTOs;
using AutoDrivingCarSimulation.Shared;

namespace AutoDrivingCarSimulation.ConsoleApp
{
    public static class InputOutputHandler
    {
        public static FieldDTO? GetFieldDimensions()
        {
            Console.WriteLine(Constants.ENTER_FIELD_DIMENSION);
            string[] fieldInput = ReadInput();

            if (fieldInput != null && fieldInput.Length == 2 &&
                int.TryParse(fieldInput[0], out int width) && int.TryParse(fieldInput[1], out int height))
            {
                return new FieldDTO { Height = height, Width = width };
            }
            else
            {
                Console.WriteLine(Constants.INVALID_INPUT);
                return null;
            }
        }

        public static CarDTO? GetCarInitialPosition()
        {
            Console.WriteLine(Constants.ENTER_CAR_STATUS);
            string[] carPositionAndDirection = ReadInput();

            if (carPositionAndDirection != null && carPositionAndDirection.Length == 3 &&
                int.TryParse(carPositionAndDirection[0], out int carX) && int.TryParse(carPositionAndDirection[1], out int carY))
            {
                string facingDirection = carPositionAndDirection[2];
                return new CarDTO { X = carX, Y = carY, Direction = facingDirection };
            }
            else
            {
                Console.WriteLine(Constants.INVALID_INPUT);
                return null;
            }
        }

        public static string GetCommandInput()
        {
            Console.WriteLine(Constants.ENTER_COMMANDS);
            return Console.ReadLine() ?? string.Empty;
        }

        public static void DisplayFinalPosition(CarDTO movedCarInfo)
        {
            if (movedCarInfo != null)
            {
                Console.WriteLine(Constants.CAR_STATUS_DETAILS);
                Console.WriteLine($"{movedCarInfo.X} {movedCarInfo.Y} {movedCarInfo.Direction}");
            }
        }

        private static string[] ReadInput()
        {
            return (Console.ReadLine() ?? string.Empty).Split(' ');
        }
    }
}
