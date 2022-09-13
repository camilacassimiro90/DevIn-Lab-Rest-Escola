using System.Diagnostics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Escola.Domain.DTO;
using Escola.Domain.Interfaces.Services;
using Escola.Domain.Exceptions;

namespace Escola.Api.Controllers
{
  [Controller]
  [Route("api/[controller]")]

  public class BoletimController : ControllerBase
  {
    private readonly IBoletimServico _boletimServico;

    public BoletimController(IBoletimServico boletimServico)
    {
      _boletimServico = boletimServico;

    }

    [HttpGet("{id}")]
    public IActionResult ObterPorId(
      [FromRoute] int id)
    {
      try
      {
        return Ok(_boletimServico.ObterPorId(id));
      }
      catch
      {
        return StatusCode(StatusCodes.Status500InternalServerError);
      }
    }

    [HttpGet("~/api/alunos/{idaluno}/boletins")]
    public IActionResult ObterPorIdAluno(
      [FromRoute] Guid idAluno)
    {
      try
      {
        return Ok(_boletimServico.ObterPorIdAluno(idAluno));
      }
      catch
      {
        return StatusCode(StatusCodes.Status500InternalServerError);
      }
    }

    [HttpPost]
    public IActionResult Inserir(
      [FromBody] BoletimDTO boletim)
    {
      _boletimServico.Inserir(boletim);
      return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPut("{id}")]
    public IActionResult Atualizar(
      [FromRoute] int id,
      [FromBody] BoletimDTO boletim)
    {
      try
      {
        _boletimServico.Atualizar(boletim, id);
        return StatusCode(StatusCodes.Status201Created);
      }
      catch
      {
        return StatusCode(StatusCodes.Status500InternalServerError);
      }
    }

    [HttpDelete("{id}")]
    public IActionResult Excluir(
      [FromRoute] int id)
    {
      _boletimServico.Excluir(id);
      return StatusCode(StatusCodes.Status204NoContent);
    }



  }

}
