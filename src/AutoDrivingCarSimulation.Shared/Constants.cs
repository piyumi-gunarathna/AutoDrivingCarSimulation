
using System.Diagnostics.Metrics;

namespace AutoDrivingCarSimulation.Shared;

public static class Constants
{
    public const string DIRECTION_NORTH = "N";
    public const string DIRECTION_EAST = "E";
    public const string DIRECTION_SOUTH = "S";
    public const string DIRECTION_WEST = "W";

    public const char COMMAND_LEFT = 'L';
    public const char COMMAND_RIGHT = 'R';
    public const char COMMAND_FORWARD = 'F';


    public const string DO_YOU_WANT_RESTART = "\nDo you want to restart? (Y/N)";
    public const string ERROR_OCCURD = "An error occurred: ";
    public const string YES_RESTART = "Y";
    public const string INVALID_INPUT = "Invalid input.";
    public const string ENTER_CAR_STATUS = "Enter car's initial position (X Y Direction):";
    public const string ENTER_FIELD_DIMENTION = "Enter field dimentions (Width Height):";
    public const string ENTER_COMMANDS = "Enter commands:";
    public const string CAR_STATUS_DETAILS = "Car postion and Direction:";
    public const string EXITING = "Exiting";


    public const string FIELD_DIMENSTION_ERROR = "Field dimensions must be positive.";
    public const string CAR_POSITION_ERROR = "X, Y cordinates must be positive.";
    public const string INVALID_DIRECTION = "Invalid direction";
}

