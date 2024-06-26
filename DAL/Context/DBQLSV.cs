using DAL.Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace DAL.Context
{
    public class DBQLSV : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DAL.Context.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public DBQLSV()
            : base("name=DBQLSV")
        {
            Database.SetInitializer<DBQLSV>(new CreateDB());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<SV> SVs { get; set; }
        public virtual DbSet<LHP> LHPs { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}