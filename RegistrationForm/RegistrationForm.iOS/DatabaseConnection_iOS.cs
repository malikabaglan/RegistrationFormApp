﻿using System;
using System.IO;
using RegistrationForm.iOS;
using SQLite;

[assembly: Xamarin.Forms.Dependency(typeof(DatabaseConnection_iOS))]
namespace RegistrationForm.iOS
{
    public class DatabaseConnection_iOS: IDatabaseConnection
    {
        public SQLiteConnection DbConnection()
        {
            var dbName = "CustomersDb.db3";
            string personalFolder =
             System.Environment.
         GetFolderPath(Environment.SpecialFolder.Personal);
             string libraryFolder =
             Path.Combine(personalFolder, "..", "Library");
          var path = Path.Combine(libraryFolder, dbName);
          return new SQLiteConnection(path);
        }
    }
}

