using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace taskManagement
{
    class PCB   //进程控制块
    {
        public int DR { set; get; }    //数据缓存寄存器
        public string Name { set; get; }    //进程标识
        public int Number { set; get; }     //进程编号
        public int PC { get; set; }     //指令位置
        public emState State { get; set; }    //进程状态
        public char Event { get; set; }     //阻塞原因
        public int Timer { get; set; }     //时间片
        public PCB next { get; set; }     //下一个进程
        public string Program { set; get; }     //程序内容
        public string path { set; get; }     //路径
        public int pos { get; set; }

        public PCB(string path, int number)
        {
            this.Name = Path.GetFileName(path);     //获取文件名字
            this.Number = number;      //编号
            this.State = emState.ready;      //获取就绪队列
            //使用文件流打开现有文件
            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                this.path = path;
                byte[] buffer = new byte[1024 * 10];
                stream.Read(buffer, 0, buffer.Length);   //返回本次实际读取到的字节数 
                this.Program = Encoding.Default.GetString(buffer).Replace("\n", "").Replace("\r", "").Trim();   //删除字符串中换行和回车符，以及首尾空格
            }
            this.PC = 0;
            this.DR = 0;
        }
    }
}
