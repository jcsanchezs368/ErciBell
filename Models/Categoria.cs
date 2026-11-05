namespace ErciBell.Models;

public class Categoria
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public bool TieneGluten { get; set; }
    public bool EsVegano { get; set; }

    public Categoria()
    {
        
    }
    
    public Categoria(int  id, string nombre, bool tieneGluten, bool esVegano)
    {
        Id = id;
        Nombre = nombre;
        TieneGluten = tieneGluten;
        EsVegano = esVegano;
    }
    
    public Categoria(string nombre, bool tieneGluten, bool esVegano)
    {
        Nombre = nombre;
        TieneGluten = tieneGluten;
        EsVegano = esVegano;
    }
}