using System;
using Xunit;
using WarWagon.DB;
using System.IO;

namespace Test.DB
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            var tmpDbPath = Path.GetTempFileName();

            try
            {
                var db = new Database(tmpDbPath);
                Assert.IsType<Database>(db);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (File.Exists(tmpDbPath))
                {
                    File.Delete(tmpDbPath);
                }
            }

        }
    }
}
