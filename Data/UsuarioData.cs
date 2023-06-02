using LancarHoras.Models.LoginOnBase;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancarHoras.Data
{
    public class UsuarioData
    {
        private SQLiteAsyncConnection _conexao;

        public UsuarioData(SQLiteAsyncConnection conexao)
        {
            _conexao = conexao;
        }

        public Task<List<Usuario>> Listar()
        {
            return _conexao.Table<Usuario>().ToListAsync();
        }

        public Task<Usuario> GetUsuario(string nomeUsuario, string senha)
        {
            return _conexao.Table<Usuario>()
                .Where(u => u.UserName == nomeUsuario && u.Password == senha)
                .FirstOrDefaultAsync();
        }
    }
}
