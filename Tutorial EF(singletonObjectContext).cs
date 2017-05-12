BO/DAO/MODEL
1- Estabelecer entidadades nas classes
2- Estabelecer as entidades no banco de dados
3- install -package entityframework -pre
4- Configurar a connection no app.config(Pegando das propriedades do bd que desejar)
5- Classe "XEntities" por exemplo(using System.Data.Entity; using X.Model;)
6- Classe SingletonObjectContext

----------------------------------------------------------
			app.config
----------------------------------------------------------
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <connectionStrings>
    <add name="XEntities"
          connectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Will\Documents\Visual Studio 2015\Projects\SistemaLojaFinal\BancoLoja.mdf;Integrated Security=True;Connect Timeout=30"
          providerName="System.Data.SqlClient"/>
  </connectionStrings>
</configuration>
----------------------------------------------------------
			XEntities
----------------------------------------------------------

class XEntities : DbContext
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
----------------------------------------------------------
		SingletonObjectContext
----------------------------------------------------------
class SingletonObjectContext
    {
        private static readonly SingletonObjectContext instance = new SingletonObjectContext();
        private readonly XEntities context;

        private SingletonObjectContext()
        {
            context = new XEntities();
        }

        public static SingletonObjectContext Instance
        {
            get
            {
                return instance;
            }
        }

        public XEntities Context
        {
            get
            {
                return context;
            }
        }
    }
----------------------------------------------------------
			Exemplo DAO
----------------------------------------------------------


class AdministradorDAO
    {
        public static Administrador Find(Administrador A)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.Administradores.FirstOrDefault(x=>x.Cpf.Equals(A.Cpf));
            }
            catch
            {
                return null;
            }
        }
        public static bool Insert(Administrador A)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Administradores.Add(A);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Alter(Administrador A)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Entry(A).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Delete(Administrador A)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Administradores.Remove(A);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
----------------------------------------------------------