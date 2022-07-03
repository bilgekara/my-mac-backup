using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FreeCourse.Services.Catalog.Models
{
	public class Course
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        public int  Price { get; set; }

		// identity benim için user id alanını string ve random bir değerle üretecek
        public string UserId { get; set; }

        public string Picture { get; set; }

		[BsonRepresentation(BsonType.DateTime)]
        public DateTime CreatedTime { get; set; }

        public Feature Feature { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryId { get; set; }

        /* kursun bağlı olduğu kategori var
         * bunu kodlama esnasında kullanıcam
         * productları dönerken kategorileri de donmek istiyorum 
         * mongo da karşılığı olmayacak
         * 
         */
        [BsonIgnore]
        public Category Category { get; set; }
    }
}

