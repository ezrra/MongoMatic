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

            List<String> listaGrupos = grupos();

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
                        Dictionary<string, dynamic> values = new Dictionary<string, dynamic>();
                        for (int i = 0; i < sourceData.FieldCount; i++)
                        {
                            if (listaGrupos.Contains(sourceData.GetName(i))) {

                                var valor = valorDelGrupo(sourceData.GetName(i), "PREMIUM");

                                values.Add(sourceData.GetName(i), valor);

                                // Console.WriteLine("Si hay grupo: " + sourceData.GetName(i));
                            } else
                            {

                                values.Add(sourceData.GetName(i), sourceData.GetValue(i));
                            }
                            

                            
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

        public List<string> grupos ()
        {
            var list = new List<String>();

            list.Add("grupo02");

            return list;
        }

        public string valorDelGrupo(string grupo, string valor) {

            var builder = Builders<BsonDocument>.Filter;

            var filters = builder.Eq("grupo", grupo) & builder.Eq("valorOriginal", valor);

            var mongoClient = new MongoClient(this.destination.connectionString);

            var db = mongoClient.GetDatabase(this.destination.database);

            // if (destination.dropTable)
            //     db.DropCollection(destination.table);
            // return db.GetCollection<BsonDocument>(destination.table);

            var collection = db.GetCollection<BsonDocument>("trans");

            var document = collection.Find(filters).First();

            // Console.WriteLine(document["valorReemplazo"]);

            return document["valorReemplazo"].ToString(); // document.ToString();
        }


    }

     
    
}
