using System;

namespace ErciBell.Models;

public class Alimento
{
    private Guid id { get; set; }
    private string nombre { get; set; }
    private string descripcion { get; set; }
    private double precio { get; set; }
    private Categoria categoria { get; set; }
    private Menu menu { get; set; }

    public Alimento()
    {
        
    }
    
    public Alimento(Guid id, string nombre, string descripcion, double precio, Categoria categoria, Menu menu)
    {
        this.id = id;
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.precio = precio;
        this.categoria = categoria;
        this.menu = menu;
    }
    
    public Alimento(string nombre, string descripcion, double precio, Categoria categoria, Menu menu)
    {
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.precio = precio;
        this.categoria = categoria;
        this.menu = menu;
    }
    
    
}