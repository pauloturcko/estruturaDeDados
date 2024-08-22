// Declarando Variável
using aula01;

int number;
// Atribuindo Valor
number = 10;

// Declarando Consatnte
const int DAYS_IN_WEEK = 7;

// Impirindo String Concatenada
Console.WriteLine( $"A semana tem {DAYS_IN_WEEK} dias.");

// new TipoEnumerador() -> Invoca o método construtor do objeto
// Toda classe tem o seu construtor padrão implícito sem argumentos/parâmetros
// É possível sobrescrever este método (overhide) especificando argumentos, todavia, se o fizermos, perdemos o original implícito e precisaremos defini-lo explicitamente
TipoEnumerador tipoEnum = new TipoEnumerador(); //Este é um Método Construtor

TipoEnumerador.language enumEnglish = tipoEnum.GetLanguageEnum("inglês");

Console.WriteLine( $"O enum de inglês é {enumEnglish}" );