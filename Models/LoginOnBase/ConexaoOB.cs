namespace LancarHoras.Models.LoginOnBase
{
    public class ConexaoOB
    {
        public string EnderecoIdentityProvider { get; set; }
        public string EnderecoAPIServer { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string Tenant { get; set; }
        public string GrantType { get; set; }
        public string Scope { get; set; }

        public void RestaurarPadrao()
        {
        }
    }
}