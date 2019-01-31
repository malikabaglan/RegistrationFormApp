using System;
namespace RegistrationForm
{
    public interface IDatabaseConnection
    {
       SQLite.SQLiteConnection DbConnection();
    }
}
