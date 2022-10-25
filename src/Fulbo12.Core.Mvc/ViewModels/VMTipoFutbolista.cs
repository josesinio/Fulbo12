using System.ComponentModel.DataAnnotations;
using Fulbo12.Core.Futbol;
using Microsoft.AspNetCore.Mvc;

namespace Fulbo12.Core.Mvc.ViewModels;
public class VMTipoFutbolista
{
    [Remote(action: "VerificarNombre", controller: "TipoFutbolista")]
    [MinLength(4)]
    [MaxLength(30)]
    public string Nombre { get; set; }
    public byte Id { get; set; }
    public TipoFutbolista TipoFutbolista { get; set; }
    public VMTipoFutbolista()
    {

    }
    public VMTipoFutbolista(TipoFutbolista tipoFutbolista)
    {
        Nombre = tipoFutbolista.Nombre;
        Id = tipoFutbolista.Id;
        TipoFutbolista = tipoFutbolista;
    }
    public void GenerarTipoFutbolista()
        => TipoFutbolista = new TipoFutbolista(Nombre) { Id = Id };

}
