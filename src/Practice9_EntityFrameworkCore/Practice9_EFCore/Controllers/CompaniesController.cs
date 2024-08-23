using Microsoft.AspNetCore.Mvc;
using Practice9_EFCore.Contracts;
using Practice9_EFCore.Domain.Models;
using Practice9_EFCore.Domain.Repositories;
using Practice9_EFCore.Infrastructure.Repositories;
using Practice9_EFCore.Services;


namespace Practice9_EFCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompaniesController : ControllerBase
    {
        private readonly ICompaniesService _service;

        public CompaniesController(ICompaniesService service)
        {
            _service = service;
        }

        [HttpGet("by-building/{buildingId:guid}")]
        public async Task<ActionResult<List<CompaniesResponse>>> GetByBuilding(Guid buildingId)
        {
            var companies = await _service.GetByBuilding(buildingId);
            var response = companies.Select(c => new CompaniesResponse(c.Id, c.Name, c.Phones, c.Building, c.Rubrics));
            return Ok(response);
        }

        [HttpGet("by-rubric/{rubricId:guid}")]
        public async Task<ActionResult<List<CompaniesResponse>>> GetByRubric(Guid rubricId)
        {
            var companies = await _service.GetByRubric(rubricId);
            var response = companies.Select(c => new CompaniesResponse(c.Id, c.Name, c.Phones, c.Building, c.Rubrics));
            return Ok(response);
        }

        [HttpGet("by-id/{id:guid}")]
        public async Task<ActionResult<CompaniesResponse>> GetById(Guid id)
        {
            var company = await _service.GetById(id);
            return company == null ? NotFound() : Ok(new CompaniesResponse(company.Id, company.Name, company.Phones, company.Building, company.Rubrics));
        }

        [HttpGet("by-name/{name}")]
        public async Task<ActionResult<CompaniesResponse>> GetByName(string name)
        {
            var company = await _service.GetByName(name);
            return company == null ? NotFound() : Ok(new CompaniesResponse(company.Id, company.Name, company.Phones, company.Building, company.Rubrics));
        }

        [HttpGet("in-radius/{radius:double}/{xCenter:double}/{yCenter:double}")]
        public async Task<ActionResult<List<CompaniesResponse>>> GetInRadius(double radius, double xCenter, double yCenter)
        {
            var companies = await _service.GetInRadius(radius, xCenter, yCenter);
            var response = companies.Select(c => new CompaniesResponse(c.Id, c.Name, c.Phones, c.Building, c.Rubrics));
            return Ok(response);
        }

        [HttpGet("in-rectangle/{xLeft:double}/{yLeft:double}/{xRight:double}/{yRight:double}")]
        public async Task<ActionResult<List<CompaniesResponse>>> GetInRectangle(double xLeft, double yLeft, double xRight, double yRight)
        {
            var companies = await _service.GetInRectangle(xLeft, yLeft, xRight, yRight);
            var response = companies.Select(c => new CompaniesResponse(c.Id, c.Name, c.Phones, c.Building, c.Rubrics));
            return Ok(response);
        }

        [HttpGet("by-innerRubrics/{rubricId:guid}")]
        public async Task<ActionResult<List<CompaniesResponse>>> GetByInnerRubrics(Guid rubricId)
        {
            var companies = await _service.GetByInnerRubrics(rubricId);
            var response = companies.Select(c => new CompaniesResponse(c.Id, c.Name, c.Phones, c.Building, c.Rubrics));
            return Ok(response);
        }
    }
}
