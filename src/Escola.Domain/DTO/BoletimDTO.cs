using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola.Domain.Models;


namespace Escola.Domain.DTO
{

  public class BoletimDTO
  {
    public Guid AlunoId { get; set; }
    public BoletimDTO()
    {

    }
    public BoletimDTO(Boletim boletim)
    {
      AlunoId = boletim.AlunoId;

    }
  }
}