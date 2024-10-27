using TDDSI.CENSOMUNICIPAL.BACKEND.Application.Messaging;
using TDDSI.CENSOMUNICIPAL.BACKEND.Domain.Abstractions;
using TDDSI.CENSOMUNICIPAL.BACKEND.Domain.WeatherForecasts;
using TDDSI.CENSOMUNICIPAL.BACKEND.Domain.WeatherForecasts.Dtos;

namespace TDDSI.CENSOMUNICIPAL.BACKEND.Application.Features.WeatherForecasts.Queries.WeatherForecastList;
internal sealed class WeatherForecastQueryHandler(
        WeatherForecastService forecastService
    ) : IQueryHandler<WeatherForecastQuery, WeatherForecastResponse> {

    public async Task<Result<WeatherForecastResponse>> Handle( WeatherForecastQuery request
        , CancellationToken cancellationToken
    ) {

        IEnumerable<WeatherForecastDto> weatherForecasts = await forecastService.WeatherForecastsAsync();
        return new WeatherForecastResponse( weatherForecasts );
    }
}
