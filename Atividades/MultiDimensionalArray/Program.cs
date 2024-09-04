// Criando um vetor multidimensional com 5 linhas e 2 colunas

int [,] numbers = new int [5,2];

// Criando um vetor tridimensional

int [,,] triNumbers = new int [5,4,3];

// Podemos inicializar os valores do vetor no momento de sua declaração
int [,] iniNumbers = new int [,]
{
    {9,5,-9},
    {12,3,95},
    {6,32,16},
    {75,23,-15},
    {75,252,852}
};

// Para acessar os valores contigos neste tipo de variável
int valor = iniNumbers[0,1]; // Aqui acessamos a linha 0 e a coluna 1, neste caso o número 5
Console.WriteLine ( $"iniNumbers[0,1] == {valor}");

int maxNumber = iniNumbers[0, 0];
int maxLin = 0;
int maxCol = 0;

for (int linha = 0; linha < iniNumbers.GetLength(0); linha++)
{
    for (int coluna = 0; coluna < iniNumbers.GetLength(1); coluna++)
    {
        if (iniNumbers[linha, coluna] > maxNumber)
        {
            maxNumber = iniNumbers[linha, coluna];
            maxLin = linha;
            maxCol = coluna;
        }
    }
}

Console.WriteLine($"O maior número é {maxNumber} na posição ({maxLin}, {maxCol})");