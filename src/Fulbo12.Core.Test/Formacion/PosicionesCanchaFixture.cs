using System.Collections.Generic;
using Fulbo12.Core.Futbol;
using Xunit;

namespace Fulbo12.Core.Formacion.Test
{
    public class PosicionesCanchaFixture
    {
        public PosicionEnCancha DFI { get; set; }

        public PosicionesCanchaFixture()
        {
            DFI = new PosicionEnCancha();
        }
    }
}