using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarWagon.DB
{
    public class Database
    {
        private readonly string _dbFilePath;

        public Database(string tmpDbPath)
        {
            _dbFilePath = tmpDbPath;
        }

        private void Open()
        {
            var con = new SQLiteConnection("DataSource=" + _dbFilePath);
        }
    }
}
