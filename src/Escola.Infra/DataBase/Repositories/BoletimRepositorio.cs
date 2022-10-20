using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Models;

namespace Escola.Infra.DataBase.Repositories
{
  public class BoletimRepositorio : IBoletimRepositorio
  {
    private readonly EscolaDBContexto _contexto;

    public BoletimRepositorio(EscolaDBContexto contexto)
    {
      _contexto = contexto;
    }
    public void Atualizar(Boletim boletim)
    {
      _contexto.Boletins.Update(boletim);
      _contexto.SaveChanges();
    }

    public void Excluir(Boletim boletim)
    {
      _contexto.Boletins.Remove(boletim);
      _contexto.SaveChanges();
    }

        public void ExcluirMateria(Boletim boletim, NotasMateria materia)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Boletim boletim)
    {
      _contexto.Boletins.Add(boletim);
      _contexto.SaveChanges();
    }

    public Boletim ObterPorId(int id)
    {
      return _contexto.Boletins.Find(id);
    }

    public IList<Boletim> ObterPorIdAluno(Guid id)
    {
      return _contexto.Boletins.Where(b => b.AlunoId == id).ToList();
    }
  }
}