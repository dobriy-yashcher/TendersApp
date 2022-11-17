using MongoDB.Bson;

namespace TendersApp.Documents
{
    public class Document
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public bool IsRequired { get; set; }
        public bool IsApproved { get; set; }

        public string FileName { get; set; }
        public byte[]? data;
    }
}
