using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Models;

namespace Escola.Infra.DataBase.Repositories
{
    public class AlunoRepositorio : BaseRepositorio<Aluno, Guid>, IAlunoRepositorio
    {
        public AlunoRepositorio(EscolaDBContexto contexto) : base(contexto)
        {
        }

        public void Atualizar(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        public bool ExisteMatricula(int matricula)
        {
            return _contexto.Alunos.Any(a => a.Matricula == matricula);
        }

        public IList<Aluno> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}