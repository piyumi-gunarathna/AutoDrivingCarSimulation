using AutoDrivingCarSimulation.Application.DTOs;
using AutoDrivingCarSimulation.Application.Services;

namespace AutoDrivingCarSimulation.Tests.Application;

public class AutoDrivingServiceTests
{
    [Theory]
    [InlineData(1, 2, "N", "FFRFFFRRLF", 4, 3, "S")]
    public void AutoDrivingService_ProcessCommands_ShouldMoveCarCorrectly(
        int initialX,int initialY, string initialDirection, string commands,
        int expectedX, int expectedY, string expectedDirection)
    {
        // Arrange
        var carDto = new CarDTO { X = initialX, Y = initialY, Direction = initialDirection };
        var fieldDto = new FieldDTO { Width = 10, Height = 10 };
        var autoDrivingService = new AutoDrivingService(carDto, fieldDto);

        // Act
        autoDrivingService.ProcessCommands(commands);

        // Assert
        var movedCarInfo = autoDrivingService.GetCarStatus();
        Assert.Equal(expectedX, movedCarInfo.X);
        Assert.Equal(expectedY, movedCarInfo.Y);
        Assert.Equal(expectedDirection, movedCarInfo.Direction);
    }

    [Fact]
    public void AutoDrivingService_GetCar_ShouldReturnInitialCarInfo()
    {
        // Arrange
        var carDto = new CarDTO { X = 1, Y = 2, Direction = "N" };
        var fieldDto = new FieldDTO { Width = 10, Height = 10 };
        var autoDrivingService = new AutoDrivingService(carDto, fieldDto);

        // Act
        var carInfo = autoDrivingService.GetCarStatus();

        // Assert
        Assert.Equal(carDto.X, carInfo.X);
        Assert.Equal(carDto.Y, carInfo.Y);
        Assert.Equal(carDto.Direction, carInfo.Direction);
    }
}


