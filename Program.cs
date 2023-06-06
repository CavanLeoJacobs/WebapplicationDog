using MongoDB.Driver.Core.WireProtocol.Messages.Encoders.JsonEncoders;
using WebApplication1.src.dotnet.src.repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    public static void Main(string[] args)
    {

     
        RunApp(args);

       // RunDatabase();



    }

    public static void RunDatabase()
    {

    }
       public static void RunApp(string[] args)
    {
        ///  Console.WriteLine(new Connection("").GetType() == new Connection("").GetType());



        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        WebApplication app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();


    }

}