using System;
using System.Configuration;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataLayer.DBContext
{
    public partial class DB_SALE_SYSTEMContext : DbContext
    {
        public DB_SALE_SYSTEMContext()
        {
        }

        public DB_SALE_SYSTEMContext(DbContextOptions<DB_SALE_SYSTEMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppUser> AppUsers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<SaleDetail> SaleDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["connection"].ToString());//("Server = DESKTOP-8VATVKI\\SQLEXPRESS; DataBase = DB_SALE_SYSTEM; user id = admin; password = password230214; Integrated Security = True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.ToTable("APP_USER");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("creation_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Document)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("document");

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("full_name");

                entity.Property(e => e.IdRole).HasColumnName("id_role");

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.State).HasColumnName("state");

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.AppUsers)
                    .HasForeignKey(d => d.IdRole)
                    .HasConstraintName("FK__APP_USER__id_rol__403A8C7D");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("CATEGORY");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("creation_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("CLIENT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("creation_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Document)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("document");

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("full_name");

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("PERMISSION");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("creation_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdRole).HasColumnName("id_role");

                entity.Property(e => e.MenuName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("menu_name");

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.Permissions)
                    .HasForeignKey(d => d.IdRole)
                    .HasConstraintName("FK__PERMISSIO__id_ro__36B12243");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("PRODUCT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("creation_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.IdCategory).HasColumnName("id_category");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PurchasePrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("purchase_price")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SalePrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("sale_price")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Stock).HasColumnName("stock");

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdCategory)
                    .HasConstraintName("FK__PRODUCT__id_cate__46E78A0C");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.ToTable("PROVIDER");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.BusinessName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("business_name");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("creation_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Document)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("document");

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.ToTable("PURCHASE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("creation_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DocumentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("document_type");

                entity.Property(e => e.IdProvider).HasColumnName("id_provider");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoice_number");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("total");

                entity.HasOne(d => d.IdProviderNavigation)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(d => d.IdProvider)
                    .HasConstraintName("FK__PURCHASE__id_pro__4E88ABD4");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__PURCHASE__id_use__4D94879B");
            });

            modelBuilder.Entity<PurchaseDetail>(entity =>
            {
                entity.ToTable("PURCHASE_DETAIL");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("creation_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdProduct).HasColumnName("id_product");

                entity.Property(e => e.IdPurchase).HasColumnName("id_purchase");

                entity.Property(e => e.PurchasePrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("purchase_price")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.SalePrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("sale_price")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("total");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.PurchaseDetails)
                    .HasForeignKey(d => d.IdProduct)
                    .HasConstraintName("FK__PURCHASE___id_pr__74AE54BC");

                entity.HasOne(d => d.IdPurchaseNavigation)
                    .WithMany(p => p.PurchaseDetails)
                    .HasForeignKey(d => d.IdPurchase)
                    .HasConstraintName("FK__PURCHASE___id_pu__52593CB8");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("ROLE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("creation_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("description");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.ToTable("SALE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Change)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("change");

                entity.Property(e => e.ClientDocument)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("client_document");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("client_name");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("creation_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DocumentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("document_type");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoice_number");

                entity.Property(e => e.Payment)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("payment");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("total");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__SALE__id_user__5812160E");
            });

            modelBuilder.Entity<SaleDetail>(entity =>
            {
                entity.ToTable("SALE_DETAIL");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("creation_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdProduct).HasColumnName("id_product");

                entity.Property(e => e.IdSale).HasColumnName("id_sale");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.SalePrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("sale_price");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("subtotal");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.SaleDetails)
                    .HasForeignKey(d => d.IdProduct)
                    .HasConstraintName("FK__SALE_DETA__id_pr__5CD6CB2B");

                entity.HasOne(d => d.IdSaleNavigation)
                    .WithMany(p => p.SaleDetails)
                    .HasForeignKey(d => d.IdSale)
                    .HasConstraintName("FK__SALE_DETA__id_sa__5BE2A6F2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
