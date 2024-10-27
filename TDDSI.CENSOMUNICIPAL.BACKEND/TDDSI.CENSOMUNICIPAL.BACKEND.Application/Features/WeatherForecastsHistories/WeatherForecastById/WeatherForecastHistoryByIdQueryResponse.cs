using TDDSI.CENSOMUNICIPAL.BACKEND.Domain.WeatherForecasts.Dtos;

namespace TDDSI.CENSOMUNICIPAL.BACKEND.Application.Features.WeatherForecastsHistories.WeatherForecastById;
public record WeatherForecastHistoryByIdQueryResponse(
      Guid Id
    , WeatherForecastByIdDto? Proccess
    , DateOnly? CreatedDate
    , string? CreatedByUser
    , DateOnly? LastModifiedDate
    , string? LastModifiedByUser
);
