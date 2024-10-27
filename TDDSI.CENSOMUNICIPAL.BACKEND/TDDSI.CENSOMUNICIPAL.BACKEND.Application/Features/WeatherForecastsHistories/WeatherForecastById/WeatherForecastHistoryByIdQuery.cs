using TDDSI.CENSOMUNICIPAL.BACKEND.Application.Messaging;

namespace TDDSI.CENSOMUNICIPAL.BACKEND.Application.Features.WeatherForecastsHistories.WeatherForecastById;
public record WeatherForecastHistoryByIdQuery(
    Guid Id
) : IQuery<WeatherForecastHistoryByIdQueryResponse>;