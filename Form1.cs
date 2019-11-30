using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using System.IO;

namespace taskManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        // CPU线程
        Thread thread;
        public static MemoryManage mm;
        private List<Label> mmm = new List<Label>();//显示内存

        private void Button_on_Click(object sender, EventArgs e)
        {
            if (button_on.Text.ToString().Equals("开机"))   //开机
            {
                button_on.Text = "关机";
                thread = new Thread(CPU);
                thread.IsBackground = true;
                thread.Start();
                mm = new MemoryManage();
                mmm[0].BackColor = Color.FromArgb(255, 0, 0);
                mmm[1].BackColor = Color.FromArgb(255, 0, 0);
            }
            else    //关机
            {
                button_on.Text = "开机";
                if (thread != null)
                {
                    thread.Abort();
                }
                for (int i = 0; i < 128; i++)
                {
                    mmm[i].BackColor = Color.FromArgb(0, 255, 255);
                }
                listView_readyQueue.Items.Clear();
                listView_blockQueue.Items.Clear();
                ReadyQueue.End();
                BlockQueue.End();
            }
        }

        private int DR;
        private char[] IR;
        private int PSW;
        private int PC;
        private int Timer;
        private const int TIME = 5;
        private const int SLEEP = 1000;
        private PCB pcbNow;

        private void CPU()
        {
            if (ReadyQueue.pcbStart == null)
            {
                this.PSW = 4;
                Idle();
            }
            while (true)
            {
                if (this.PSW != 0)
                {
                    #region 时间片到，进程调度 PSW=1
                    if (this.PSW == 1)
                    {
                        this.labelInstruction.Text = "时间片到";
                        this.pcbNow.DR = DR;
                        this.pcbNow.PC = PC;
                        ReadyQueue.Add(this.pcbNow);
                        this.PSW = 4;
                    }
                    #endregion

                    #region 唤醒阻塞进程 PSW=2 PSW=3
                    else if (this.PSW == 2 || this.PSW == 3)
                    {
                        this.labelInstruction.Text = "唤醒进程";
                        wake();
                        if (this.PSW != 4)
                            this.PSW -= 2;
                    }
                    #endregion

                    #region 程序执行软中断,撤销进程，进程调度 PSW>=4
                    else if (this.PSW >= 4)
                    {
                        this.pcbNow = null;
                        this.labelInstruction.Text = "进程调度";
                        if (ReadyQueue.pcbStart == null)
                        {
                            Idle();
                        }
                        this.pcbNow = ReadyQueue.Get();
                        this.PC = this.pcbNow.PC;
                        this.Timer = TIME;
                        this.DR = this.pcbNow.DR;
                        this.pcbNow.State = emState.operation;
                        this.PSW -= 4;
                    }
                    #endregion
                }
                else
                {
                    #region 取PC指令，放入IR寄存器
                    this.IR = new char[4];
                    this.IR[0] = this.pcbNow.Program[this.PC];
                    this.IR[1] = this.pcbNow.Program[this.PC + 1];
                    this.IR[2] = this.pcbNow.Program[this.PC + 2];
                    this.IR[3] = this.pcbNow.Program[this.PC + 3];
                    #endregion

                    #region pc++
                    this.PC += 4;
                    #endregion

                    #region 执行IR指令
                    if (Regex.IsMatch(new string(this.IR), @"x=\d;") == true)
                    {
                        this.DR = Convert.ToInt32(IR[2]) - 48;
                    }
                    else if (Regex.IsMatch(new string(this.IR), @"x\+\+;") == true)
                    {
                        this.DR++;
                    }
                    else if (Regex.IsMatch(new string(this.IR), @"x--;") == true)
                    {
                        this.DR--;
                    }
                    else if (Regex.IsMatch(new string(this.IR), @"![AB]\d;") == true)
                    {
                        this.pcbNow.Event = this.IR[1];
                        this.pcbNow.Timer = Convert.ToInt32(IR[2]) - 48;
                        this.pcbNow.DR = DR;
                        this.pcbNow.PC = PC;
                        BlockQueue.Add(pcbNow);
                        this.PSW = 4;
                    }
                    else if (Regex.IsMatch(new string(this.IR), @"end.") == true)
                    {
                        string path = Path.ChangeExtension(this.pcbNow.path, "out");
                        using (FileStream stream = new FileStream(path, FileMode.Create))
                        {
                            string str = Path.GetFullPath(path) + "\r\n" + "x=" + this.DR.ToString();
                            byte[] buffer = Encoding.UTF8.GetBytes(str);
                            stream.Write(buffer, 0, buffer.Length);
                        }
                        this.labelLastResult.Text = "x = " + DR.ToString();
                        this.PSW = 4;

                        for (int i = mm.used[this.pcbNow.pos].begin / 4; i < (mm.used[this.pcbNow.pos].size + mm.used[this.pcbNow.pos].begin) / 4; i++)
                        {
                            mmm[i].BackColor = Color.FromArgb(0, 255, 255);
                        }
                        mm.recycle(this.pcbNow.pos);

                    }
                    else if (Regex.IsMatch(new string(this.IR), @"gob;") == true)
                    {
                        this.PC = 0;
                    }
                    #endregion

                    #region 时间片--，阻塞进程的时间--
                    this.Timer--;
                    if (this.Timer == 0 && this.PSW == 0) this.PSW = 1;

                    blockTime();
                    #endregion

                    #region 页面更新
                    this.labelNum.Text = pcbNow.Number.ToString();
                    this.labelRunning.Text = pcbNow.Name.ToString();
                    this.labelTimer.Text = this.Timer.ToString();
                    this.labelInstruction.Text = new string(IR);
                    this.labelResult.Text = "x = " + this.DR.ToString();
                    #endregion
                }
                ReadyQueueReset();
                BlockQueueReset();
                //延时；
                Thread.Sleep(SLEEP);
            }
        }

        private int pcbNumber = 1;

        private void Button_process_Click(object sender, EventArgs e)
        {
            if (thread != null)
            {
                string text = sender.ToString();
                text = text.Substring(text.Length - 1, 1);
                string path = @"../data/" + text + ".in";

                int need = 0;   //需要的内存
                //计算所需要的内存
                using (FileStream stream = new FileStream(path, FileMode.Open))
                {
                    byte[] buffer = new byte[1024 * 10];
                    stream.Read(buffer, 0, buffer.Length);
                    String str = Encoding.Default.GetString(buffer).Replace("\n", "").Replace("\r", "").Trim();
                    for (int i = 0; str[i] != '\0'; i++)
                    {
                        need++;
                    }

                }
                //分配内存
                int can = mm.Apply(need);    //can为已分分区下标
                if (can == -1)
                {
                    MessageBox.Show("内存不足！");
                    return;
                }
                PCB pcb = new PCB(path, pcbNumber++);
                for (int i = mm.used[can].begin / 4; i < (mm.used[can].size + mm.used[can].begin) / 4; i++)
                {
                    mmm[i].BackColor = Color.FromArgb(255, 0, 0);
                }
                pcb.pos = can;
                ReadyQueue.Add(pcb);
                //当前进程是闲逛进程时，中断
                if (this.pcbNow.Number == 0)
                {
                    this.PSW = 4;
                }
                ReadyQueueReset();
            }
            else
            {
                MessageBox.Show("请先开机。");
            }
        }

        // 更新就绪队列
        private void ReadyQueueReset()
        {
            lock (this)
            {
                listView_readyQueue.Items.Clear();
                ListViewItem item = null;
                PCB pcb = ReadyQueue.pcbStart;
                while (pcb != null)
                {
                    item = new ListViewItem();
                    item.Text = pcb.Name;
                    item.SubItems.Add(pcb.Number.ToString());
                    listView_readyQueue.Items.Add(item);
                    pcb = pcb.next;
                }
            }
        }


        // 更新阻塞队列
        private void BlockQueueReset()
        {
            lock (this)
            {
                listView_blockQueue.Items.Clear();
                ListViewItem item = null;
                PCB pcb = BlockQueue.pcbStart;
                while (pcb != null)
                {
                    item = new ListViewItem();
                    item.Text = pcb.Name;
                    item.SubItems.Add(pcb.Number.ToString());
                    item.SubItems.Add(pcb.Event.ToString());
                    item.SubItems.Add(pcb.Timer.ToString());
                    listView_blockQueue.Items.Add(item);
                    pcb = pcb.next;
                }
            }
        }


        //闲逛进程
        private void Idle()
        {
            string path = @"idle.bin";
            PCB pcb = new PCB(path, 0);
            pcb.pos = 0;
            ReadyQueue.Add(pcb);
            ReadyQueueReset();
        }

        private void blockTime()
        {
            PCB pcb = BlockQueue.pcbStart;
            while (pcb != null)
            {
                pcb.Timer--;
                if (pcb.Timer == 0)
                {
                    //防止陷入死循环
                    if (this.PSW == 1 || this.PSW == 0 || this.PSW == 4)
                    {
                        this.PSW += 2;
                    }
                }
                pcb = pcb.next;
            }
        }


        // 进程唤醒
        private void wake()
        {
            PCB pcb = new PCB(@"idle.bin", 0);
            pcb.next = BlockQueue.pcbStart;
            while (pcb.next != null)
            {
                if (pcb.next.Timer == 0)
                {
                    if (pcb.next == BlockQueue.pcbStart)
                    {
                        BlockQueue.pcbStart = BlockQueue.pcbStart.next;
                        if (BlockQueue.pcbStart == null) BlockQueue.pcbEnd = null;
                    }
                    PCB temp = pcb.next;
                    pcb.next = temp.next;
                    ReadyQueue.Add(temp);
                }
                else
                    pcb = pcb.next;
            }
            if (BlockQueue.pcbEnd != null)
            {
                BlockQueue.pcbEnd = pcb;
            }
            if (this.pcbNow.Number == 0)
            {
                this.PSW = 4;
            }
        }

        private void Button_result_Click(object sender, EventArgs e)
        {
            Form2 f = Form2.GetSingle();
            f.Show();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://tanyaodan.com");    //访问网站tanyaodan.com
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/Don2025/OS_Process_Management");  //访问github查看源码
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 32; i++)      //载入内存条
            {
                Label label = new Label();
                label.Name = "label" + (4 * i).ToString();
                label.BackColor = Color.FromArgb(0, 255, 255);
                label.Width = 40;
                label.Height = 5;
                label.Location = new Point(25, i * 14 + 25);
                mmm.Add(label);
                this.groupBox10.Controls.Add(label);

                Label label1 = new Label();
                label1.Name = "label" + (4 * i + 1).ToString();
                label1.BackColor = Color.FromArgb(0, 255, 255);
                label1.Width = 40;
                label1.Height = 5;
                label1.Location = new Point(75, i * 14 + 25);
                mmm.Add(label1);
                this.groupBox10.Controls.Add(label1);

                Label label2 = new Label();
                label2.Name = "label" + (4 * i + 2).ToString();
                label2.BackColor = Color.FromArgb(0, 255, 255);
                label2.Width = 40;
                label2.Height = 5;
                label2.Location = new Point(125, i * 14 + 25);
                mmm.Add(label2);
                this.groupBox10.Controls.Add(label2);

                Label label3 = new Label();
                label3.Name = "label" + (4 * i + 3).ToString();
                label3.BackColor = Color.FromArgb(0, 255, 255);
                label3.Width = 40;
                label3.Height = 5;
                label3.Location = new Point(175, i * 14 + 25);
                mmm.Add(label3);
                this.groupBox10.Controls.Add(label3);
            }
        }

        private void ListView_readyQueue_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            // 取消掉正在调整的事件
            e.Cancel = true;
            // 把新宽度恢复到之前的宽度
            e.NewWidth = this.listView_blockQueue.Columns[e.ColumnIndex].Width;
            e.NewWidth = this.listView_readyQueue.Columns[e.ColumnIndex].Width;
        }
    }

    public class MemoryManage
    {
        public struct list
        {
            public int size;
            public int begin;
            public int flag;
        }

        public list[] free = new list[200];
        public list[] used = new list[200];
        public int freecount = 0;
        public int usedcount = 0;

        public MemoryManage()    //初始化
        {

            free[freecount].size = 512 - 8;
            free[freecount].begin = 8;
            free[freecount].flag = 1;
            freecount++;

            used[usedcount].size = 8;
            used[usedcount].begin = 0;
            used[usedcount].flag = 1;
            usedcount++;
        }

        public int Apply(int need)   //参数为需要的内存大小
        {
            int min = 10000, pos = -1, p = -1;
            for (int i = 0; i < freecount; i++)
            {
                if (free[i].flag == 1)
                {
                    if (free[i].size >= need && free[i].size < min)
                    {
                        pos = i;
                        min = free[i].size;
                    }
                }
            }
            if (pos == -1)
                return pos;

            free[pos].size -= need;
            free[pos].begin += need;
            if (free[pos].size == 0)
            {
                free[pos].flag = 0;
            }

            for (int i = 0; i < usedcount; i++)
            {
                if (used[i].flag == 0)
                {
                    p = i;
                    break;
                }
            }
            if (p == -1)
            {
                p = usedcount;
                usedcount++;
            }
            used[p].size = need;
            used[p].begin = free[pos].begin - need;
            used[p].flag = 1;

            return p;
        }

        public void recycle(int pos)   //参数为已分分区的标号
        {
            used[pos].flag = 0;
            int p = -1;
            for (int i = 0; i < freecount; i++)
            {
                if (free[i].flag == 0)
                {
                    p = i;
                }
            }
            if (p == -1)
            {
                p = freecount;
                freecount++;
            }

            free[p].size = used[pos].size;
            free[p].begin = used[pos].begin;
            free[p].flag = 1;

            //合并空闲分区
            sort();

            for (int i = 0; i < freecount - 1; i++)
            {
                if (free[i].flag == 1)
                {
                    int j = i + 1;
                    while (free[j].flag == 0 && j < freecount)
                    {
                        j++;
                    }
                    if (j < freecount)
                    {
                        if (free[i].begin + free[i].size == free[j].begin)
                        {
                            free[i].size += free[j].size;
                            free[j].flag = 0;
                            i--;
                        }
                    }

                }
            }
        }

        public void sort()
        {
            for (int i = 0; i < freecount; i++)
            {
                for (int j = i + 1; j < freecount; j++)
                {
                    if (free[i].begin > free[j].begin)
                    {
                        list temp;
                        temp = free[i];
                        free[i] = free[j];
                        free[j] = temp;
                    }
                }
            }
        }


    }
}