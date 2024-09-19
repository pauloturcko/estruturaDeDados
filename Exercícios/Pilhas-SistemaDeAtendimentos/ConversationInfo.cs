using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pilhas_SistemaDeAtendimentos
{
    public class ConversationInfo
    {
        private int _count = 0;
        public Queue<OnlineService>? Service { get; set; }

    }
}