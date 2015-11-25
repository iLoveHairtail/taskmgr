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
            //api.driverDefine.SECURITY_ATTRIBUTES sa;
            //api.driverDefine.OVERLAPPED lpOverlapped;
            //api.winAPI.CreateEvent(sa, false, false, lpOverlapped);
            

        }
    }
}


namespace api
{
    class driverDefine
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

        // Service Types (Bit Mask)
        public static readonly UInt32 SERVICE_KERNEL_DRIVER = 0x00000001;
        public static readonly UInt32 SERVICE_FILE_SYSTEM_DRIVER = 0x00000002;
        public static readonly UInt32 SERVICE_ADAPTER = 0x00000004;
        public static readonly UInt32 SERVICE_RECOGNIZER_DRIVER = 0x00000008;
        public static readonly UInt32 SERVICE_WIN32_OWN_PROCESS = 0x00000010;
        public static readonly UInt32 SERVICE_WIN32_SHARE_PROCESS = 0x00000020;
        public static readonly UInt32 SERVICE_INTERACTIVE_PROCESS = 0x00000100;
        public static readonly UInt32 SERVICE_WIN32 =
            SERVICE_WIN32_OWN_PROCESS | SERVICE_WIN32_SHARE_PROCESS;

        public static readonly UInt32 SERVICE_DRIVER =
            SERVICE_KERNEL_DRIVER | SERVICE_FILE_SYSTEM_DRIVER | SERVICE_RECOGNIZER_DRIVER;

        public static readonly UInt32 SERVICE_TYPE_ALL =
            SERVICE_WIN32 | SERVICE_ADAPTER | SERVICE_DRIVER | SERVICE_INTERACTIVE_PROCESS;

        // Start Type
        public static readonly UInt32 SERVICE_BOOT_START = 0x00000000;
        public static readonly UInt32 SERVICE_SYSTEM_START = 0x00000001;
        public static readonly UInt32 SERVICE_AUTO_START = 0x00000002;
        public static readonly UInt32 SERVICE_DEMAND_START = 0x00000003;
        public static readonly UInt32 SERVICE_DISABLED = 0x00000004;

        // Error control type
        public static readonly UInt32 SERVICE_ERROR_IGNORE = 0x00000000;
        public static readonly UInt32 SERVICE_ERROR_NORMAL = 0x00000001;
        public static readonly UInt32 SERVICE_ERROR_SEVERE = 0x00000002;
        public static readonly UInt32 SERVICE_ERROR_CRITICAL = 0x00000003;

        // Controls
        public static readonly UInt32 SERVICE_CONTROL_STOP = 0x00000001;
        public static readonly UInt32 SERVICE_CONTROL_PAUSE = 0x00000002;
        public static readonly UInt32 SERVICE_CONTROL_CONTINUE = 0x00000003;
        public static readonly UInt32 SERVICE_CONTROL_INTERROGATE = 0x00000004;
        public static readonly UInt32 SERVICE_CONTROL_SHUTDOWN = 0x00000005;

        // Service object specific access type
        public static readonly UInt32 SERVICE_QUERY_CONFIG = 0x0001;
        public static readonly UInt32 SERVICE_CHANGE_CONFIG = 0x0002;
        public static readonly UInt32 SERVICE_QUERY_STATUS = 0x0004;
        public static readonly UInt32 SERVICE_ENUMERATE_DEPENDENTS = 0x0008;
        public static readonly UInt32 SERVICE_START = 0x0010;
        public static readonly UInt32 SERVICE_STOP = 0x0020;

        public static readonly UInt32 SERVICE_ALL_ACCESS = 0xF01FF;

        // Service Control Manager object specific access types
        public static readonly UInt32 SC_MANAGER_ALL_ACCESS = 0xF003F;
        public static readonly UInt32 SC_MANAGER_CREATE_SERVICE = 0x0002;
        public static readonly UInt32 SC_MANAGER_CONNECT = 0x0001;
        public static readonly UInt32 SC_MANAGER_ENUMERATE_SERVICE = 0x0004;
        public static readonly UInt32 SC_MANAGER_LOCK = 0x0008;
        public static readonly UInt32 SC_MANAGER_MODIFY_BOOT_CONFIG = 0x0020;
        public static readonly UInt32 SC_MANAGER_QUERY_LOCK_STATUS = 0x0010;

        // These are the generic rights.
        public static readonly UInt32 GENERIC_READ = 0x80000000;
        public static readonly UInt32 GENERIC_WRITE = 0x40000000;
        public static readonly UInt32 GENERIC_EXECUTE = 0x20000000;
        public static readonly UInt32 GENERIC_ALL = 0x10000000;

        //Driver Device Name
        public static readonly String TaskManager_Driver_Nt_Device_Name = "\\Device\\TaskManagerDevice";
        public static readonly String TaskManager_Driver_Dos_Device_Name = "\\DosDevices\\TaskManagerDevice";

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct SECURITY_ATTRIBUTES
        {
            public UInt32 nLength;
            public IntPtr lpSecurityDescriptor;
            public bool bInheritHandle;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct OVERLAPPED
        {
            public UInt32 Internal;
            public UInt32 InternalHigh;
            public UInt32 Offset;
            public UInt32 OffsetHigh;
            public IntPtr hEvent;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct SERVICE_STATUS
        {
            public UInt32 dwServiceType;
            public UInt32 dwCurrentState;
            public UInt32 dwControlsAccepted;
            public UInt32 dwWin32ExitCode;
            public UInt32 dwServiceSpecificExitCode;
            public UInt32 dwCheckPoint;
            public UInt32 dwWaitHint;
        }
    }

    class winAPI
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr CreateFile(
            String lpFileName,
            UInt32 dwDesiredAccess,
            UInt32 dwShareMode,
            ref api.driverDefine.SECURITY_ATTRIBUTES lpSecurityAttributes,
            UInt32 dwCreationDisposition,
            UInt32 dwFlagsAndAttributes,
            IntPtr hTemplateFile
            );

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern bool WriteFile(
            IntPtr hFile,
            byte[] lpBuffer,
            UInt32 nNumberOfBytesToWrite,
            ref UInt32 lpNumberOfBytesWritten,
            ref api.driverDefine.OVERLAPPED lpOverlapped
            );

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern bool DeviceIoControl(
            IntPtr hDevice,
            UInt32 dwIoControlCode,
            byte[] lpInBuffer,
            UInt32 nInBufferSize,
            byte[] lpOutBuffer,
            UInt32 nOutBufferSize,
            ref UInt32 lpBytesReturned,
            ref api.driverDefine.OVERLAPPED lpOverlapped
            );

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern bool CloseHandle(
            IntPtr hObject
            );

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr CreateEvent(
            ref api.driverDefine.SECURITY_ATTRIBUTES lpEventAttributes,
            bool bManualReset,
            bool bInitialState,
            String lpName
            );

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern UInt32 WaitForSingleObject(
            IntPtr hHandle,
            UInt32 dwMilliseconds
            );

        [DllImport("kernel32.dll")]
        public static extern UInt32 GetLastError();


        [DllImport("advapi32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr OpenSCManager(
            String lpMachineName,
            String lpDatabaseName,
            UInt32 dwDesiredAccess
            );

        [DllImport("advapi32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr CreateService(
            IntPtr hSCManager,
            String lpServiceName,
            String lpDisplayName,
            UInt32 dwDesiredAccess,
            UInt32 dwServiceType,
            UInt32 dwStartType,
            UInt32 dwErrorControl,
            String lpBinaryPathName,
            String lpLoadOrderGroup,
            ref UInt32 lpdwTagId,
            String lpDependencies,
            String lpServiceStartName,
            String lpPassword
            );

        [DllImport("advapi32.dll", CharSet = CharSet.Auto)]
        public static extern bool CloseServiceHandle(
            IntPtr hSCObject
            );

        [DllImport("advapi32.dll", CharSet = CharSet.Auto)]
        public static extern bool StartService(
            IntPtr hService,
            UInt32 dwNumServiceArgs,
            String lpServiceArgVectors
            );


        [DllImport("advapi32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr OpenService(
            IntPtr hSCManager,
            String lpServiceName,
            UInt32 dwDesiredAccess
            );

        [DllImport("advapi32.dll", CharSet = CharSet.Auto)]
        public static extern bool DeleteService(
            IntPtr hService
            );

        [DllImport("advapi32.dll", CharSet = CharSet.Auto)]
        public static extern bool ControlService(
            IntPtr hService,
            UInt32 dwControl,
            ref api.driverDefine.SERVICE_STATUS lpServiceStatus
            );

    }

}

public class myFun
{
    /// <summary>
    /// 启动驱动程序
    /// </summary>
    /// <param name="svcName"></param>
    /// <returns></returns>
    public static bool StartDriver(String svcName)
    {
        IntPtr scManagerHandle;
        IntPtr schDriverService;

        //打开服务控制台管理器
        scManagerHandle = api.winAPI.OpenSCManager(null, null, api.driverDefine.SC_MANAGER_CREATE_SERVICE);
        if (null == scManagerHandle || IntPtr.Zero == scManagerHandle)
        {
            return false;
        }

        //打开服务
        schDriverService = api.winAPI.OpenService(scManagerHandle, svcName, api.driverDefine.SERVICE_ALL_ACCESS);
        if (null == schDriverService || IntPtr.Zero == schDriverService)
        {
            api.winAPI.CloseServiceHandle(scManagerHandle);
            return false;
        }

        if (false == api.winAPI.StartService(schDriverService, 0, null))
        {
            api.winAPI.CloseServiceHandle(schDriverService);
            api.winAPI.CloseServiceHandle(scManagerHandle);
            return false;
        }

        api.winAPI.CloseServiceHandle(schDriverService);
        api.winAPI.CloseServiceHandle(scManagerHandle);

        return true;
    }


    /// <summary>
    /// 停止驱动程序服务
    /// </summary>
    /// <param name="svcName"></param>
    /// <returns></returns>
    public static bool StopDriver(String svcName)
    {
        IntPtr scManagerHandle;
        IntPtr schDriverService;

        api.driverDefine.SERVICE_STATUS serviceStatus;

        //打开服务控制台管理器
        scManagerHandle = api.winAPI.OpenSCManager(null, null, api.driverDefine.SC_MANAGER_CREATE_SERVICE);
        if (null == scManagerHandle || IntPtr.Zero == scManagerHandle)
        {
            return false;
        }

        //打开服务
        schDriverService = api.winAPI.OpenService(scManagerHandle, svcName, api.driverDefine.SERVICE_ALL_ACCESS);
        if (null == schDriverService || IntPtr.Zero == schDriverService)
        {
            api.winAPI.CloseServiceHandle(scManagerHandle);
            return false;
        }

        serviceStatus = new api.driverDefine.SERVICE_STATUS();

        //停止服务
        if (false == api.winAPI.ControlService(schDriverService, api.driverDefine.SERVICE_CONTROL_STOP, ref serviceStatus))
        {
            api.winAPI.CloseServiceHandle(schDriverService);
            api.winAPI.CloseServiceHandle(scManagerHandle);

            return false;
        }
        else
        {
            api.winAPI.CloseServiceHandle(schDriverService);
            api.winAPI.CloseServiceHandle(scManagerHandle);

            return true;
        }
    }


    /// <summary>
    /// 判断驱动程序是否已经安装
    /// </summary>
    /// <param name="svcName"></param>
    /// <returns></returns>
    public static bool DriverIsInstalled(string svcName)
    {
        IntPtr scManagerHandle;
        IntPtr schDriverService;

        //打开服务控制台管理器
        scManagerHandle = api.winAPI.OpenSCManager(null, null, api.driverDefine.SC_MANAGER_ALL_ACCESS);
        if (null == scManagerHandle || IntPtr.Zero == scManagerHandle)
        {
            return false;
        }

        //打开驱动程序服务
        schDriverService = api.winAPI.OpenService(scManagerHandle, svcName, api.driverDefine.SERVICE_ALL_ACCESS);
        if (null == schDriverService || IntPtr.Zero == schDriverService)
        {
            api.winAPI.CloseServiceHandle(scManagerHandle);
            return false;
        }

        api.winAPI.CloseServiceHandle(schDriverService);
        api.winAPI.CloseServiceHandle(scManagerHandle);

        return true;
    }


    /// <summary>
    /// 安装驱动程序服务
    /// </summary>
    /// <param name="svcDriverPath"></param>
    /// <param name="svcDriverName"></param>
    /// <param name="svcDisplayName"></param>
    /// <returns></returns>
    public static bool DriverInstall(String svcDriverPath, String svcDriverName, String svcDisplayName)
    {
        UInt32 lpdwTagId;
        IntPtr scManagerHandle;
        IntPtr schDriverService;

        //打开服务控制台管理器
        scManagerHandle = api.winAPI.OpenSCManager(null, null, api.driverDefine.SC_MANAGER_CREATE_SERVICE);
        if (null == scManagerHandle || IntPtr.Zero == scManagerHandle)
        {
            MessageBox.Show("打开服务控制台管理器失败！");
            return false;
        }
        if (DriverIsInstalled(svcDriverName) == false)
        {
            lpdwTagId = 0;
            schDriverService = api.winAPI.CreateService(
                scManagerHandle, svcDriverName, svcDisplayName,
                api.driverDefine.SERVICE_ALL_ACCESS,
                api.driverDefine.SERVICE_KERNEL_DRIVER,
                api.driverDefine.SERVICE_DEMAND_START,
                api.driverDefine.SERVICE_ERROR_NORMAL,
                svcDriverPath, null,
                ref lpdwTagId,
                null, null, null
                );
            api.winAPI.CloseServiceHandle(scManagerHandle);
            if (null == schDriverService || IntPtr.Zero == schDriverService)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        else
        {
            MessageBox.Show("驱动已存在，无需再次安装");
            api.winAPI.CloseServiceHandle(scManagerHandle);
            return true;
        }
    }


    /// <summary>
    /// 卸载驱动程序服务
    /// </summary>
    /// <param name="svcName"></param>
    public static void DriverUnInstall(String svcName)
    {
        IntPtr scManagerHandle;
        IntPtr schDriverService;

        //打开服务控制台管理器
        scManagerHandle = api.winAPI.OpenSCManager(null, null, api.driverDefine.SC_MANAGER_ALL_ACCESS);
        if (null == scManagerHandle || IntPtr.Zero == scManagerHandle)
        {
            return;
        }

        //打开驱动程序服务
        schDriverService = api.winAPI.OpenService(scManagerHandle, svcName, api.driverDefine.SERVICE_ALL_ACCESS);
        if (null == schDriverService || IntPtr.Zero == schDriverService)
        {
            api.winAPI.CloseServiceHandle(scManagerHandle);
            return;
        }
        else
        {
            api.winAPI.DeleteService(schDriverService);

            api.winAPI.CloseServiceHandle(schDriverService);
            api.winAPI.CloseServiceHandle(scManagerHandle);
        }
    }
}