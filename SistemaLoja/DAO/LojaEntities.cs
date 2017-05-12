using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SistemaLoja.Model;

namespace SistemaLoja.DAO
{
    class LojaEntities : DbContext
    {
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<ItemVenda> Itens { get; set; }
        public DbSet<VendaEItem> VendaEItens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrador>().ToTable("Administradores");
            modelBuilder.Entity<Vendedor>().ToTable("Vendedores");
            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<Produto>().ToTable("Produtos");
            modelBuilder.Entity<Venda>().ToTable("Vendas");
            modelBuilder.Entity<ItemVenda>().ToTable("Itens");
            modelBuilder.Entity<VendaEItem>().ToTable("VendaEItens");

            base.OnModelCreating(modelBuilder);
        }
    }
}
