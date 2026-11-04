namespace ErciBell.Models;

public class Menu
{
    private int id { get; set; }
    private string nombre { get; set; }
    private bool disponible { get; set; }

    public Menu()
    {
        
    }
    
    public Menu(int id, string nombre, bool disponible)
    {
        this.id = id;
        this.nombre = nombre;
        this.disponible = disponible;
    }
    
    public Menu(string nombre, bool disponible)
    {
        this.nombre = nombre;
        this.disponible = disponible;
    }
}