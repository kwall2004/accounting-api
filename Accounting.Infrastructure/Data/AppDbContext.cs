using Accounting.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Accounting.Infrastructure.Data
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Balance> Balance { get; set; }
        public virtual DbSet<Captured> Captured { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Recurrence> Recurrence { get; set; }
        public virtual DbSet<Recurrencenew> Recurrencenew { get; set; }
        public virtual DbSet<Setting> Setting { get; set; }
        public virtual DbSet<Transaction> Transaction { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("account", "heroku_17bef1ebf75c4dc");

                entity.Property(e => e.AccountId).HasColumnType("int(11)");

                entity.Property(e => e.AccountDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Balance>(entity =>
            {
                entity.ToTable("balance", "heroku_17bef1ebf75c4dc");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BalanceAmount)
                    .HasColumnName("balanceAmount")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.BalanceDate).HasColumnName("balanceDate");
            });

            modelBuilder.Entity<Captured>(entity =>
            {
                entity.ToTable("captured", "heroku_17bef1ebf75c4dc");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Date).HasColumnName("date");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category", "heroku_17bef1ebf75c4dc");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("categoryId")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryDescription)
                    .IsRequired()
                    .HasColumnName("categoryDescription")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SuperCategory)
                    .HasColumnName("superCategory")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Recurrence>(entity =>
            {
                entity.ToTable("recurrence", "heroku_17bef1ebf75c4dc");

                entity.Property(e => e.RecurrenceId)
                    .HasColumnName("recurrenceId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MonthlyDate)
                    .HasColumnName("monthlyDate")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MonthlyWeek)
                    .HasColumnName("monthlyWeek")
                    .HasColumnType("int(11)");

                entity.Property(e => e.QuarterlyMonth)
                    .HasColumnName("quarterlyMonth")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecurrenceAmount)
                    .HasColumnName("recurrenceAmount")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.RecurrenceCategory)
                    .IsRequired()
                    .HasColumnName("recurrenceCategory")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RecurrenceDescription)
                    .IsRequired()
                    .HasColumnName("recurrenceDescription")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WeekdayOnly)
                    .HasColumnName("weekdayOnly")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.WeeklyDay)
                    .HasColumnName("weeklyDay")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Recurrencenew>(entity =>
            {
                entity.HasKey(e => e.RecurrenceId);

                entity.ToTable("recurrencenew", "heroku_17bef1ebf75c4dc");

                entity.Property(e => e.RecurrenceId)
                    .HasColumnName("recurrenceId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EndDate).HasColumnName("endDate");

                entity.Property(e => e.MonthlyDate)
                    .HasColumnName("monthlyDate")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MonthlyFrequency)
                    .HasColumnName("monthlyFrequency")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecurrenceAmount)
                    .HasColumnName("recurrenceAmount")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.RecurrenceCategory)
                    .IsRequired()
                    .HasColumnName("recurrenceCategory")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RecurrenceDescription)
                    .IsRequired()
                    .HasColumnName("recurrenceDescription")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnName("startDate");

                entity.Property(e => e.WeeklyDay)
                    .HasColumnName("weeklyDay")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WeeklyFrequency)
                    .HasColumnName("weeklyFrequency")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.ToTable("setting", "heroku_17bef1ebf75c4dc");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Account)
                    .HasColumnName("account")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DecimalValue)
                    .HasColumnName("decimalValue")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.SettingName)
                    .IsRequired()
                    .HasColumnName("settingName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(e => e.TransId);

                entity.ToTable("transaction", "heroku_17bef1ebf75c4dc");

                entity.Property(e => e.TransId)
                    .HasColumnName("transId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Account)
                    .HasColumnName("account")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cleared)
                    .HasColumnName("cleared")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.TransAmount)
                    .HasColumnName("transAmount")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.TransCategory)
                    .IsRequired()
                    .HasColumnName("transCategory")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TransDate).HasColumnName("transDate");

                entity.Property(e => e.TransDescription)
                    .IsRequired()
                    .HasColumnName("transDescription")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
