using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDSI.CENSOMUNICIPAL.BACKEND.Domain.Entities;

namespace TDDSI.CENSOMUNICIPAL.BACKEND.Domain.Interfaces;
public interface ICitizenRepository {
    Task AddCitizenAsync( Citizen citizen );
    Task<IEnumerable<Citizen>> GetAllCitizensAsync();
}
