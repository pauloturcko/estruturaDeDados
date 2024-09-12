using ListaGenerica;
List<double> numbers = new List<double>();

do
{
    Console.WriteLine("Informe um número:");
    string? numberStr = Console.ReadLine();
    
    //Validando a entrada do usuário
    if(!double.TryParse(numberStr, out double number))
    {
        break;
    }
    numbers.Add(number);
    Console.WriteLine( $"A média dos valores é {numbers.Average()}" );

}
while(true);

// -- Lista de Pessoas
List<Person> people = new List<Person>();
Person p1 = new Person();
p1.Name = "Pica-Pau";
p1.Age = 17;
p1.Country = CountryEnum.USA;
people.Add(p1);

people.Add( new Person() {
    Name = "Pé-De-Pano",
    Age = 10,
    Country = CountryEnum.PY,
});

Person p3 = new Person(){
    Name = "Hulk",
    Age= 30,
    Country = CountryEnum.IT,
};
people.Add(p3);

// Formas de Percorrer a Lista Genérica
foreach(Person p in people){
    Console.WriteLine(p.Name);
}
// Com FOREACH

for(int i = 0; i < people.Count; i++) {
    Console.WriteLine($"Nome: {people[i].Age}");
}
// Com FOR


// O ponto de interrogação (null label operator) na string permite que a variável seja nula
// Uma operação booleana por padrão é FALSE