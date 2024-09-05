using System.Collections;

// Utilizando a Lista Simples
ArrayList arrList = new ArrayList(); // Não tem tamanho definido e pode ir adicionando coisas conforme seja necessário
arrList.Add(5);
arrList.Add("José");

// É possível adicionar um conjunto de valores de uma só vez
arrList.AddRange(new int[] { 1, 2, 3,});
// O método .Add() insere o valor ao final da Lista

arrList.Insert(0, 15);
// Já o método Insert(), permite incluir o valor desejado na posição especificada no primeiro parâmetro;

// Lendo valores da lista
object primeiro = arrList[0]!;
int quarto = (int)arrList[3]!;

// Percorrendo a lista com foreach
foreach(object obj in arrList)
{
    Console.WriteLine(obj);
}

// Obtendo o tamanho total da lista
int tamanho = arrList.Count; // Quantos elementos tem
// Obter a capacidade
int capacidade = arrList.Capacity; // Quantos elementos podem ser armazenados

// Percorrendo no modo clássico
for(int i = 0; i < arrList.Count; i++)
{
    Console.Write( $" | {arrList[i]}");
}

// Recursos importantes da Lista
// Verificar se um valor é contido na lista
bool contemNome = arrList.Contains("José");
if(!contemNome) Console.WriteLine("Valor Inexistente.");

// Para saber o índice que contém o valor buscado

// Neste caso se o valor existir na lista ele retorna o índice (Numero Inteiro)
// Caso o valor não exista na lista retorna -1
int indiceDoValor = arrList.IndexOf("José");
if(indiceDoValor >= 0) 
Console.WriteLine( $"O valor procurado está em [{indiceDoValor}]");
else Console.WriteLine("O valor não existe");

// É possível também remover itens da lista
arrList.Remove("José"); // Remove pelo valor
arrList.RemoveAt(4); // Remove pelo índice
arrList.RemoveRange(0,2); // O primeiro parâmetro indica o primeiro índice e o segundo é quantas casas após o índice serão removidos