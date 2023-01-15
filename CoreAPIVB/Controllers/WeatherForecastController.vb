Imports Microsoft.AspNetCore.Mvc
Imports Microsoft.Extensions.Logging

Namespace Controllers

    <ApiController>
    <Route("[controller]")>
    Public Class WeatherForecastController
        Inherits ControllerBase
        Private Shared ReadOnly Summaries As String() = {"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"}

        Private ReadOnly _logger As ILogger(Of WeatherForecastController)

        Public Sub New(logger As ILogger(Of WeatherForecastController))
            _logger = logger
        End Sub

        <HttpGet("GetWeatherForecast")>
        Public Function [Get]() As IEnumerable(Of WeatherForecast)
            _logger.LogInformation("Get the weather")
            Return Enumerable.Range(1, 5).[Select](Function(index) New WeatherForecast With {
                    .[Date] = DateOnly.FromDateTime(Date.Now.AddDays(index)),
                    .TemperatureC = Random.[Shared].[Next](-20, 55),
                    .Summary = Summaries(Random.[Shared].[Next](Summaries.Length))
            }).ToArray()
        End Function

        <HttpPost("PostWeatherForecast")>
        Public Sub Post(name As String)
            _logger.LogWarning("Hi, {Name}", name)
        End Sub

    End Class

End Namespace