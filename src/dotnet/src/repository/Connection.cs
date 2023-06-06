namespace WebApplication1.src.dotnet.src.repository;
    
    using System;
using System.Data.SqlClient;



public class Connection
{



    private String connectionString;

    public Connection(String connectionString)
    {
        this.connectionString = connectionString;
    }
   
}
