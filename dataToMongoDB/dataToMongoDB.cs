using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;


namespace dataToMongoDB
{
    public struct dataObject
    {
        public bool dropTable { get; set; }

        public string connectionString { get; set; }
        public Int64 interval { get; set; }
        public string database { get; set; }
        public string table { get; set; }
        public string key { get; set; }
    }

  

    public class dataToMongoDBProcess
    {
        private long minValue;
        private long maxValue;

        private dataObject source { get; set; }
        private dataObject destination { get; set; }
        private SqlDataReader sourceData { get; set; }

        public string export(dataObject source, dataObject destination)
        {
            DateTime time = DateTime.Now;
            exportFromSourceToDestination( source, destination );
            TimeSpan time2 = DateTime.Now - time;

            return time2.ToString();
        }

        private IMongoCollection<BsonDocument> setupDestination(dataObject _destination)
        {
            destination = _destination;
            
            var mongoClient = new MongoClient( destination.connectionString );
            var db = mongoClient.GetDatabase( destination.database );
            if (destination.dropTable )
                db.DropCollection(destination.table);
            return db.GetCollection<BsonDocument>( destination.table );
        }

        private void setupSource(dataObject _source)
        {
            source = _source;
            using (SqlConnection connection = new SqlConnection(source.connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                setMInMaxValues();
            }
        }
        private void setMInMaxValues()
        {
            using (SqlConnection connection = new SqlConnection( source.connectionString))
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
        private void getSourceData( Int64 lowBound, Int64 highBound)
        {
            SqlConnection connection = new SqlConnection(source.connectionString);
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText =string.Format("select top 10 * from {0} where {1} between {2} and {3} ", source.table, source.key, lowBound, highBound);
                connection.Open();
                sourceData  =command.ExecuteReader();

               // return sourceData;
            
        }

        private void exportFromSourceToDestination(dataObject _source, dataObject _destination)
        {
            
            setupSource(_source );
            var destinationData = setupDestination(_destination);

            List<BsonDocument> lista = new List<BsonDocument>();
            int j = 0;
            Int64 x = minValue;

            while (x <= maxValue)
            {
                getSourceData( x, x + source.interval);
                
                try
                {
                    //Escribir los records en mongo
                    while (sourceData.Read())
                    {
                        Dictionary<string, string> values = new Dictionary<string, string>();
                        for (int i = 0; i < sourceData.FieldCount; i++)
                        {
                            values.Add(sourceData.GetName(i), sourceData.GetValue(i).ToString());
                        }

                        lista.Add(new BsonDocument(values));
                        if (j % destination.interval == 0)
                        {
                            if (lista.Count > 0)
                            {
                                destinationData.InsertMany(lista);
                                lista.Clear();
                            }
                        }
                        j++;
                    }
                    if (lista.Count > 0)
                    {
                        destinationData.InsertMany(lista);
                        lista.Clear();
                    }

                }
                finally
                {
                    // Always call Close when done reading.
                    sourceData.Close();
                }
                x = x + 1 + source.interval;
            }

        }


    }

     
    
}
