using CommunityToolkit.Mvvm.ComponentModel;
using ControlAlmacen.Services;

namespace ErciBell.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public NavigationService NavigationService { get; set; } = new NavigationService();

    public MainViewModel()
    {
        NavigationService.ListaVistas.Add(new BienvenidaViewModel(NavigationService));
        NavigationService.ListaVistas.Add(new ConsultarAlimentoViewModel(NavigationService));
        NavigationService.ListaVistas.Add(new CrearCategoriaViewModel(NavigationService));
        NavigationService.ListaVistas.Add(new CrearMenuViewModel(NavigationService));
        NavigationService.ListaVistas.Add(new CrearAlimentoViewModel(NavigationService));
        NavigationService.Navegar("Inicio");
    }
}