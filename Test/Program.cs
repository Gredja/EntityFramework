using Test.Models;
using Test;

using var db = new ApplicationContext();
// создаем два объекта User
var tom = new User { Name = "Tom", Age = 33 };
var alice = new User { Name = "Alice", Age = 26 };

// добавляем их в бд
db.Users.Add(tom);
db.Users.Add(alice);

db.SaveChanges();

Console.WriteLine("Объекты успешно сохранены");

// получаем объекты из бд и выводим на консоль
var users = db.Users.ToList();

Console.WriteLine("Список объектов:");

foreach (var u in users)
{
    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
}