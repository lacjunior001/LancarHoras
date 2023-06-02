using LancarHoras.Data;

namespace LancarHoras;

public partial class App : Application
{
    private static SQLiteData? _bancoDados;

    //public static SQLiteData BancoDados
    //{
    //    get
    //    {
    //        if (_bancoDados == null)
    //        {
    //            _bancoDados = new SQLiteData(DependencyService
    //                .Get<ISQLiteDB>().SQLiteLocalPath("LancarHoras.db3"));
    //        }
    //        return _bancoDados;
    //    }
    //}


    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }
}
