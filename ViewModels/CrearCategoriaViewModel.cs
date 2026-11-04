using ControlAlmacen.Services;
using Material.Icons;

namespace ErciBell.ViewModels;

public class CrearCategoriaViewModel : ViewModelBase
{
    private NavigationService _navigationService;
    
    public CrearCategoriaViewModel(NavigationService navigationService)
    {
        Titulo = "Crear Categoria";
        Icono = MaterialIconKind.ClipboardList;
        _navigationService = navigationService;
    }
}