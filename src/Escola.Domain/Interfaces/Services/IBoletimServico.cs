using Escola.Domain.Models;
using Escola.Domain.DTO;

namespace Escola.Api.Controllers
{
  public interface IBoletimServico
  {
    BoletimDTO ObterPorId(int id);
    IList<BoletimDTO> ObterPorIdAluno(Guid id);
    IList<BoletimDTO> ObterPorNome(string nome);

  }
}