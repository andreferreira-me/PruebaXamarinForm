using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PruebaXamarinForm.Storage.Interfaces;
using SQLite;
using System.IO;
using Xamarin.Forms;
using PruebaXamarinForm.Droid.Storage.Implementations;

[assembly:Dependency(typeof(SQLiteDroid))]
namespace PruebaXamarinForm.Droid.Storage.Implementations
{
    public class SQLiteDroid : ISQLite
    {
        public SQLiteDroid()
        {

        }

        SQLiteConnection ISQLite.GetConnection()
        {
            SQLitePCL.Batteries.Init();
            var sqliteFilename = "ToDOSQLite.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            // Create the connection
            var conn = new SQLite.SQLiteConnection(path);
            // Return the database connection
            return conn;

        }
    }
}