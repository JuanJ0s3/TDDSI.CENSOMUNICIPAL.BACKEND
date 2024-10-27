using TDDSI.CENSOMUNICIPAL.BACKEND.Application.Messaging;

namespace TDDSI.CENSOMUNICIPAL.BACKEND.Application.Features.WeatherForecasts.Queries.WeatherForecastList;
public record WeatherForecastQuery(
) : IQuery<WeatherForecastResponse>;
