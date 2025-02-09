﻿using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using ORM_Dapper;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        var config = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json")
                        .Build();

        string connString = config.GetConnectionString("DefaultConnection");
        IDbConnection conn = new MySqlConnection(connString);

        var repos = new DapperDepartmentRepository(conn);

        var departments = repos.GetAllDepartments();

        foreach(var dept in departments)
        {
            Console.WriteLine($"{dept.DepartmentID} {dept.Name}");
        }
    }
}