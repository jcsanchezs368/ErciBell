namespace ErciBell.Models;

public class Menu
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public bool Disponible { get; set; }

    public Menu()
    {
        
    }
    
    public Menu(int id, string nombre, bool disponible)
    {
        Id = id;
        Nombre = nombre;
        Disponible = disponible;
    }
    
    public Menu(string nombre, bool disponible)
    {
        Nombre = nombre;
        Disponible = disponible;
    }
}