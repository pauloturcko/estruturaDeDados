// Um JaggedArray é também conhecido como vetor de vetores

// [][] Significa que é um vetor de vetores e neste caso [4][] quer dizer que é um vetor de 4 posições contendo vetores de tamanho indefinido
int[][] numbers = new int[4][];

numbers[0] = new int [] { 1, 2, 3,};
numbers[1] = new int [] { 4, 3, 2, 1, 0};
numbers[2] = new int [] { 1, 2, 0};
numbers[3] = new int [] { 57};
numbers[4] = null!;

// Para obter valor de JaggedArray
int valor = numbers[0][2];
Console.WriteLine(valor);

// Para astribuir valor em um JaggedArray
numbers[1][2] = 0;
Console.WriteLine( numbers[1][2] );
