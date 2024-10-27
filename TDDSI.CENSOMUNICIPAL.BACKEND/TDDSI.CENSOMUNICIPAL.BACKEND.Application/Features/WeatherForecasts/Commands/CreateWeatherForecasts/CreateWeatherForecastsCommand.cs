using TDDSI.CENSOMUNICIPAL.BACKEND.Application.Messaging;

namespace TDDSI.CENSOMUNICIPAL.BACKEND.Application.Features.WeatherForecasts.Commands.CreateWeatherForecasts;
public record CreateWeatherForecastsCommand(
    ) : ICommand<CreateWeatherForecastsResponse>;
