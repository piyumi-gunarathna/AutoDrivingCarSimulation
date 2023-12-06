﻿
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


    public const string DO_YOU_WANT_RESTART = "Do you want to restart? (Y/N)";
    public const string ERROR_OCCURD = "An error occurred: ";
    public const string YES_RESTART = "Y";
    public const string INVALID_INPUT = "Invalid input.";
    public const string ENTER_CAR_STATUS = "Enter car's initial position (X Y Direction):";
    public const string ENTER_COMMANDS = "Enter commands:";
}

