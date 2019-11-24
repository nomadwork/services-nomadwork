using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nomadwork.Infra.Data.ObjectData.Schemes
{
    public class EstablishmmentDetailsScheme
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public long EstablishmmentId { get; set; }


        public List<ReturnTemplate> Age { get; set; }
        public List<ReturnTemplate> Gender { get; set; }


      
    


    }

    public class ReturnTemplate
    {
        public string name { get; set; }
        public int value { get; set; }
    }
}
