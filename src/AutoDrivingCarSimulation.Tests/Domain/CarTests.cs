using AutoDrivingCarSimulation.Domain.Entities;
using AutoDrivingCarSimulation.Domain.Exceptions;
using AutoDrivingCarSimulation.Domain.ValueObjects;

namespace AutoDrivingCarSimulation.Tests.Domain;

public class CarTests
{
    [Fact]
    public void Car_TurnLeft_ShouldChangeDirection()
    {
        // Arrange
        Car car = new Car(0, 0, Direction.North);

        // Act
        car.TurnLeft();

        // Assert
        Assert.Equal(Direction.West, car.FacingDirection);
    }

    [Fact]
    public void Car_TurnRight_ShouldChangeDirection()
    {
        // Arrange
        Car car = new Car(0, 0, Direction.North);

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
        Car car = new Car(initialX, initialY, direction);
        Field field = new Field(10, 10);

        // Act
        car.MoveForward(field);

        // Assert
        Assert.Equal(expectedX, car.Position.X);
        Assert.Equal(expectedY, car.Position.Y);
    }

    [Fact]
    public void Car_MoveForward_ShouldNotMove_WhenInitialPositionYIsZeroAndDirectionIsSouth()
    {
        // Arrange
        Car car = new Car(2, 0, Direction.South);
        Field field = new Field(10, 10);

        // Act
        car.MoveForward(field);

        // Assert
        Assert.Equal(0, car.Position?.Y);
    }

    [Fact]
    public void Car_MoveForward_ShouldNotMove_WhenInitialPositionXIsZeroAndDirectionIsWest()
    {
        // Arrange
        var car = new Car(0, 1, Direction.West);
        var field = new Field(10, 10);

        // Act
        car.MoveForward(field);

        // Assert
        Assert.Equal(0, car.Position?.X);
    }

    [Fact]
    public void Car_MoveForward_ShouldNotMove_WhenNewPositionExceedsFieldWidth()
    {
        // Arrange
        Car car = new Car(9, 1, Direction.South);
        Field field = new Field(10, 10);

        // Act
        car.MoveForward(field);

        // Assert
        Assert.Equal(9, car.Position?.X);
    }

    [Fact]
    public void Car_MoveForward_ShouldNotMove_WhenNewPositionExceedsFieldHeight()
    {
        // Arrange
        Car car = new Car(6, 9, Direction.North);
        Field field = new Field(10, 10);

        // Act
        car.MoveForward(field);

        // Assert
        Assert.Equal(9, car.Position?.Y);
    }

    [Fact]
    public void Car_CreateInstance_ShouldThrowException_WhenCoordinatesAreNegative()
    {
        // Act & Assert
        Assert.Throws<AutoDrivingCarException>(() => new Car(-1, -3, Direction.North));
    }
}
