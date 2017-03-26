using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using PruebaXamarinForm.Storage.Interfaces;
using SQLite;
using System.IO;
using Xamarin.Forms;
using PruebaXamarinForm.iOS.Storage.Implementations;

[assembly: Dependency(typeof(SQLiteiOS))]
namespace PruebaXamarinForm.Droid.Storage.Implementations
{
    public class SQLiteiOS : ISQLite
    {
        public SQLiteiOS()
        {

        }

        SQLiteConnection ISQLite.GetConnection()
        {
            SQLitePCL.Batteries.Init();
            var sqliteFilename = "ToDOSQLite.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string libraryPath = Path.Combine(documentsPath, "..", "Library"); //Library Folder
            var path = Path.Combine(libraryPath, sqliteFilename);
            // Create the connection
            var conn = new SQLite.SQLiteConnection(path);
            // Return the database connection
            return conn;

        }
    }
}