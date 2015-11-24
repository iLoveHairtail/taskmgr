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
            Thread readT = new Thread(readr0);
            readT.Start();

        }
        public static void readr0()
        {
            SecurityAttribute sa;
            Overlapped lpOverlapped = 0;
            winAPI.CreateEvent(sa, 0, 0, lpOverlapped);
            

        }
    }
}


public class winAPI
{
    public struct SystemTime
    {
        public ushort wYear;
        public ushort wMonth;
        public ushort wDayOfWeek;
        public ushort wDay;
        public ushort wHour;
        public ushort wMinute;
        public ushort wSecond;
        public ushort wMilliseconds;
    }

    public struct _SecurityAttributes 
    {
        UInt32 nLength;                 //结构体的大小，可用SIZEOF取得
        IntPtr lpSecurityDescriptor;    //安全描述符
        Int32 bInheritHandle;           //安全描述的对象能否被新创建ÆÆ的进程继承
    } 

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern IntPtr CreateFile
    (
        String lpFileName,                  // file name
        uint dwDesiredAccess,               // access mode
        uint dwShareMode,                   // share mode
        SecurityAttributes attr,            // SD
        uint dwCreationDisposition,         // how to create
        uint dwFlagsAndAttributes,          // file attributes
        uint hTemplateFile                  // handle to template file
    );

    [DllImport("kernel32.dll")]
    public static extern IntPtr CreateEvent
    (
        SecurityAttributes sa,         // 安全属性
        Int32 bManualReset,         // 复位方式
        Int32 bInitialState,        // 初始状态
        Overlapped lpName               // 对象名称
    );



}