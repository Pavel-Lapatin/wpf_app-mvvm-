namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ServiceCenter : DbContext
    {
        // Your context has been configured to use a 'ServiceCenter' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DAL.ServiceCenter' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ServiceCenter' 
        // connection string in the application configuration file.
        public ServiceCenter()
            : base("name=ServiceCenterDB")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ServiceCenter>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Client> Clients {get; set;}
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeAccount> EmployeeAccounts { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}