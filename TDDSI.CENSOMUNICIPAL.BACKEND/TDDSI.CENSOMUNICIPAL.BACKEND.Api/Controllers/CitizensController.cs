using Microsoft.AspNetCore.Mvc;
using TDDSI.CENSOMUNICIPAL.BACKEND.Application.Services;
using TDDSI.CENSOMUNICIPAL.BACKEND.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TDDSI.CENSOMUNICIPAL.BACKEND.Api.Controllers;
[Route( "api/[controller]" )]
[ApiController]
public class CitizensController : ControllerBase {
    private readonly CitizenService _service;

    public CitizensController( CitizenService service ) {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> AddCitizen( [FromBody] Citizen citizen ) {
        await _service.AddCitizen( citizen );
        return Ok( "Citizen added successfully." );
    }

    [HttpGet]
    public async Task<IActionResult> GetAllCitizens() {
        var citizens = await _service.GetAllCitizens();
        return Ok( citizens );
    }
}
