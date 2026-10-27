using System;

namespace Company.ClassLibrary1;

public class AppDbContext
{
    public Dbset<Producto> Productos {get; set;}
    protected override void Onconfiguring(DbContextOptionsBuilder optionsBuilder){
        var connectionString = "Server = lobalhost; Database= Tienda-Don-Pedro; user root; password= axel"
        optionsBuilder.UserMysql(connectionString, ServerVersion.AutoDetect(connectionString))
    }
}
