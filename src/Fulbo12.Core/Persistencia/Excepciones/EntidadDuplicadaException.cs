namespace Fulbo12.Core.Persistencia.Excepciones;
public class EntidadDuplicadaException: Exception
{
    public EntidadDuplicadaException() { }
    public EntidadDuplicadaException(string mensaje):base(mensaje)
    {            
    }
    public EntidadDuplicadaException(string mensaje, Exception inner)
        :base (mensaje, inner)
    {            
    }
}