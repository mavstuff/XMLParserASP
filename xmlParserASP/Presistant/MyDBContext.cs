﻿using Microsoft.EntityFrameworkCore;
using xmlParserASP.Models;

namespace xmlParserASP.Presistant;

public class MyDBContext : DbContext
{
    public MyDBContext(DbContextOptions<MyDBContext> options)
    : base(options) { }

    public DbSet<MyAttribute> MyAttributes { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    IConfigurationRoot configuration = new ConfigurationBuilder()
    //        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
    //        .AddJsonFile("appsettings.json")
    //        .Build();
    //   // optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

    //    //string connectionString = "Server=MAX\\SQLEXPRESS;Database=MAX;Integrated Security=True;TrustServerCertificate=True" // home desktop
    //    //string connectionString = "Server=(localdb)\\Local;Database=MAX;Integrated Security=True" // home notebook   
    //    //string connectionString = "Server=DESKTOP-5KP5B17\\SQLEXPRESS;Database=MAX;Trusted_Connection=True;TrustServerCertificate=True" // work desktop 
    //    string connectionString =
    //        "Database=zi391919_maxim;Data Source=zi391919.mysql.tools;User Id=zi391919_maxim;Password=y5E~v52!Cv;";

    //    bool isConnected = Database.CanConnect();
    //    Database.EnsureCreated();
   
    //}
}

