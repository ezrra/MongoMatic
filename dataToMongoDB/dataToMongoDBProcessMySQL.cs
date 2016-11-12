using System;
using MySql.Data.MySqlClient;

namespace dataToMongoDB
{
    public class dataToMongoDBProcessMySQL : dataToMongoDBProcess
    {
        protected override void getSourceData(long lowBound, long highBound)
        {
            MySqlConnection connection = new MySqlConnection(source.connectionString);
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            if (source.script == String.Empty)
                command.CommandText = string.Format("select  * from {0} where {1} between {2} and {3} ", source.table, source.key, lowBound, highBound);
            else
                command.CommandText = string.Format(source.script);
            connection.Open();
            sourceData = command.ExecuteReader();

        }

        protected override void setMInMaxValues()
        {
            using (MySqlConnection connection = new MySqlConnection(source.connectionString))
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                connection.Open();

                command.CommandText = string.Format("select count(*) as count, min({1}) as minValue, max({1})  from {0} ",
                                                    source.table, source.key);

                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                minValue = Convert.ToInt64(reader.GetValue(1));
                maxValue = Convert.ToInt64(reader.GetValue(2));
            }
        }

        protected override void setupSource(dataObject _source)
        {
            source = _source;
            if (source.script == String.Empty)
                setMInMaxValues();
        }
    }
}
