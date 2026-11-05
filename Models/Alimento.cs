using System;

namespace ErciBell.Models;

public class Alimento
{
    public Guid Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public double Precio { get; set; }
    public Categoria Categoria { get; set; }
    public Menu Menu { get; set; }

    public Alimento()
    {
        
    }
    
    public Alimento(Guid id, string nombre, string descripcion, double precio, Categoria categoria, Menu menu)
    {
        Id = id;
        Nombre = nombre;
        Descripcion = descripcion;
        Precio = precio;
        Categoria = categoria;
        Menu = menu;
    }
    
    public Alimento(string nombre, string descripcion, double precio, Categoria categoria, Menu menu)
    {
        Nombre = nombre;
        Descripcion = descripcion;
        Precio = precio;
        Categoria = categoria;
        Menu = menu;
    }
    
    
}