using Avalonia.Controls;
using ControlAlmacen.Services;
using Material.Icons;

namespace ErciBell.ViewModels;

public partial class BienvenidaViewModel : ViewModelBase
{
    private NavigationService _navigationService;
    
    public BienvenidaViewModel(NavigationService navigationService)
    {
        Titulo = "Inicio";
        Icono = MaterialIconKind.Home;
        _navigationService = navigationService;
    }
}