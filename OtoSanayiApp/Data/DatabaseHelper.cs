using Microsoft.Data.SqlClient;

namespace OtoSanayiApp.Data;

/// <summary>
/// Veritabanı tablolarını oluşturan yardımcı sınıf.
/// Uygulama ilk açıldığında tabloları yoksa otomatik oluşturur.
/// </summary>
public static class DatabaseHelper
{
    /// <summary>
    /// Tüm tabloları kontrol eder, yoksa oluşturur.
    /// Program.cs içinde uygulama başlangıcında çağrılır.
    /// </summary>
    public static void InitializeDatabase()
    {
        using var db = AppDbContext.GetConnection();
        db.Open();

        // 1. Users — Sisteme giriş yapan personel (Admin / Çalışan)
        ExecuteCommand(db, @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Users' AND xtype='U')
            CREATE TABLE Users (
                Id              INT IDENTITY(1,1) PRIMARY KEY,
                Username        NVARCHAR(50)  NOT NULL UNIQUE,
                PasswordHash    NVARCHAR(255) NOT NULL,
                FullName        NVARCHAR(100) NOT NULL,
                Role            NVARCHAR(20)  NOT NULL DEFAULT 'Calisan',
                IsActive        BIT           NOT NULL DEFAULT 1,
                CreatedAt       DATETIME      NOT NULL DEFAULT GETDATE()
            )");

        // 2. Customers — Müşteriler (araç sahipleri)
        ExecuteCommand(db, @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Customers' AND xtype='U')
            CREATE TABLE Customers (
                Id              INT IDENTITY(1,1) PRIMARY KEY,
                FullName        NVARCHAR(100) NOT NULL,
                Phone           NVARCHAR(20)  NOT NULL,
                Email           NVARCHAR(100) NULL,
                Address         NVARCHAR(255) NULL,
                TaxNumber       NVARCHAR(20)  NULL,
                Notes           NVARCHAR(500) NULL,
                CreatedAt       DATETIME      NOT NULL DEFAULT GETDATE()
            )");

        // 3. VehicleBrands — Araç markaları
        ExecuteCommand(db, @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='VehicleBrands' AND xtype='U')
            CREATE TABLE VehicleBrands (
                Id              INT IDENTITY(1,1) PRIMARY KEY,
                Name            NVARCHAR(50)  NOT NULL UNIQUE
            )");

        // 4. VehicleModels — Araç modelleri (markaya bağlı)
        ExecuteCommand(db, @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='VehicleModels' AND xtype='U')
            CREATE TABLE VehicleModels (
                Id              INT IDENTITY(1,1) PRIMARY KEY,
                BrandId         INT           NOT NULL,
                Name            NVARCHAR(100) NOT NULL,
                EngineType      NVARCHAR(50)  NULL,
                EngineSize      NVARCHAR(20)  NULL,
                FOREIGN KEY (BrandId) REFERENCES VehicleBrands(Id)
            )");

        // 5. Vehicles — Müşterilere ait araçlar
        ExecuteCommand(db, @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Vehicles' AND xtype='U')
            CREATE TABLE Vehicles (
                Id              INT IDENTITY(1,1) PRIMARY KEY,
                CustomerId      INT           NOT NULL,
                ModelId         INT           NOT NULL,
                Plate           NVARCHAR(15)  NOT NULL,
                Year            INT           NULL,
                Km              INT           NULL DEFAULT 0,
                Color           NVARCHAR(30)  NULL,
                ChassisNo       NVARCHAR(50)  NULL,
                Notes           NVARCHAR(500) NULL,
                CreatedAt       DATETIME      NOT NULL DEFAULT GETDATE(),
                FOREIGN KEY (CustomerId) REFERENCES Customers(Id),
                FOREIGN KEY (ModelId) REFERENCES VehicleModels(Id)
            )");

        // 6. SparePartCategories — Yedek parça kategorileri
        ExecuteCommand(db, @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='SparePartCategories' AND xtype='U')
            CREATE TABLE SparePartCategories (
                Id              INT IDENTITY(1,1) PRIMARY KEY,
                Name            NVARCHAR(100) NOT NULL UNIQUE
            )");

        // 7. SpareParts — Yedek parçalar / stok
        ExecuteCommand(db, @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='SpareParts' AND xtype='U')
            CREATE TABLE SpareParts (
                Id              INT IDENTITY(1,1) PRIMARY KEY,
                CategoryId      INT           NOT NULL,
                Name            NVARCHAR(150) NOT NULL,
                PartNumber      NVARCHAR(50)  NULL,
                StockQuantity   INT           NOT NULL DEFAULT 0,
                MinStockLevel   INT           NOT NULL DEFAULT 0,
                PurchasePrice   DECIMAL(10,2) NOT NULL DEFAULT 0,
                SalePrice       DECIMAL(10,2) NOT NULL DEFAULT 0,
                Unit            NVARCHAR(20)  NOT NULL DEFAULT 'Adet',
                Notes           NVARCHAR(500) NULL,
                FOREIGN KEY (CategoryId) REFERENCES SparePartCategories(Id)
            )");

        // 8. OilTypes — Yağ çeşitleri
        ExecuteCommand(db, @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='OilTypes' AND xtype='U')
            CREATE TABLE OilTypes (
                Id              INT IDENTITY(1,1) PRIMARY KEY,
                Name            NVARCHAR(100) NOT NULL,
                Viscosity       NVARCHAR(20)  NULL,
                Volume          DECIMAL(5,2)  NULL,
                PurchasePrice   DECIMAL(10,2) NOT NULL DEFAULT 0,
                SalePrice       DECIMAL(10,2) NOT NULL DEFAULT 0,
                StockQuantity   INT           NOT NULL DEFAULT 0
            )");

        // 9. TireTypes — Lastik çeşitleri
        ExecuteCommand(db, @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='TireTypes' AND xtype='U')
            CREATE TABLE TireTypes (
                Id              INT IDENTITY(1,1) PRIMARY KEY,
                Brand           NVARCHAR(50)  NOT NULL,
                Size            NVARCHAR(30)  NOT NULL,
                Season          NVARCHAR(20)  NULL,
                PurchasePrice   DECIMAL(10,2) NOT NULL DEFAULT 0,
                SalePrice       DECIMAL(10,2) NOT NULL DEFAULT 0,
                StockQuantity   INT           NOT NULL DEFAULT 0
            )");

        // 10. ServiceOrders — İş emirleri (ana kayıt)
        ExecuteCommand(db, @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='ServiceOrders' AND xtype='U')
            CREATE TABLE ServiceOrders (
                Id              INT IDENTITY(1,1) PRIMARY KEY,
                VehicleId       INT           NOT NULL,
                UserId          INT           NOT NULL,
                OrderDate       DATETIME      NOT NULL DEFAULT GETDATE(),
                Status          NVARCHAR(20)  NOT NULL DEFAULT 'Bekliyor',
                TotalAmount     DECIMAL(12,2) NOT NULL DEFAULT 0,
                LaborCost       DECIMAL(10,2) NOT NULL DEFAULT 0,
                Notes           NVARCHAR(500) NULL,
                CompletedAt     DATETIME      NULL,
                CurrentKm       INT           NULL,
                FOREIGN KEY (VehicleId) REFERENCES Vehicles(Id),
                FOREIGN KEY (UserId) REFERENCES Users(Id)
            )");

        // 11. ServiceOrderDetails — İş emri detay satırları
        ExecuteCommand(db, @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='ServiceOrderDetails' AND xtype='U')
            CREATE TABLE ServiceOrderDetails (
                Id              INT IDENTITY(1,1) PRIMARY KEY,
                ServiceOrderId  INT           NOT NULL,
                ServiceType     NVARCHAR(50)  NOT NULL,
                SparePartId     INT           NULL,
                OilTypeId       INT           NULL,
                TireTypeId      INT           NULL,
                Quantity        INT           NOT NULL DEFAULT 1,
                UnitPrice       DECIMAL(10,2) NOT NULL DEFAULT 0,
                TotalPrice      DECIMAL(10,2) NOT NULL DEFAULT 0,
                Notes           NVARCHAR(300) NULL,
                FOREIGN KEY (ServiceOrderId) REFERENCES ServiceOrders(Id),
                FOREIGN KEY (SparePartId) REFERENCES SpareParts(Id),
                FOREIGN KEY (OilTypeId) REFERENCES OilTypes(Id),
                FOREIGN KEY (TireTypeId) REFERENCES TireTypes(Id)
            )");
    }

    private static void ExecuteCommand(SqlConnection connection, string sql)
    {
        using var cmd = new SqlCommand(sql, connection);
        cmd.ExecuteNonQuery();
    }
}
