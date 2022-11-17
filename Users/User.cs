using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;
using TendersApp.Enums;

namespace TendersApp.Users
{
    public class User
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }

        public User(string login, string password, string email, string phoneNumber, Roles role)
        {
            Email = email;
            PhoneNumber = phoneNumber;
            Login = login;
            Password = password;
            Role = role;
        }

        public User()
        {
            
        }

    }
}
