using System;
using System.Data.Entity;
using System.Linq;

namespace OKUL_EF_CF.Models
{
    public class OkulContext : DbContext
    {
        // Your context has been configured to use a 'OkulContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'OKUL_EF_CF.Models.OkulContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'OkulContext' 
        // connection string in the application configuration file.
        public OkulContext()
            : base("name=OkulContext") // Connection string Name
        {

        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Ogrenci> Ogrenciler { get; set; }
        public virtual DbSet<Ogretmen> Ogretmenler { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}