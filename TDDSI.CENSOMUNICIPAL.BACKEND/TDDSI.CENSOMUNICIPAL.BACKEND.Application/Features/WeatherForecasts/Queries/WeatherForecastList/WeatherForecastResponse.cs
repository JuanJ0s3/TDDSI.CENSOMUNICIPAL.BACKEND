using TDDSI.CENSOMUNICIPAL.BACKEND.Domain.WeatherForecasts.Dtos;

namespace TDDSI.CENSOMUNICIPAL.BACKEND.Application.Features.WeatherForecasts.Queries.WeatherForecastList;
public record WeatherForecastResponse(
    IEnumerable<WeatherForecastDto> WeatherForecasts
);
