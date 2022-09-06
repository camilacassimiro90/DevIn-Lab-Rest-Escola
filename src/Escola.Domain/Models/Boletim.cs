using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Domain.Models
{
  public class Boletim
  {
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid AlunoId { get; set; }
    public virtual Aluno Aluno { get; set; }
    public IList<NotasMateria> Notas { get; set; }
  }
}