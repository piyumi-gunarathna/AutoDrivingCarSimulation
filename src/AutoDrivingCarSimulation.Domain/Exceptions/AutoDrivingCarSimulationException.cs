using System;
namespace AutoDrivingCarSimulation.Domain.Exceptions;

public class AutoDrivingCarSimulationException: Exception
{
    public AutoDrivingCarSimulationException() : base()
    {
    }

    public AutoDrivingCarSimulationException(string message) : base(message)
    {
    }

    public AutoDrivingCarSimulationException(string message, Exception innerException) : base(message, innerException)
    {

    }
}
