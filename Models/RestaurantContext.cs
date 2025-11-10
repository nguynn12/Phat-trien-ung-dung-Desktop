using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Entity_Framework.Models
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleAccount> RoleAccounts { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }
        public DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Food → Category
            modelBuilder.Entity<Food>()
                .HasRequired(f => f.Category)
                .WithMany()
                .HasForeignKey(f => f.FoodCategoryId)
                .WillCascadeOnDelete(true);

            // BillDetail → Bill, Food
            modelBuilder.Entity<BillDetail>()
                .HasRequired(bd => bd.Bill)
                .WithMany(b => b.BillDetails)
                .HasForeignKey(bd => bd.InvoiceId);

            modelBuilder.Entity<BillDetail>()
                .HasRequired(bd => bd.Food)
                .WithMany()
                .HasForeignKey(bd => bd.FoodId);

            // Bill → Table
            modelBuilder.Entity<Bill>()
                .HasRequired(b => b.Table)
                .WithMany()
                .HasForeignKey(b => b.TableId);

            // RoleAccount (Composite Key)
            modelBuilder.Entity<RoleAccount>()
                .HasKey(ra => new { ra.RoleId, ra.AccountName });

            modelBuilder.Entity<RoleAccount>()
                .HasRequired(ra => ra.Role)
                .WithMany()
                .HasForeignKey(ra => ra.RoleId);

            modelBuilder.Entity<RoleAccount>()
                .HasRequired(ra => ra.Account)
                .WithMany()
                .HasForeignKey(ra => ra.AccountName);
        }
    }
}
