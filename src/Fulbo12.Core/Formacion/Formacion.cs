using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fulbo12.Core.Formacion
{
    public class Formacion
    {
        public List<Linea> Lineas { get; set; }
        public string Nombre { get; set; }
        public Formacion() => Lineas = new List<Linea>();
        public byte QuimicaJugadores
        {
            get => Convert.ToByte(Lineas.Sum(item => item.QuimicaJugadores));
        }
        public string FormacionString
        {
            get
            {
                List<byte> aux = new List<byte>();
                foreach (var linea in Lineas) aux.Add(linea.CantidadPosiciones);
                return new StringBuilder().AppendJoin(" - ", aux).ToString();
            }
        }
    }
}