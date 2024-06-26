﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace gRPC.template.features.books.infraestructure.Models;

public class Book
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public string Name { get; set; }
    public string Author { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
}
