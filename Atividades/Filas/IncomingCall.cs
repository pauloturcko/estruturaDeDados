using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filas
{
    // Esta classe representa a fila de chamados em um CallCenter
    public class IncomingCall
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime CallTime  { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Consultant { get; set; }
    }
}

// COMANDOS DE TECLADO ÚTEIS NO VSCODE
    // HOME & END: Navega para o início ou fim da linha.
    // SHIFT + END & SHIFT + HOME: Seleciona a linha toda
    // CTRL + SHIFT + SETAS: Seleciona as palavras