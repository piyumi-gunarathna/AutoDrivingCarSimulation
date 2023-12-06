
using AutoDrivingCarSimulation.Application.DTOs;
using AutoDrivingCarSimulation.Application.Services;
using AutoDrivingCarSimulation.ConsoleApp;
using AutoDrivingCarSimulation.Shared;

do
{
    try
    {
        var fieldDTO = InputOutputHandler.GetFieldDimensions();
        var carDTO = InputOutputHandler.GetCarInitialPosition();

        if (fieldDTO != null && carDTO != null)
        {
            AutoDrivingService autoDrivingService = new AutoDrivingService(carDTO, fieldDTO);

            string commands = InputOutputHandler.GetCommandInput();
            autoDrivingService.ProcessCommands(commands);

            CarDTO movedCarInfo = autoDrivingService.GetCarStatus();
            InputOutputHandler.DisplayFinalPosition(movedCarInfo);
        }
        Console.WriteLine(Constants.DO_YOU_WANT_RESTART);

    }
    catch (Exception ex)
    {
        Console.WriteLine(Constants.ERROR_OCCURD + ex.Message);
    }
}
while (Console.ReadLine()?.ToUpper() == Constants.YES_RESTART);
