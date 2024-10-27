using TDDSI.CENSOMUNICIPAL.BACKEND.Application.Messaging;

namespace TDDSI.CENSOMUNICIPAL.BACKEND.Application.Features.WeatherForecasts.Events.NotifyWeatherForecastCreated;
public record NotifyWeatherForecastCreatedCommand(
    string Proccess
) : INotify;
