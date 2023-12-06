using System;
namespace AutoDrivingCarSimulation.Domain.Exceptions;

public class AutoDrivingCarException : Exception
{
    public AutoDrivingCarException() : base()
    {
    }

    public AutoDrivingCarException(string message) : base(message)
    {
    }

    public AutoDrivingCarException(string message, Exception innerException) : base(message, innerException)
    {

    }
}
