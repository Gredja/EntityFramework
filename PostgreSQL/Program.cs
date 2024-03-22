using PostgreSQL;
using PostgreSQL.Models;

using var db = new UsersdbContext();

var user1 = new User { Name = "Tom", Age = 33 };
var user2 = new User { Name = "Alice", Age = 26 };

db.Users.AddRange(user1, user2);
db.SaveChanges();

var users = db.Users.ToList();
Console.WriteLine("Users list:");

foreach (var u in users)
{
    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
}