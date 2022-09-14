using Escola.Domain.DTO;
using Escola.Domain.Exceptions;
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
  public class NotasMateriaServico : INotasMateriaServico
  {
    private readonly INotasMateriaRepositorio _notasMateriaRepositorio;

    public NotasMateriaServico(INotasMateriaRepositorio notasMateriaRepositorio)
    {
      _notasMateriaRepositorio = notasMateriaRepositorio;
    }

    public void AtualizarNotas(NotasMateriaDTO notasMateria)
    {
      var notasMateriaDB = _notasMateriaRepositorio.ObterPorId(notasMateria.Id);
      notasMateriaDB.Update(notasMateria);//vem da classe notasMateria
      _notasMateriaRepositorio.AtualizarNotas(notasMateriaDB);

    }


  }
}