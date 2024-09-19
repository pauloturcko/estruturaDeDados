using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pilhas_SistemaDeAtendimentos
{
    public class OnlineService
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string? Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Consultant { get; set; }
    
    }
}