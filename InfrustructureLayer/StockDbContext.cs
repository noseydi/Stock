using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace WareHousingProject.Entities
{
    public class StockDbContext : DbContext
    {
        public DbSet<CitiesEntity> Cities { get; set; }
        public DbSet<InventoryTransactionsEntity> InventoryTransactions { get; set; }
        public DbSet<ProductsEntity> Products { get; set; }
        public DbSet<ProductSerialsEntity> ProductSerials { get; set; }
        public DbSet <ShelvesEntity> Shelves { get; set; }
        public DbSet <WarehousesEntity> Warehouses { get; set; }
        public DbSet <WarehouseTransferEntity> WarehouseTransfers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-OMLIEAB;Database=StockDB;Encrypt=false;Integrated Security=true;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}