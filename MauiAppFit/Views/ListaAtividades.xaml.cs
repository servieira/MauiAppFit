using MauiAppFit.ViewModels;

namespace MauiAppFit.Views;

public partial class ListaAtividades : ContentPage
{
	public ListaAtividades()
	{
        InitializeComponent();
        BindingContext = new CadastroAtividadeViewModel();
		
	}

	protected override async void OnAppearing()
	{
        var vm = (CadastroAtividadeViewModel)BindingContext;
        if (vm.Id == 0)
		{			
			vm.NovaAtividade.Execute(null);
		}
	}
}