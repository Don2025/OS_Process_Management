using System.Windows.Forms;

namespace taskManagement
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_on = new System.Windows.Forms.Button();
            this.button_num0 = new System.Windows.Forms.Button();
            this.button_num1 = new System.Windows.Forms.Button();
            this.button_num2 = new System.Windows.Forms.Button();
            this.button_num3 = new System.Windows.Forms.Button();
            this.button_num4 = new System.Windows.Forms.Button();
            this.button_num5 = new System.Windows.Forms.Button();
            this.button_num6 = new System.Windows.Forms.Button();
            this.button_num7 = new System.Windows.Forms.Button();
            this.button_num8 = new System.Windows.Forms.Button();
            this.button_num9 = new System.Windows.Forms.Button();
            this.button_result = new System.Windows.Forms.Button();
            this.listView_readyQueue = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listView_blockQueue = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelInstruction = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelRunning = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.labelTimer = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.labelNum = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.labelLastResult = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelRedText = new System.Windows.Forms.Label();
            this.labelBlueText = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.labelRed = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_on
            // 
            this.button_on.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_on.Location = new System.Drawing.Point(8, 15);
            this.button_on.Name = "button_on";
            this.button_on.Size = new System.Drawing.Size(68, 38);
            this.button_on.TabIndex = 0;
            this.button_on.Text = "开机";
            this.button_on.UseVisualStyleBackColor = true;
            this.button_on.Click += new System.EventHandler(this.Button_on_Click);
            // 
            // button_num0
            // 
            this.button_num0.Location = new System.Drawing.Point(9, 140);
            this.button_num0.Name = "button_num0";
            this.button_num0.Size = new System.Drawing.Size(30, 30);
            this.button_num0.TabIndex = 2;
            this.button_num0.Text = "0";
            this.button_num0.UseVisualStyleBackColor = true;
            this.button_num0.Click += new System.EventHandler(this.Button_process_Click);
            // 
            // button_num1
            // 
            this.button_num1.Location = new System.Drawing.Point(9, 104);
            this.button_num1.Name = "button_num1";
            this.button_num1.Size = new System.Drawing.Size(30, 30);
            this.button_num1.TabIndex = 3;
            this.button_num1.Text = "1";
            this.button_num1.UseVisualStyleBackColor = true;
            this.button_num1.Click += new System.EventHandler(this.Button_process_Click);
            // 
            // button_num2
            // 
            this.button_num2.Location = new System.Drawing.Point(45, 104);
            this.button_num2.Name = "button_num2";
            this.button_num2.Size = new System.Drawing.Size(30, 30);
            this.button_num2.TabIndex = 4;
            this.button_num2.Text = "2";
            this.button_num2.UseVisualStyleBackColor = true;
            this.button_num2.Click += new System.EventHandler(this.Button_process_Click);
            // 
            // button_num3
            // 
            this.button_num3.Location = new System.Drawing.Point(82, 104);
            this.button_num3.Name = "button_num3";
            this.button_num3.Size = new System.Drawing.Size(30, 30);
            this.button_num3.TabIndex = 5;
            this.button_num3.Text = "3";
            this.button_num3.UseVisualStyleBackColor = true;
            this.button_num3.Click += new System.EventHandler(this.Button_process_Click);
            // 
            // button_num4
            // 
            this.button_num4.Location = new System.Drawing.Point(9, 67);
            this.button_num4.Name = "button_num4";
            this.button_num4.Size = new System.Drawing.Size(30, 30);
            this.button_num4.TabIndex = 6;
            this.button_num4.Text = "4";
            this.button_num4.UseVisualStyleBackColor = true;
            this.button_num4.Click += new System.EventHandler(this.Button_process_Click);
            // 
            // button_num5
            // 
            this.button_num5.Location = new System.Drawing.Point(45, 67);
            this.button_num5.Name = "button_num5";
            this.button_num5.Size = new System.Drawing.Size(30, 30);
            this.button_num5.TabIndex = 7;
            this.button_num5.Text = "5";
            this.button_num5.UseVisualStyleBackColor = true;
            this.button_num5.Click += new System.EventHandler(this.Button_process_Click);
            // 
            // button_num6
            // 
            this.button_num6.Location = new System.Drawing.Point(82, 67);
            this.button_num6.Name = "button_num6";
            this.button_num6.Size = new System.Drawing.Size(30, 30);
            this.button_num6.TabIndex = 8;
            this.button_num6.Text = "6";
            this.button_num6.UseVisualStyleBackColor = true;
            this.button_num6.Click += new System.EventHandler(this.Button_process_Click);
            // 
            // button_num7
            // 
            this.button_num7.Location = new System.Drawing.Point(9, 31);
            this.button_num7.Name = "button_num7";
            this.button_num7.Size = new System.Drawing.Size(30, 30);
            this.button_num7.TabIndex = 9;
            this.button_num7.Text = "7";
            this.button_num7.UseVisualStyleBackColor = true;
            this.button_num7.Click += new System.EventHandler(this.Button_process_Click);
            // 
            // button_num8
            // 
            this.button_num8.Location = new System.Drawing.Point(45, 31);
            this.button_num8.Name = "button_num8";
            this.button_num8.Size = new System.Drawing.Size(30, 30);
            this.button_num8.TabIndex = 10;
            this.button_num8.Text = "8";
            this.button_num8.UseVisualStyleBackColor = true;
            this.button_num8.Click += new System.EventHandler(this.Button_process_Click);
            // 
            // button_num9
            // 
            this.button_num9.Location = new System.Drawing.Point(81, 31);
            this.button_num9.Name = "button_num9";
            this.button_num9.Size = new System.Drawing.Size(30, 30);
            this.button_num9.TabIndex = 11;
            this.button_num9.Text = "9";
            this.button_num9.UseVisualStyleBackColor = true;
            this.button_num9.Click += new System.EventHandler(this.Button_process_Click);
            // 
            // button_result
            // 
            this.button_result.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_result.Location = new System.Drawing.Point(45, 140);
            this.button_result.Name = "button_result";
            this.button_result.Size = new System.Drawing.Size(67, 30);
            this.button_result.TabIndex = 12;
            this.button_result.Text = "查看结果";
            this.button_result.UseVisualStyleBackColor = true;
            this.button_result.Click += new System.EventHandler(this.Button_result_Click);
            // 
            // listView_readyQueue
            // 
            this.listView_readyQueue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_readyQueue.HideSelection = false;
            this.listView_readyQueue.HoverSelection = true;
            this.listView_readyQueue.Location = new System.Drawing.Point(6, 21);
            this.listView_readyQueue.Name = "listView_readyQueue";
            this.listView_readyQueue.Size = new System.Drawing.Size(185, 254);
            this.listView_readyQueue.TabIndex = 22;
            this.listView_readyQueue.TabStop = false;
            this.listView_readyQueue.UseCompatibleStateImageBehavior = false;
            this.listView_readyQueue.View = System.Windows.Forms.View.Details;
            this.listView_readyQueue.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ListView_readyQueue_ColumnWidthChanging);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "进程名称";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "进程编号";
            this.columnHeader2.Width = 90;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listView_readyQueue);
            this.groupBox4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(5, 199);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(198, 281);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "就绪队列";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listView_blockQueue);
            this.groupBox5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(208, 199);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(370, 282);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "阻塞队列";
            // 
            // listView_blockQueue
            // 
            this.listView_blockQueue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_blockQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_blockQueue.HideSelection = false;
            this.listView_blockQueue.Location = new System.Drawing.Point(3, 22);
            this.listView_blockQueue.Name = "listView_blockQueue";
            this.listView_blockQueue.Scrollable = false;
            this.listView_blockQueue.Size = new System.Drawing.Size(364, 257);
            this.listView_blockQueue.TabIndex = 0;
            this.listView_blockQueue.UseCompatibleStateImageBehavior = false;
            this.listView_blockQueue.View = System.Windows.Forms.View.Details;
            this.listView_blockQueue.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ListView_readyQueue_ColumnWidthChanging);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "进程名称";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "进程编号";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "阻塞原因";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "剩余时间";
            this.columnHeader6.Width = 90;
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox10.Location = new System.Drawing.Point(583, 9);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(238, 472);
            this.groupBox10.TabIndex = 25;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "内存";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelInstruction);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(8, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 58);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "正在执行的指令";
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Location = new System.Drawing.Point(27, 26);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(0, 16);
            this.labelInstruction.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labelRunning);
            this.groupBox6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.Location = new System.Drawing.Point(163, 69);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(146, 58);
            this.groupBox6.TabIndex = 27;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "正在运行的进程";
            // 
            // labelRunning
            // 
            this.labelRunning.AutoSize = true;
            this.labelRunning.Location = new System.Drawing.Point(24, 28);
            this.labelRunning.Name = "labelRunning";
            this.labelRunning.Size = new System.Drawing.Size(0, 16);
            this.labelRunning.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.labelTimer);
            this.groupBox7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox7.Location = new System.Drawing.Point(82, 9);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(76, 58);
            this.groupBox7.TabIndex = 28;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "时间片";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(23, 26);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(0, 16);
            this.labelTimer.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.labelNum);
            this.groupBox9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox9.Location = new System.Drawing.Point(164, 9);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(90, 58);
            this.groupBox9.TabIndex = 29;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "进程编号";
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(13, 28);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(0, 16);
            this.labelNum.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelResult);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(8, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(115, 60);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "中间结果";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(17, 27);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 16);
            this.labelResult.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.labelLastResult);
            this.groupBox8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox8.Location = new System.Drawing.Point(131, 133);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(126, 60);
            this.groupBox8.TabIndex = 31;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "上一进程结果";
            // 
            // labelLastResult
            // 
            this.labelLastResult.AutoSize = true;
            this.labelLastResult.Location = new System.Drawing.Point(35, 28);
            this.labelLastResult.Name = "labelLastResult";
            this.labelLastResult.Size = new System.Drawing.Size(0, 16);
            this.labelLastResult.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_num0);
            this.groupBox3.Controls.Add(this.button_num7);
            this.groupBox3.Controls.Add(this.button_num1);
            this.groupBox3.Controls.Add(this.button_result);
            this.groupBox3.Controls.Add(this.button_num2);
            this.groupBox3.Controls.Add(this.button_num9);
            this.groupBox3.Controls.Add(this.button_num3);
            this.groupBox3.Controls.Add(this.button_num8);
            this.groupBox3.Controls.Add(this.button_num4);
            this.groupBox3.Controls.Add(this.button_num6);
            this.groupBox3.Controls.Add(this.button_num5);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(451, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(124, 183);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "进程";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(267, 133);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(178, 24);
            this.linkLabel1.TabIndex = 33;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "CopyRight @Don";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::taskManagement.Properties.Resources.旺仔超越坤;
            this.pictureBox1.Location = new System.Drawing.Point(328, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // labelRedText
            // 
            this.labelRedText.AutoSize = true;
            this.labelRedText.Location = new System.Drawing.Point(308, 188);
            this.labelRedText.Name = "labelRedText";
            this.labelRedText.Size = new System.Drawing.Size(77, 12);
            this.labelRedText.TabIndex = 36;
            this.labelRedText.Text = "内存被占用：";
            // 
            // labelBlueText
            // 
            this.labelBlueText.AutoSize = true;
            this.labelBlueText.Location = new System.Drawing.Point(308, 168);
            this.labelBlueText.Name = "labelBlueText";
            this.labelBlueText.Size = new System.Drawing.Size(77, 12);
            this.labelBlueText.TabIndex = 37;
            this.labelBlueText.Text = "内存空闲中：";
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelBlue.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBlue.Location = new System.Drawing.Point(380, 169);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(50, 10);
            this.labelBlue.TabIndex = 38;
            this.labelBlue.Text = "         ";
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelRed.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRed.Location = new System.Drawing.Point(380, 190);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(50, 10);
            this.labelRed.TabIndex = 39;
            this.labelRed.Text = "         ";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel2.Location = new System.Drawing.Point(255, 39);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(72, 16);
            this.linkLabel2.TabIndex = 40;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "查看源码";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 486);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.labelBlueText);
            this.Controls.Add(this.labelRedText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button_on);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(845, 525);
            this.MinimumSize = new System.Drawing.Size(845, 525);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "进程管理器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_on;
        private System.Windows.Forms.Button button_num0;
        private System.Windows.Forms.Button button_num1;
        private System.Windows.Forms.Button button_num2;
        private System.Windows.Forms.Button button_num3;
        private System.Windows.Forms.Button button_num4;
        private System.Windows.Forms.Button button_num5;
        private System.Windows.Forms.Button button_num6;
        private System.Windows.Forms.Button button_num7;
        private System.Windows.Forms.Button button_num8;
        private System.Windows.Forms.Button button_num9;
        private System.Windows.Forms.Button button_result;
        private System.Windows.Forms.ListView listView_readyQueue;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListView listView_blockQueue;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label labelRunning;
        private System.Windows.Forms.Label labelLastResult;
        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.GroupBox groupBox3;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private Label labelRedText;
        private Label labelBlueText;
        private Label labelBlue;
        private Label labelRed;
        private LinkLabel linkLabel2;
    }
}