using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Bookish.DataAccess
{
    public class DataAccessor
    {
        public static List<Book> GetBooks()
        {
            IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string SqlString = "SELECT TOP 100 [Id],[AuthorName],[Title],[ISBN] FROM [Books]";

            var ourBooks = db.Query<Book>(SqlString).ToList();

            return ourBooks;
        }
    }
}
