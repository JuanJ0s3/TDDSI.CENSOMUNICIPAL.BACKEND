using TDDSI.CENSOMUNICIPAL.BACKEND.Domain.Entities;
using TDDSI.CENSOMUNICIPAL.BACKEND.Domain.Interfaces;

namespace TDDSI.CENSOMUNICIPAL.BACKEND.Application.Services;
public class CitizenService {
    private readonly ICitizenRepository _repository;

    public CitizenService( ICitizenRepository repository ) {
        _repository = repository;
    }

    public async Task AddCitizen( Citizen citizen ) {
        // Validaciones o lógica de negocio aquí
        if (citizen.Age < 0)
            throw new ArgumentException( "La edad no puede ser negativa." );
        await _repository.AddCitizenAsync( citizen );
    }

    public async Task<IEnumerable<Citizen>> GetAllCitizens() {
        return await _repository.GetAllCitizensAsync();
    }
}
