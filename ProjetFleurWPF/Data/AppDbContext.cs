using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetFleurWPF.Models;

namespace ProjetFleurWPF.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Fleur> Fleurs { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Vendeur> Vendeurs { get; set; }
        public DbSet<Proprietaire> Proprietaires { get; set; }
        public DbSet<Fournisseur> Fournisseurs { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<CommandeProduit> CommandeProduits { get; set; }
        public DbSet<Bouquet> Bouquets { get; set; }
        public DbSet<FleurBouquet> FleurBouquets { get; set; }
        public DbSet<BouquetPreconfigure> BouquetsPreconfigures { get; set; }
        public DbSet<FleurBouquetPreconfigure> FleurBouquetPreconfigures { get; set; }
        public DbSet<Facture> Factures { get; set; }
        public DbSet<CommandeFournisseur> CommandesFournisseurs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Connexion locale, à ajuster si tu utilises un vrai SQL Server
            string connection_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            string database_name = "FleurBoutiqueDB";
            optionsBuilder.UseSqlServer($"{connection_string};Database={database_name};Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuration des relations complexes (many-to-many par tables intermédiaires)
            modelBuilder.Entity<FleurBouquet>()
                .HasOne(fb => fb.Fleur)
                .WithMany()
                .HasForeignKey(fb => fb.FleurId);

            modelBuilder.Entity<FleurBouquet>()
                .HasOne(fb => fb.Bouquet)
                .WithMany(b => b.FleurBouquets)
                .HasForeignKey(fb => fb.BouquetId);

            modelBuilder.Entity<FleurBouquetPreconfigure>()
                .HasOne(fbp => fbp.Fleur)
                .WithMany()
                .HasForeignKey(fbp => fbp.FleurId);

            modelBuilder.Entity<FleurBouquetPreconfigure>()
                .HasOne(fbp => fbp.BouquetPreconfigure)
                .WithMany(bp => bp.FleurBouquetPreconfigures)
                .HasForeignKey(fbp => fbp.BouquetPreconfigureId);

            modelBuilder.Entity<CommandeProduit>()
                .HasOne(cp => cp.Commande)
                .WithMany(c => c.CommandeProduits)
                .HasForeignKey(cp => cp.CommandeId);
        }
    }
}

