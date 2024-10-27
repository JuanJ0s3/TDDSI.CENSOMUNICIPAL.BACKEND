namespace TDDSI.CENSOMUNICIPAL.BACKEND.Domain.Abstractions;
public interface IEntityBase<T> {
    T Id { get; init; }
}
