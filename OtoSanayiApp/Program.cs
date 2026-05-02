using OtoSanayiApp.Data;

namespace OtoSanayiApp;

static class Program
{
    /// <summary>
    ///  Uygulamanın ana giriş noktası.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        // DevExpress temasını ayarla
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("WXI");

        // Veritabanı tablolarını kontrol et, yoksa oluştur
        try
        {
            DatabaseHelper.InitializeDatabase();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Veritabanı bağlantısı kurulamadı!\n\nHata: {ex.Message}",
                "Veritabanı Hatası",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        Application.Run(new Form1());
    }
}