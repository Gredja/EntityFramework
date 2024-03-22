using PostgreSQL;
using PostgreSQL.Models;

//using var db = new UsersdbContext();

//var user1 = new User { Name = "Tom", Age = 33 };
//var user2 = new User { Name = "Alice", Age = 26 };

//db.Users.AddRange(user1, user2);
//db.SaveChanges();

//var users = db.Users.ToList();
//Console.WriteLine("Users list:");

//foreach (var u in users)
//{
//    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
//}

using var db = new UsersdbContext();

var company1 = new Company { Name = "Google" };
var company2 = new Company { Name = "Microsoft" };

var user1 = new User { Name = "Tom", Company = company1 };
var user2 = new User { Name = "Bob", Company = company2 };
var user3 = new User { Name = "Sam", Company = company2 };

db.Companies.AddRange(company1, company2);  // добавление компаний
db.Users.AddRange(user1, user2, user3);     // добавление пользователей
db.SaveChanges();

foreach (var user in db.Users.ToList())
{
    Console.WriteLine($"{user.Name} работает в {user.Company?.Name}");
}