using Microsoft.EntityFrameworkCore;
using TDDSI.CENSOMUNICIPAL.BACKEND.Domain.Entities;
using TDDSI.CENSOMUNICIPAL.BACKEND.Domain.Interfaces;

namespace TDDSI.CENSOMUNICIPAL.BACKEND.Infrastructure.Repositories {
    public class CitizenRepository : ICitizenRepository {
        private readonly AppBContext _context;

        public CitizenRepository( AppBContext context ) {
            _context = context;
        }

        public async Task AddCitizenAsync( Citizen citizen ) {
            await _context.Citizens.AddAsync( citizen );
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Citizen>> GetAllCitizensAsync() {
            return await _context.Citizens.ToListAsync();
        }
    }
}
