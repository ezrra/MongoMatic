using System;
using System.Data.SqlClient;



namespace dataToMongoDB
{
    
    public class dataToMongoDBProcessSQLServer : dataToMongoDBProcess
    {
        protected override void setupSource(dataObject _source)
        {
            source = _source;

            if (source.script == String.Empty)
                setMInMaxValues();

        }

        protected override void setMInMaxValues()
        {
            using (SqlConnection connection = new SqlConnection(source.connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = string.Format("select count(*) count, min({1}) minValue, max({1}) maxValue from {0} ",
                                                    source.table, source.key);

                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                minValue = Convert.ToInt64(reader.GetValue(1));
                maxValue = Convert.ToInt64(reader.GetValue(2));
            }
        }

        protected override void getSourceData(Int64 lowBound, Int64 highBound)
        {
            SqlConnection connection = new SqlConnection(source.connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            if (source.script == String.Empty)
                command.CommandText = string.Format("select  * from {0} where {1} between {2} and {3} ", source.table, source.key, lowBound, highBound);
            else
                command.CommandText = string.Format( source.script );
            connection.Open();
            sourceData = command.ExecuteReader();

            // return sourceData;

        }

       
    }
}
