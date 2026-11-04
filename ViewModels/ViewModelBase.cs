using CommunityToolkit.Mvvm.ComponentModel;
using Material.Icons;

namespace ErciBell.ViewModels;

public abstract class ViewModelBase : ObservableObject
{
    public string Titulo { get; set; }
    public MaterialIconKind Icono { get; set; }
}