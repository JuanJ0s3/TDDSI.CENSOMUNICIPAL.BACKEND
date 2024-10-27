﻿namespace TDDSI.CENSOMUNICIPAL.BACKEND.Domain.Ports;
public interface IJsonConfiguration {
    public TEntity DeserializeObject<TEntity>( string source );
    public string SerializeObject<TEntity>( TEntity source );
}
