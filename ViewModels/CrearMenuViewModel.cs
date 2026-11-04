using ControlAlmacen.Services;
using Material.Icons;

namespace ErciBell.ViewModels;

public class CrearMenuViewModel : ViewModelBase
{
    private NavigationService _navigationService;
    
    public CrearMenuViewModel(NavigationService navigationService)
    {
        Titulo = "Crear Menu";
        Icono = MaterialIconKind.Book;
        _navigationService = navigationService;
    }
}