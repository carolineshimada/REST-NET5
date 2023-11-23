using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using RestApiNet5.Model;
using RestApiNet5.Services.Implementations;

namespace RestApiNet5.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase
{

    private readonly ILogger<PersonController> _logger;
    private IPersonService _personService;

    public PersonController(ILogger<PersonController> logger, IPersonService personService)
    {
        _logger = logger;
        _personService = personService;

    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_personService.FindAll());  
    }

    [HttpGet("{id}")]
    public IActionResult GetById([Required] long? id)
    {
        if (!id.HasValue)
        {
            return BadRequest("ID não fornecido");
        }

        var person = _personService.FindById(id.Value);
        if (person == null)
        {
            return NotFound("Pessoa não encontrada");
        }

        return Ok(person);
    }

    [HttpPost]
    public IActionResult Create([FromBody]Person person)
    {
        if(person == null)
        {
            BadRequest("Reveja os dados inseridos");
        }
        return Ok(_personService.Create(person));
    }

    [HttpPut]
    public IActionResult Put([FromBody] Person person)
    {
        if (person == null)
        return BadRequest("Pessoa não encontrada");
        return Ok(_personService.Update(person));
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(long id)
    {
        _personService.Delete(id);
        return NoContent();
    }
}
 