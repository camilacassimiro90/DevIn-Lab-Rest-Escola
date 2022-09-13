
using Escola.Domain.Models;

namespace Escola.Domain.Interfaces.Repositories
{
  public interface IBoletimRepositorio
  {
    IList<Boletim> ObterPorIdAluno(Guid id);
    Boletim ObterPorId(int id);
    void Inserir(Boletim boletim);
    void Atualizar(Boletim boletim);
    void ExcluirMateria(Boletim boletim, NotasMateria materia);

  }
}