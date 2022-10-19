using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fulbo12.Core.Futbol;

namespace Fulbo12.Core.Persistencia.EFC.Repos
{
    public class RepoTipoFutbolista : RepoGenerico<TipoFutbolista>, IRepoTipoFutbolista
    {
        public RepoTipoFutbolista(Fulbo12Contexto contexto) : base(contexto) { }
    }
}