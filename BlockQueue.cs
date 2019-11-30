using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskManagement
{
    class BlockQueue    //阻塞队列
    {
        static public PCB pcbStart { set; get; }
        static public PCB pcbEnd { set; get; }

        static BlockQueue()
        {
            pcbStart = null;
            pcbEnd = null;
        }

        public static void Add(PCB pcb)
        {
            pcb.State = emState.block;
            if (pcbEnd == null && pcbStart == null)
            {
                pcbStart = pcb;
                pcbEnd = pcb;
            }
            else
            {
                pcbEnd.next = pcb;
                pcbEnd = pcb;
            }
            pcbEnd.next = null;
        }

        public static void End()
        {
            pcbStart = null;
            pcbEnd = null;
        }
    }
}
