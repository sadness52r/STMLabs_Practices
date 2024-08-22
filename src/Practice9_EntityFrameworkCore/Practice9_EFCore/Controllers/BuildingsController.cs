using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practice9_EFCore.Contracts;
using Practice9_EFCore.Domain.Models;
using Practice9_EFCore.Domain.Repositories;
using Practice9_EFCore.Services;

namespace Practice9_EFCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuildingsController : ControllerBase
    {
        private readonly IBuildingsService _service;

        public BuildingsController(IBuildingsService service)
        {
            _service = service;
        }

        // GET: api/Buildings
        [HttpGet]
        public async Task<ActionResult<List<BuildingsResponse>>> GetBuildings()
        {
            var buildings = await _service.GetAllBuildingsAsync();
            var response = buildings.Select(b => new BuildingsResponse(b.Id, b.Address, b.XPosition, b.YPosition));
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateBuidling([FromBody] BuildingsRequest request)
        {
            var buildingId = await _service.Add(Guid.NewGuid(), request.Address, request.XPosition, request.YPosition);
            return Ok(buildingId);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<Guid>> UpdateBuidling(Guid id, [FromBody] BuildingsRequest request)
        {
            var buidlingId = await _service.Update(id, request.Address, request.XPosition, request.YPosition);
            return Ok(buidlingId);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<Guid>> DeleteBuidling(Guid id)
        {
            return Ok(await _service.Delete(id));
        }

        //// GET: api/Buildings/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<BuildingEntity>> GetBuildingEntity(Guid id)
        //{
        //    var buildingEntity = await _context.Buildings.FindAsync(id);

        //    if (buildingEntity == null)
        //    {
        //        return NotFound();
        //    }

        //    return buildingEntity;
        //}

        //// PUT: api/Buildings/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutBuildingEntity(Guid id, BuildingEntity buildingEntity)
        //{
        //    if (id != buildingEntity.Id)
        //    {
        //        return BadRequest();
        //    }

        //    try
        //    {
        //        await _service.Update(id, buildingEntity.Address, buildingEntity.XPosition, buildingEntity.YPosition);
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!BuildingEntityExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Buildings
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<BuildingEntity>> PostBuildingEntity(Guid id, string address, double xPos, double yPos)
        //{
        //    await _service.Add(id, address, xPos, yPos);
        //    return CreatedAtAction("GetBuildingEntity", new { id = buildingEntity.Id }, buildingEntity);
        //}

        //// DELETE: api/Buildings/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteBuildingEntity(Guid id)
        //{
        //    var buildingEntity = await _context.Buildings.FindAsync(id);
        //    if (buildingEntity == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Buildings.Remove(buildingEntity);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool BuildingEntityExists(Guid id)
        //{
        //    return _context.Buildings.Any(e => e.Id == id);
        //}
    }
}
