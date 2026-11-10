using ControlAlmacen.Services;
using Material.Icons;

namespace ErciBell.ViewModels;

public partial class CrearAlimentoViewModel : ViewModelBase
{
    private NavigationService _navigationService;
    
    public CrearAlimentoViewModel(NavigationService navigationService)
    {
        Titulo = "Crear Alimento";
        Icono = MaterialIconKind.FoodTakeoutBox;
        _navigationService = navigationService;
    }
}