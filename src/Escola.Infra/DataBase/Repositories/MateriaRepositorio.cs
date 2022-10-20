using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Models;

namespace Escola.Infra.DataBase.Repositories
{

  public class MateriaRepositorio : IMateriaRepositorio
  {
    private readonly EscolaDBContexto _contexto;

    public MateriaRepositorio(EscolaDBContexto contexto)
    {
      _contexto = contexto;
    }

        public void Atualizar(Materia materia)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Materia materia)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Materia materia)
    {
      _contexto.Materias.Add(materia);
      _contexto.SaveChanges();
    }

        public Materia ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Materia> ObterPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public IList<Materia> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}