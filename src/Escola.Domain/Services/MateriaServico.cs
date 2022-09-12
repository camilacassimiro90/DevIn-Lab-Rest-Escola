
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola.Domain.DTO;
using Escola.Domain.Interfaces.Services;
using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Models;
using Escola.Domain.Exceptions;


namespace Escola.Domain.Services
{
  public class MateriaServico : IMateriaServico
  {
    private readonly IMateriaRepositorio _materiaRepositorio;
    public MateriaServico(IMateriaRepositorio materiaRepositorio)
    {
      _materiaRepositorio = materiaRepositorio;
    }

    //VALIDAR SE JÁ EXISTE A MATÉRIA, CASO SIM, CONCLUIR A EXCLUSÃO
    public void Excluir(int id)
    {
      var materia = _materiaRepositorio.ObterPorId(id);
      _materiaRepositorio.Excluir(materia);
    }

  }

}