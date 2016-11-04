using System.Runtime.Serialization;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Runtime.Serialization.Formatters.Binary;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using System.Collections.Generic;

namespace dataToMongoDB
{
    public class grupoT
    {
        public ObjectId _id { get; set; }
        public string grupo { get; set; }
        public string valorOriginal { get; set; }
        public string valorReemplazo { get; set; }

    }
    public class transformation
    {
        List<grupoT> lista;
        public transformation(dataObject _destination)
        {
            lista = new List<grupoT>();
            setupMongo(_destination);
        }

        public string filter(string grupo, string find)
        {
            grupoT result = lista.Find(x => x.grupo.Equals(grupo) && x.valorOriginal.Equals(find)) ;
            if (result == null) 
            {
                return find;
            }
            else
            {
                return result.valorReemplazo;
            }
        }
        private void setupMongo(dataObject destination)
        {
            var mongoClient = new MongoClient(destination.connectionString);
            var db = mongoClient.GetDatabase(destination.database);

            var collection = db.GetCollection<BsonDocument>(destination.transformationTable);

            var filter = new BsonDocument();
            var count = 0;

            


            using (var cursor =  collection.FindSync(filter))
            {

                while (cursor.MoveNext())
                {
                    var batch = cursor.Current;
                    foreach (var document in batch)
                    {
                        // process document
                        var obj = BsonSerializer.Deserialize<grupoT>(document);
                        lista.Add(obj);
                        count++;
                    }
                }
            }
        }
    }
}







    