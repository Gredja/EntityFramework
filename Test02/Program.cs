using Microsoft.EntityFrameworkCore;
using Test02;

User? user = null;
using (var db = new HelloappContext())
{
    // получаем объект
    user = db.Users.FirstOrDefault();
    Console.WriteLine("Данные до редактирования:");
    var users = db.Users.ToList();
    foreach (var u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }

    // db.Users.ExecuteUpdate(s => s.SetProperty(e => e.Age, e => e.Age + 1));

}


// Редактирование
using (var db = new HelloappContext())
{
    // Редактирование
    if (user != null)
    {
        user.Name = "Sam";
        user.Age = 33;
        db.Users.Update(user);
        db.SaveChanges();
    }
    // выводим данные после обновления
    Console.WriteLine("\nДанные после редактирования:");
    var users = db.Users.ToList();
    foreach (var u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }
}