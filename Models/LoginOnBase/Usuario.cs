using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancarHoras.Models.LoginOnBase
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public DateTime TokenValidade { get; set; }
        public CookieOB Cookie { get; set; }
        public ConexaoOB Conexao { get; set; }
    }
}
