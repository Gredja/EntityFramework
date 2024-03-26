using Microsoft.EntityFrameworkCore;
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

//using var db = new UsersdbContext();

//var usa = new Country { Name = "USA" };
//var japan = new Country { Name = "Japan" };
//db.Countries.AddRange(usa, japan);

//// добавляем начальные данные
//var microsoft = new Company { Name = "Microsoft", Country = usa };
//var sony = new Company { Name = "Sony", Country = japan };
//db.Companies.AddRange(microsoft, sony);


//var tom = new User { Name = "Tom", Company = microsoft };
//var bob = new User { Name = "Bob", Company = sony };
//var alice = new User { Name = "Alice", Company = microsoft };
//var kate = new User { Name = "Kate", Company = sony };
//db.Users.AddRange(tom, bob, alice, kate);

//db.SaveChanges();

// получение данных
using var db1 = new UsersdbContext();

var company = db1.Companies.FirstOrDefault();


if (company != null)
{
    //db1.Users.Where(u => u.CompanyId == company.Id).Load();

    db1.Entry(company).Collection(c => c.Users).Load();

    Console.WriteLine($"Company: {company.Name}");
    foreach (var u in company.Users)
        Console.WriteLine($"User: {u.Name}");
}

// получение данных
using var db2 = new UsersdbContext();
// получаем пользователей
var users = db2.Users
    .Include(u => u.Company)  // подгружаем данные по компаниям
    .ThenInclude(c => c!.Country)    // к компаниям подгружаем данные по странам
    .ToList();
foreach (var user in users)
    Console.WriteLine($"{user.Name} - {user.Company?.Name} - {user.Company?.Country?.Name}");