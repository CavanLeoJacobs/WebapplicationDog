

using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.src.dotnet.src.repository.impl;

public abstract class ConnectionAbstract
{
    public abstract String connectionString();
public abstract String username();
    public abstract String password();
   
 


    public void SQLConnection()
    {
  
       

    }


}
