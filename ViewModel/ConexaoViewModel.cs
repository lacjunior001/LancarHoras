using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LancarHoras.Models.LoginOnBase;
using static System.Net.Mime.MediaTypeNames;

namespace LancarHoras.ViewModel
{
    public partial class ConexaoViewModel : ObservableObject
    {
        [ObservableProperty]
        string enderecoIdentityProvider;

        [ObservableProperty]
        string enderecoAPIServer;

        [ObservableProperty]
        string clientId;

        [ObservableProperty]
        string clientSecret;

        [ObservableProperty]
        string tenant;

        [ObservableProperty]
        string grantType;

        [ObservableProperty]
        string scope;

        [ObservableProperty]
        bool camposAtivo;

        [ObservableProperty]
        bool editarVisivel;

        [ObservableProperty]
        bool salvarVisivel;

        public ConexaoViewModel()
        {
            CamposAtivo = false;
            EditarVisivel = true;
            SalvarVisivel = false;
            var conexao = new ConexaoOB();
            conexao.RestaurarPadrao();
            EnderecoIdentityProvider = conexao.EnderecoIdentityProvider;
            EnderecoAPIServer = conexao.EnderecoAPIServer;
            ClientId = conexao.ClientId;
            ClientSecret = conexao.ClientSecret;
            Tenant = conexao.Tenant;
            GrantType = conexao.GrantType;
            Scope = conexao.Scope;
        }

        [RelayCommand]
        void Editar()
        {
            CamposAtivo = true;
            EditarVisivel = false;
            SalvarVisivel = true;
        }

        [RelayCommand]
        void Salvar()
        {
            CamposAtivo = false;
            EditarVisivel = true;
            SalvarVisivel = false;
        }
    }
}