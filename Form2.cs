using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace taskManagement
{
    public partial class Form2 : Form
    {
        private static Form2 f;
        public static Form2 GetSingle()
        {
            if (f == null || f.IsDisposed)
            {
                f = new Form2();
            }
            return f;
        }
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //读入目录树
            string path = @"../data/";
            this.listView.Items.Clear();
            string[] files = Directory.GetFiles(path);
            ListViewItem item = new ListViewItem();
            foreach (string file in files)
            {
                item = new ListViewItem();
                item.Text = Path.GetFileName(file);
                item.Tag = Path.GetFullPath(file);
                this.listView.Items.Add(item);
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //查看内容
            if (this.listView.SelectedItems.Count > 0)
            {
                string path = this.listView.FocusedItem.Tag.ToString();
                using (FileStream stream = new FileStream(path, FileMode.Open))
                {
                    byte[] buffer = new byte[1024 * 10];
                    stream.Read(buffer, 0, buffer.Length);
                    this.label1.Text = Encoding.Default.GetString(buffer);
                }
            }
        }
    }
}
