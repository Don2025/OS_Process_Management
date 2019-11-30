using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskManagement
{
    class ReadyQueue    //就绪队列
    {
        static public PCB pcbStart { set; get; }
        static public PCB pcbEnd { set; get; }

        static ReadyQueue()   //就绪队列初始化
        {
            pcbStart = null;
            pcbEnd = null;
        }

        public static void Add(PCB pcb)    //将进程中就绪的文件添加到就绪队列
        {
            pcb.State = emState.ready;
            if (pcbEnd == null && pcbStart == null)    //若就绪队列为空就添加到队首
            {
                pcbStart = pcb;
                pcbEnd = pcb;
            }
            else    //否则添加到就绪队列文件末尾的下一个
            {
                pcbEnd.next = pcb;
                pcbEnd = pcb;
            }
            pcbEnd.next = null;     //将就绪队列的对位置空
        }

        public static PCB Get()
        {
            if (pcbEnd == null && pcbStart == null)
            {
                return null;
            }
            else   //就绪队列不为空时就将队首取出进程
            {
                PCB pcbTemp = pcbStart;
                pcbStart = pcbStart.next;
                if (pcbStart == null) pcbEnd = null;   //若取出队首后为空就将队列置空
                return pcbTemp;
            }
        }

        public static void End()
        {
            pcbStart = null;
            pcbEnd = null;
        }
    }
}