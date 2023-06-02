using LancarHoras.Models.LoginOnBase;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancarHoras.Data
{
    public class SQLiteData
    {
        readonly SQLiteAsyncConnection _conexao;
        public UsuarioData UsuarioDataTable { get; set; }

        public SQLiteData(string path)
        {
            _conexao = new SQLiteAsyncConnection(path);
            _conexao.CreateTableAsync<Usuario>().Wait();
            UsuarioDataTable = new UsuarioData(_conexao);
        }
    }
}
