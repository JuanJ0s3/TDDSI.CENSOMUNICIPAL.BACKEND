﻿using System;

namespace TDDSI.CENSOMUNICIPAL.BACKEND.Domain.Helpers;
public static class ConvertTimeHelpers {
    public static DateTime ZoneByIdPacificStandardTime( this DateTime creationDate ) {
        const string LOCALZONEID = "SA Pacific Standard Time";
        TimeZoneInfo localZone = TimeZoneInfo.FindSystemTimeZoneById( LOCALZONEID );

        return TimeZoneInfo.ConvertTime( creationDate, localZone );
    }
}
