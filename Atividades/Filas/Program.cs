// Uma fila é a estrutura de dados que pode ser aplicada para representar a fila de atendimento da cantina. As pessoas que chegam entram no final da fila, e as primeiras que chegam são as primeiras a serem atendidas.

// A função ENQUEUE é responsável por adicionar novos elementos à fila

// A função DEQUEUE remove elementos da fila

// Desta forma, obedece o princípio do FIFO => First In, First Out

using Filas;

Random random= new Random();

CallCenter center = new();
center.Call(1234);
center.Call(1364);
center.Call(9123);
center.Call(2855);

while(center.AreWaitingCalls())
{
    Thread.Sleep(3000);
    IncomingCall call = center.Answer("Michal");
    Console.WriteLine($"{DateTime.Now:HH:mm:ss} Chamado: #{call.Id} De: {call.ClientId} Atendido por: {call.Consultant}");
    Thread.Sleep(random.Next(1000, 10000));
    center.End(call);
    Console.WriteLine(
        @$"Chamado: {call.Id}
            Encerrado às: {call.EndTime}"
    );
}