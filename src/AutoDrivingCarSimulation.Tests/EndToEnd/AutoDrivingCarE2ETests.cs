using AutoDrivingCarSimulation.Shared;

namespace AutoDrivingCarSimulation.Tests.EndToEnd;

public class AutoDrivingCarE2ETests
{
    [Fact]
    public void TestEndToEndSimulation()
    {
        // Arrange
        string input = "10 10\n1 2 N\nFFRFFFRRLF\nNo";
        string expectedOutput = Constants.CAR_STATUS_DETAILS+"\n4 3 S";

        using (StringReader sr = new StringReader(input))
        {
            Console.SetIn(sr);
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            var entryPoint = typeof(Program).Assembly.EntryPoint!;
            entryPoint.Invoke(null, new object[] { Array.Empty<string>() });
            string consoleOutput = sw.ToString().Trim();

            // Assert
            Assert.Contains(expectedOutput, consoleOutput);
            Assert.Contains(Constants.DO_YOU_WANT_RESTART, consoleOutput);
            Assert.Contains(Constants.EXITING, consoleOutput);
        }
    }
}
