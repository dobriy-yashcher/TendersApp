using MongoDB.Bson;
using TendersApp.Enums;

namespace TendersApp.Documents
{
    public class Project
    {
        public ObjectId Id { get; set; }
        public ObjectId DeveloperId { get; set; }
        public ObjectId CustomerId { get; set; }
        public ObjectId DesignerId { get; set; }
        public string Name { get; set; }
        public List<Document> Documents { get; set; } = new List<Document>();
        public List<Document> ProjecterDocuments { get; set; } = new List<Document>();
        public TypesOfProject Type { get; set; }

        public Project()
        {
            
        }

        public Project(ObjectId customerId, ObjectId developerId, ObjectId designerId, TypesOfProject type)
        {
            DeveloperId = developerId;
            CustomerId = designerId;
            DesignerId = designerId;
            Type = type;
        }
    }

}
