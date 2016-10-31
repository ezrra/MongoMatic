﻿using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using MongoDB.Driver;
using MongoDB.Bson;


namespace dataToMongoDB
{

    public enum connectionType  {sqlServer, mySQL };
    public struct dataObject
    {
        public connectionType connType { get; set; }
        public bool dropTable { get; set; }

        public string connectionString { get; set; }
        public Int64 interval { get; set; }
        public string database { get; set; }
        public string table { get; set; }
        public string key { get; set; }
        public string script { get; set; }

    }

   
    public abstract class dataToMongoDBProcess
    {
        protected long minValue;
        protected long maxValue;

        protected dataObject source { get; set; }
        protected dataObject destination { get; set; }
        protected DbDataReader sourceData { get; set; }

        public string export(dataObject source, dataObject destination)
        {
            DateTime time = DateTime.Now;
            exportFromSourceToDestination( source, destination );
            TimeSpan time2 = DateTime.Now - time;

            return time2.ToString();
        }

        protected IMongoCollection<BsonDocument> setupDestination(dataObject _destination)
        {
            destination = _destination;
            
            var mongoClient = new MongoClient( destination.connectionString );
            var db = mongoClient.GetDatabase( destination.database );
            if (destination.dropTable )
                db.DropCollection(destination.table);
            return db.GetCollection<BsonDocument>( destination.table );
        }

        protected abstract void setupSource(dataObject _source);

        protected abstract void setMInMaxValues();
        protected abstract void getSourceData(Int64 lowBound, Int64 highBound);

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
