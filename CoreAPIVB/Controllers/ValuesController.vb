Imports Microsoft.AspNetCore.Mvc
Imports Microsoft.Extensions.Logging

Namespace Controllers

    Public Class ValuesController
        Inherits ControllerBase

        Private ReadOnly _logger As ILogger(Of WeatherForecastController)

        Public Sub New(logger As ILogger(Of WeatherForecastController))
            _logger = logger
        End Sub

    End Class

End Namespace