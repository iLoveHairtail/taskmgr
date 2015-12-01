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
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using myapi;

namespace GMZ_csharp
{
    public partial class GMZ_csharp : Form
    {
        public GMZ_csharp()
        {
            InitializeComponent();
        }

        private void GMZ_csharp_Load(object sender, EventArgs e)
        {
            this.listView_process.SmallImageList = this.imageList_process;

            //插入表头
            ColumnHeader ch = new ColumnHeader();
            ch.Text = "test";
            ch.Width = 60;
            this.listView_process.Columns.Add(ch);

            //插入数据
            this.listView_process.BeginUpdate();
            for (int i = 0; i<100; ++i)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.ImageIndex = i;
                lvi.Text = "subitem" + i;
                lvi.SubItems.Add("第2列,第" + i + "行");
                lvi.SubItems.Add("第3列,第" + i + "行");
                
                this.listView_process.Items.Add(lvi);
            }

            //修改行颜色
            for(int i = 0; i<100; ++i)
            {
                ListViewItem lvi = this.listView_process.Items[i];
                if (i % 2 == 0)
                    lvi.BackColor = Color.Aqua;
                else
                    lvi.BackColor = Color.White;
            }
            this.listView_process.ContextMenuStrip = this.contextMenuStrip_process;
            this.listView_process.EndUpdate();

            //call api
            string exePath = System.Windows.Forms.Application.ExecutablePath, exeName, exeExt;
            exeExt = exePath.Substring(exePath.LastIndexOf("."), exePath.Length - exePath.LastIndexOf("."));
            exeName = Path.GetFileNameWithoutExtension(exePath) + exeExt;
            exePath = exePath.Replace(exeName, "");
            Thread readT = new Thread(r3readr0);
            readT.Start();

        }
        public static void r3readr0()
        {
            api.driverDefine.SECURITY_ATTRIBUTES sa = new api.driverDefine.SECURITY_ATTRIBUTES();
            api.winAPI.CreateEvent(ref sa, false, false, null);
            

        }
    }
}



