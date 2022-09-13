using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.Domain.DTO;

namespace Escola.Domain.Models
{
  public class Boletim
  {
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid AlunoId { get; set; }
    public virtual Aluno Aluno { get; set; }
    public IList<NotasMateria> Notas { get; set; }
    public Boletim()
    {
    }

    public Boletim(BoletimDTO boletim)
    {
      AlunoId = boletim.AlunoId;

    }

    public void Update(BoletimDTO boletim)
    {
      AlunoId = boletim.AlunoId;
    }

  }

}