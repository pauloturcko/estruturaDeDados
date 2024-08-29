using System.Reflection.Metadata.Ecma335;
using Aula02;

Person person = new Person();
Console.WriteLine(person.Name);

Person person1= new Person("Paulo Turco", 40);
Console.WriteLine(person1.Name);

Person person2 = new Person();
person2.Name = "Jair Inácio";
person2.Age = 138;
Console.WriteLine(person2.Name);

Person person3 = new Person()
{
    Name = "Lionel Messi",
    Age = 60
};
Console.WriteLine(person3.Name);