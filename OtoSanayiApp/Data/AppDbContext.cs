using Microsoft.Data.SqlClient;

namespace OtoSanayiApp.Data;

/// <summary>
/// MSSQL veritabanı bağlantısını yöneten sınıf.
/// Saf ADO.NET ile birlikte kullanılır.
/// </summary>
public static class AppDbContext
{
    // LocalDB bağlantı dizesi — OtoSanayiDB veritabanına bağlanır
    private const string ConnectionString =
        @"Server=(localdb)\MSSQLLocalDB;Database=OtoSanayiDB;Trusted_Connection=True;";

    /// <summary>
    /// Yeni bir veritabanı bağlantısı oluşturur ve döndürür.
    /// Kullanım: using var db = AppDbContext.GetConnection();
    /// </summary>
    public static SqlConnection GetConnection()
    {
        return new SqlConnection(ConnectionString);
    }
}
