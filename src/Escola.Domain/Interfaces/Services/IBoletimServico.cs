using Escola.Domain.DTO;
using Escola.Domain.Models;


namespace Escola.Domain.Interfaces.Services;

  public interface IBoletimServico
  {
    BoletimDTO ObterPorId(int id);
    IList<BoletimDTO> ObterPorIdAluno(Guid id);
    void Inserir(BoletimDTO boletim);
    void Atualizar(BoletimDTO boletim, int id);
    void ExcluirMateria(int boletimId, int materiaId);

  }
