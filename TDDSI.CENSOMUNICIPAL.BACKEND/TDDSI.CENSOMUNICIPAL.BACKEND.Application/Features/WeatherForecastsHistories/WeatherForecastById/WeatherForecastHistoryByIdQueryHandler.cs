using TDDSI.CENSOMUNICIPAL.BACKEND.Application.Messaging;
using TDDSI.CENSOMUNICIPAL.BACKEND.Domain.Abstractions;
using TDDSI.CENSOMUNICIPAL.BACKEND.Domain.Ports;
using TDDSI.CENSOMUNICIPAL.BACKEND.Domain.WeatherForecasts.Dtos;
using TDDSI.CENSOMUNICIPAL.BACKEND.Domain.WeatherForecastsHistories;

namespace TDDSI.CENSOMUNICIPAL.BACKEND.Application.Features.WeatherForecastsHistories.WeatherForecastById;
internal sealed record class WeatherForecastHistoryByIdQueryHandler(
          WeatherForecastsHistoryService WeatherForecastsHistoryService
        , IJsonConfiguration JsonConfiguration
    ) : IQueryHandler<WeatherForecastHistoryByIdQuery, WeatherForecastHistoryByIdQueryResponse> {

    public async Task<Result<WeatherForecastHistoryByIdQueryResponse>> Handle(
          WeatherForecastHistoryByIdQuery request
        , CancellationToken cancellationToken
    ) {
        var history = await WeatherForecastsHistoryService.GetByAsync(
              request.Id
            , cancellationToken
        );

        var result = new WeatherForecastHistoryByIdQueryResponse(
            history.Id
            , JsonConfiguration.DeserializeObject<WeatherForecastByIdDto>( history.Proccess! )
            , history.CreatedDate
            , history.CreatedByUser
            , history.LastModifiedDate
            , history.LastModifiedByUser
        );

        return result;
    }
}
