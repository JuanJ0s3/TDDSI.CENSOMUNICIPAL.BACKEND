﻿using Microsoft.AspNetCore.Http;
using TDDSI.CENSOMUNICIPAL.BACKEND.Domain.Ports;

namespace TDDSI.CENSOMUNICIPAL.BACKEND.Infrastructure.PostgreSql.Adapters;
internal sealed class AuditContexService : IAuditContex {
    private readonly IHttpContextAccessor _httpContextAccessor;

    public AuditContexService( IHttpContextAccessor httpContextAccessor ) {
        _httpContextAccessor = httpContextAccessor;
    }

    public string? GetUserFromRecord() {
        string? name = _httpContextAccessor?.HttpContext?.User?.Identity?.Name;
        return name;
    }
}