// See https://aka.ms/new-console-template for more information
using replicando_sintaxe_basica.Models;

Person person = new Person();
Console.WriteLine("Digite seu nome: ");
person.Name = Console.ReadLine();
Console.WriteLine("Digite sua idade: ");
person.Age = Convert.ToInt32(Console.ReadLine());
person.Apresentar();