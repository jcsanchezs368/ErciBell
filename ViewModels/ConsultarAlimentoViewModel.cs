using ControlAlmacen.Services;
using Material.Icons;

namespace ErciBell.ViewModels;

public class ConsultarAlimentoViewModel : ViewModelBase
{
    private NavigationService _navigationService;
    
    public ConsultarAlimentoViewModel(NavigationService navigationService)
    {
        Titulo = "Consultar Alimentos";
        Icono = MaterialIconKind.Food;
        _navigationService = navigationService;
    }
}