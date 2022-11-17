using MongoDB.Bson;
using MongoDB.Driver;
using TendersApp.Users;
using TendersApp.Documents;

namespace TendersApp.Data
{
    public class MongoDb
    {
        public User? currentUser;
        static MongoClient client = new MongoClient("mongodb://localhost");
        static IMongoDatabase database = client.GetDatabase("Users");

        public void Save<TEntity>(TEntity entity)
        {
            var collection = database.GetCollection<TEntity>(typeof(TEntity).Name);
            collection.InsertOne(entity);
        }
        public static void AddCustomerToDataBase(Customer customer)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            var collection = database.GetCollection<User>("CustomerCollection");
            collection.InsertOne(customer);
        }

        public static void AddDesignerToDataBase(Designer designer)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            var collection = database.GetCollection<User>("DesignerCollection");
            collection.InsertOne(designer);
        }
        public static void AddDeveloperToDataBase(Developer developer)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            var collection = database.GetCollection<User>("DeveloperCollection");
            collection.InsertOne(developer);
        }

        public Customer CheckLoginForCustomer(string login)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            var filter = Builders<Customer>.Filter.Eq("Login", login);
            var collection = database.GetCollection<Customer>("CustomerCollection");
            return collection.Find(filter).FirstOrDefault();
        }

        public Designer CheckLoginForDesigner(string login)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            var filter = Builders<Designer>.Filter.Eq("Login", login);
            var collection = database.GetCollection<Designer>("DesignerCollection");
            return collection.Find(filter).FirstOrDefault();
        }

        public  Developer CheckLoginForDeveloper(string login)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            var filter = Builders<Developer>.Filter.Eq("Login", login);
            var collection = database.GetCollection<Developer>("DeveloperCollection");
            return collection.Find(filter).FirstOrDefault();
        }

        public User? CheckLogins(string login)
        {
            var loginCustomer = CheckLoginForCustomer(login);
            var loginDesigner = CheckLoginForDesigner(login);
            var loginDeveloper = CheckLoginForDeveloper(login);

            if (loginCustomer != null)
            {
                return loginCustomer;
            }
            if (loginDesigner != null)
            {
                return loginDesigner;
            }
            if (loginDeveloper != null)
            {
                return loginDeveloper;
            }

            return null;
        }

        public void UpdateCustomer(Customer user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            var filter = Builders<Customer>.Filter.Eq("Login", user.Login);
            var collection = database.GetCollection<Customer>("CustomerCollection");
            collection.ReplaceOne(filter, user);
        }

        public void UpdateDeveloper(Developer user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            var filter = Builders<Developer>.Filter.Eq("Login", user.Login);
            var collection = database.GetCollection<Developer>("DeveloperCollection");
            collection.ReplaceOne(filter, user);
        }

        public void UpdateDesigner(Designer user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            var filter = Builders<Designer>.Filter.Eq("Login", user.Login);
            var collection = database.GetCollection<Designer>("DesignerCollection");
            collection.ReplaceOne(filter, user);
        }

        public void AddProjectToDataBase(Project project)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Documents");
            var collection = database.GetCollection<Project>("ProjectCollection");
            collection.InsertOne(project);
        }

        public void AddDocumentToDataBase(Document document)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Documents");
            var collection = database.GetCollection<Document>("DocumentCollection");
            collection.InsertOne(document);
        }

        public List<Project> GetProjects()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Documents");
            return database.GetCollection<Project>("ProjectCollection").Find(new BsonDocument()).ToList();
        }

        public List<Customer> FindCustomers()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            var filter = new BsonDocument();
            var collection = database.GetCollection<Customer>("CustomerCollection");
            return collection.Find(filter).ToList();
        }

        public List<Developer> FindDevelopers()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            var filter = new BsonDocument();
            var collection = database.GetCollection<Developer>("DeveloperCollection");
            return collection.Find(filter).ToList();
        }

        public List<Designer> FindProjecters()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            var filter = new BsonDocument();
            var collection = database.GetCollection<Designer>("DesignerCollection");
            return collection.Find(filter).ToList();
        }

        public Customer FindCustomerById(ObjectId id)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            var filter = Builders<Customer>.Filter.Eq("_id", id);
            var collection = database.GetCollection<Customer>("CustomerCollection");
            return collection.Find(filter).FirstOrDefault();
        }

        public Designer FindProjecterById(ObjectId id)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            var filter = Builders<Designer>.Filter.Eq("_id", id);
            var collection = database.GetCollection<Designer>("DesignerCollection");
            return collection.Find(filter).FirstOrDefault();
        }

        public Developer FindDeveloperById(ObjectId id)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            var filter = Builders<Developer>.Filter.Eq("_id", id);
            var collection = database.GetCollection<Developer>("DeveloperCollection");
            return collection.Find(filter).FirstOrDefault();
        }






    }
}
