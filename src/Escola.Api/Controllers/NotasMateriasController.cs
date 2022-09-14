using Escola.Domain.DTO;
using Escola.Domain.Interfaces.Services;
using Escola.Domain.Models;
using Escola.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Api.Controllers
{
  [Controller]
  [Route("api/[controller]")]
  public class NotasMateriasController : ControllerBase
  {
    private readonly INotasMateriaServico _notasMateriaServico;

    public NotasMateriasController(INotasMateriaServico notasMateriaServico)
    {
      _notasMateriaServico = notasMateriaServico;
    }

    [HttpGet("{id}")]
    public IActionResult ObterPorId(
       [FromRoute] int id)
    {
      try
      {
        return Ok(_notasMateriaServico.ObterPorId(id));
      }
      catch
      {

        return StatusCode(StatusCodes.Status500InternalServerError);
      }
    }

    [HttpGet("~/api/alunos/{idAluno}/boletins/{idBoletim}/NotasMateria")]//~anular controller base
    public IActionResult ObterPorBoletim(
        [FromRoute] int boletimId)
    {
      try
      {
        return Ok(_notasMateriaServico.ObterPorBoletim(boletimId));
      }
      catch
      {
        return StatusCode(StatusCodes.Status500InternalServerError);
      }

    }

  }

}