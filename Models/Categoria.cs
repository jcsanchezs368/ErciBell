namespace ErciBell.Models;

public class Categoria
{
    private int id { get; set; }
    private string nombre { get; set; }
    private bool tieneGluten { get; set; }
    private bool esVegano { get; set; }

    public Categoria()
    {
        
    }
    
    public Categoria(int  id, string nombre, bool tieneGluten, bool esVegano)
    {
        this.id = id;
        this.nombre = nombre;
        this.tieneGluten = tieneGluten;
        this.esVegano = esVegano;
    }
    
    public Categoria(string nombre, bool tieneGluten, bool esVegano)
    {
        this.nombre = nombre;
        this.tieneGluten = tieneGluten;
        this.esVegano = esVegano;
    }
}