using System;
using Avalonia.Collections;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ControlAlmacen.Services;
using DialogHostAvalonia;
using ErciBell.Dialogs;
using ErciBell.Models;
using Material.Icons;

namespace ErciBell.ViewModels;

public partial class ConsultarAlimentoViewModel : ViewModelBase
{
    [ObservableProperty] private Alimento _alimentoSeleccionado;
    [ObservableProperty] private string _imagenSeleccionada;
    private NavigationService _navigationService;
    [ObservableProperty] private AvaloniaList<Alimento> _listaAlimentos = new();
    [ObservableProperty] private int _indiceImagen = 0;
    public ConsultarAlimentoViewModel()
    {
        
    }
    public ConsultarAlimentoViewModel(NavigationService navigationService)
    {
        Titulo = "Consultar Alimentos";
        Icono = MaterialIconKind.Food;
        _navigationService = navigationService;

        Alimento alimento1 = new Alimento
        {
            Id = Guid.NewGuid(),
            Nombre = "Taco de carne",
            Descripcion = "Taco de carne de vacuno con salsa picante y jalapeños",
            Precio = 2.99,
            Categoria = new Categoria(1, "Tacos", true, false),
            Menu = new Menu(1, "Variedad de tacos picantes",true)
        };
        
        Alimento alimento2 = new Alimento
        {
            Id = Guid.NewGuid(),
            Nombre = "El Diablo XXL",
            Descripcion = "Taco con extra de carne de vacuno y con salsa de habanero, dedicado a los más valientes",
            Precio = 4.99,
            Categoria = new Categoria(1, "Tacos", true, false),
            Menu = new Menu(1, "Variedad de tacos picantes",true)
        };
        
        ListaAlimentos.Add(alimento1);
        ListaAlimentos.Add(alimento2);
    }
    [RelayCommand]
    public void AbrirEditarAlimentoDialog()
    {
        DialogHost.Show(new EditarAlimentoDialog(), "EditarAlimentoDialog" );
    }

    [RelayCommand]
    private void SiguienteImagen()
    {
        if (IndiceImagen < AlimentoSeleccionado.UrlImagenes.Count - 1)
            IndiceImagen++;
    }

    [RelayCommand]
    private void ImagenAnterior()
    {
        if (IndiceImagen > 0)
            IndiceImagen--;
    }
}