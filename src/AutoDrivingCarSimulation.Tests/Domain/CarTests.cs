using AutoDrivingCarSimulation.Domain.Entities;
using AutoDrivingCarSimulation.Domain.ValueObjects;

namespace AutoDrivingCarSimulation.Tests.Domain;

public class CarTests
{
    [Fact]
    public void Car_TurnLeft_ShouldChangeDirection()
    {
        // Arrange
        var car = new Car(0, 0, Direction.North);

        // Act
        car.TurnLeft();

        // Assert
        Assert.Equal(Direction.West, car.FacingDirection);
    }

    [Fact]
    public void Car_TurnRight_ShouldChangeDirection()
    {
        // Arrange
        var car = new Car(0, 0, Direction.North);

        // Act
        car.TurnRight();

        // Assert
        Assert.Equal(Direction.East, car.FacingDirection);
    }

    [Theory]
    [InlineData(Direction.North, 0, 0, 0, 1)] 
    [InlineData(Direction.East, 0, 0, 1, 0)]  
    public void Car_MoveForward_ShouldChangePosition(Direction direction, int initialX, int initialY, int expectedX, int expectedY)
    {
        // Arrange
        var car = new Car(initialX, initialY, direction);
        var field = new Field(10, 10); 

        // Act
        car.MoveForward(field);

        // Assert
        Assert.Equal(expectedX, car.Position.X);
        Assert.Equal(expectedY, car.Position.Y);
    }
}


