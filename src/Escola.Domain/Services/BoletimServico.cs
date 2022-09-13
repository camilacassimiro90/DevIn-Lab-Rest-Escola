using Escola.Domain.DTO;
using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Interfaces.Services;
using Escola.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Domain.Services
{
  public class BoletimServico : Api.Controllers.IBoletimServico
  {
    private readonly IBoletimRepositorio _boletimRepositorio;

    public BoletimServico(IBoletimRepositorio boletimRepositorio)
    {
      _boletimRepositorio = boletimRepositorio;
    }

    public BoletimDTO ObterPorId(int id)
    {
      return new BoletimDTO(_boletimRepositorio.ObterPorId(id));
    }

    public IList<BoletimDTO> ObterPorIdAluno(Guid id)
    {
      return _boletimRepositorio.ObterPorIdAluno(id)
                                .Select(x => new BoletimDTO(x)).ToList();
    }

    public void Inserir(BoletimDTO boletim)
    {
      _boletimRepositorio.Inserir(new Boletim(boletim));
    }

    public void Atualizar(BoletimDTO boletim, int id)
    {
      var boletimDb = _boletimRepositorio.ObterPorId(id);
      if (boletimDb == null)
      {
        throw new Exception("Boletim não existe!");
      }
      boletimDb.Update(boletim);
      _boletimRepositorio.Atualizar(boletimDb);

    }

  }
}