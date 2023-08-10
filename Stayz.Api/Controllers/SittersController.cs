using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stayz.Api.Dtos;
using Stayz.Dal;
using Stayz.Domain.Abstractions.Repositories;
using Stayz.Domain.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Stayz.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SittersController : Controller
    {
        private readonly ISitterRepository _sitterRepo;
        private readonly IMapper _mapper;

        public SittersController(ISitterRepository repo, IMapper mapper)
        {
            _sitterRepo = repo;
            _mapper = mapper;
        }


        // GET: api/values
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<Sitter> GetAllSitters()
        {
            var sitters = await _sitterRepo.GetAllSittersAsync();
            //var sittersMapped = _mapper.Map<List<SitterDTO>>(sitters);
            //return Ok(sittersMapped);
            return new Sitter { };
        }

        // GET api/values/5
        [HttpGet]
        [Route("{id}")]
        public ActionResult<Sitter> GetSitterById(int id)
        {
            var sitter = _sitterRepo.GetSitterByIdAsync(id);

            if (sitter == null)
                return NotFound();

            //var sitterMapped = _mapper.Map<List<SitterDTO>>(sitters);
            //return Ok(sitterMapped);
            return Ok(sitter);
        }


        // POST api/values
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateSitter([FromBody]SitterCreateDto sitter)
        {
            var mappedSitter = _mapper.Map<Sitter>(sitter);
            await _sitterRepo.CreateSitterAsync(mappedSitter);

            var mappedDto = _mapper.Map<SitterGetDto>(mappedSitter); 

            return CreatedAtAction(nameof(GetSitterById), new { id = mappedSitter.Id }, mappedDto);
        }

        // PUT api/values/5
        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult> UpdateSitter(int id, [FromBody]SitterCreateDto updatedSitter)
        {
            var updateMapped = _mapper.Map<Sitter>(updatedSitter);
            updateMapped.id = id;

            await _sitterRepo.UpdateSitterAsync(updateMapped);

            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var sitter = await _sitterRepo.DeleteSitterAsync(id);

            if (sitter == null)
                return NotFound();

            return NoContent();
        }

        [HttpGet]
        [Route("{sitterId}/stays")]
        public async Task<ActionResult> ListSitterStays(int sitterId)
        {
            var stays = await _sitterRepo.GetSitterStayByIdAsync(id);
            var mappedStays = _mapper.Map<List<StayGetDto>>(stays);

            return Ok(mappedStays);
        }

        [HttpGet]
        [Route("{sitterId/stays/{stayId}")]
        public async Task<ActionResult> GetSitterStayById(int sitterId, int stayId)
        {
            var stay = await _sitterRepo.GetSitterStayByIdAsync(sitterId, stayId);
            var mappedStay = _mapper.Map<StayGetDto>(stay);

            return Ok(mappedStay);
        }

        [HttpPost]
        [Route("{sitterId}/stays")]
        public async Task<ActionResult> CreateSitterStay(int sitterId, [FromBody] StayCreateDto newStay)
        {
            var stay = _mapper.Map<Stay>(newStay);

            await _sitterRepo.CreateSitterStayAsync(sitterId, stay);

            var mappedStay = _mapper.Map<StayGetDto>(stay);

            return CreatedAtAction(nameof(GetSitterStayById), new { sitterId = sitterId, stayId = mappedStay.StayId }, mappedStay);
        }

        [HttpPut]
        [Route("{sitterId}/stays/{stayId}")]
        public async Task<ActionResult> UpdateSitterStay(int sitterId, int stayId, [FromBody] StayCreateDto updatedStay)
        {
            var newStay = _mapper.Map<Stay>(updatedStay);
            newStay.StayId = stayId;
            newStay.SitterId = sitterId;

            await _sitterRepo.UpdateSitterStayAsync(sitterId, newStay);

            return NoContent();
        }

        [HttpDelete]
        [Route("{sitterId}/stays/{stayId}")]
        public async Task<ActionResult> DeleteStitterStay(int sitterId, int stayId)
        {
            var done = await _sitterRepo.DeleteSitterStayAsync(sitterId, stayId);

            if (done == null)
                return NotFound("Stay not found");

            return NoContent();
        }

    }
}

