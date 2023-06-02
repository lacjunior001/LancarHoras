using LancarHoras.ViewModel;

namespace LancarHoras.Pages.Usuario;

public partial class Conexao : ContentPage
{
	public Conexao(ConexaoViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}