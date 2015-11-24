namespace GMZ_csharp
{
    partial class GMZ_csharp
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GMZ_csharp));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_processInfo = new System.Windows.Forms.TabPage();
            this.listView_process = new System.Windows.Forms.ListView();
            this.imageName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fatherProcessID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imagePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eprocess = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r3AccessStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileFirm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage_driverModule = new System.Windows.Forms.TabPage();
            this.tabPage_kernelInfo = new System.Windows.Forms.TabPage();
            this.tabPage_hook_r0 = new System.Windows.Forms.TabPage();
            this.tabPage_hook_r3 = new System.Windows.Forms.TabPage();
            this.tabPage_netWork = new System.Windows.Forms.TabPage();
            this.tabPage_regeditInfo = new System.Windows.Forms.TabPage();
            this.tabPage_fileInfo = new System.Windows.Forms.TabPage();
            this.tabPage_bootInfo = new System.Windows.Forms.TabPage();
            this.tabPage_others = new System.Windows.Forms.TabPage();
            this.tabPage_about = new System.Windows.Forms.TabPage();
            this.imageList_process = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip_process = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.查看进程模块ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看进程线程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看进程句柄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.在下方显示模块窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.在进程中查找模块ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.在进程中查找没有数字签名模块ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.结束进程时删除文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.结束进程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.强制结束进程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按进程树结束进程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.校验数字签名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.校验所有数字签名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.恢复进程运行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停运行进程ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.恢复进程运行ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.复制进程名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制进程路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.在线搜索进程名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.在线分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.定位到进程文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看进程文件属性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.定位到GMZ文件管理器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage_processInfo.SuspendLayout();
            this.contextMenuStrip_process.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_processInfo);
            this.tabControl1.Controls.Add(this.tabPage_driverModule);
            this.tabControl1.Controls.Add(this.tabPage_kernelInfo);
            this.tabControl1.Controls.Add(this.tabPage_hook_r0);
            this.tabControl1.Controls.Add(this.tabPage_hook_r3);
            this.tabControl1.Controls.Add(this.tabPage_netWork);
            this.tabControl1.Controls.Add(this.tabPage_regeditInfo);
            this.tabControl1.Controls.Add(this.tabPage_fileInfo);
            this.tabControl1.Controls.Add(this.tabPage_bootInfo);
            this.tabControl1.Controls.Add(this.tabPage_others);
            this.tabControl1.Controls.Add(this.tabPage_about);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_processInfo
            // 
            this.tabPage_processInfo.Controls.Add(this.listView_process);
            this.tabPage_processInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPage_processInfo.Name = "tabPage_processInfo";
            this.tabPage_processInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_processInfo.Size = new System.Drawing.Size(796, 425);
            this.tabPage_processInfo.TabIndex = 0;
            this.tabPage_processInfo.Text = "进程";
            this.tabPage_processInfo.UseVisualStyleBackColor = true;
            // 
            // listView_process
            // 
            this.listView_process.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.imageName,
            this.processID,
            this.fatherProcessID,
            this.imagePath,
            this.eprocess,
            this.r3AccessStatus,
            this.fileFirm});
            this.listView_process.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_process.FullRowSelect = true;
            this.listView_process.GridLines = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup2";
            this.listView_process.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listView_process.Location = new System.Drawing.Point(3, 3);
            this.listView_process.Name = "listView_process";
            this.listView_process.Size = new System.Drawing.Size(790, 419);
            this.listView_process.TabIndex = 0;
            this.listView_process.UseCompatibleStateImageBehavior = false;
            this.listView_process.View = System.Windows.Forms.View.Details;
            // 
            // imageName
            // 
            this.imageName.Text = "映像名称";
            this.imageName.Width = 140;
            // 
            // processID
            // 
            this.processID.Text = "进程ID";
            this.processID.Width = 80;
            // 
            // fatherProcessID
            // 
            this.fatherProcessID.Text = "父进程ID";
            this.fatherProcessID.Width = 80;
            // 
            // imagePath
            // 
            this.imagePath.Text = "映像路径";
            this.imagePath.Width = 120;
            // 
            // eprocess
            // 
            this.eprocess.Text = "EPROCESS";
            this.eprocess.Width = 80;
            // 
            // r3AccessStatus
            // 
            this.r3AccessStatus.Text = "应用层访问状态";
            this.r3AccessStatus.Width = 70;
            // 
            // fileFirm
            // 
            this.fileFirm.Text = "文件厂商";
            this.fileFirm.Width = 120;
            // 
            // tabPage_driverModule
            // 
            this.tabPage_driverModule.Location = new System.Drawing.Point(4, 22);
            this.tabPage_driverModule.Name = "tabPage_driverModule";
            this.tabPage_driverModule.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_driverModule.Size = new System.Drawing.Size(681, 348);
            this.tabPage_driverModule.TabIndex = 1;
            this.tabPage_driverModule.Text = "驱动模块";
            this.tabPage_driverModule.UseVisualStyleBackColor = true;
            // 
            // tabPage_kernelInfo
            // 
            this.tabPage_kernelInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPage_kernelInfo.Name = "tabPage_kernelInfo";
            this.tabPage_kernelInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_kernelInfo.Size = new System.Drawing.Size(681, 348);
            this.tabPage_kernelInfo.TabIndex = 2;
            this.tabPage_kernelInfo.Text = "内核";
            this.tabPage_kernelInfo.UseVisualStyleBackColor = true;
            // 
            // tabPage_hook_r0
            // 
            this.tabPage_hook_r0.Location = new System.Drawing.Point(4, 22);
            this.tabPage_hook_r0.Name = "tabPage_hook_r0";
            this.tabPage_hook_r0.Size = new System.Drawing.Size(681, 348);
            this.tabPage_hook_r0.TabIndex = 3;
            this.tabPage_hook_r0.Text = "内核层钩子";
            this.tabPage_hook_r0.UseVisualStyleBackColor = true;
            // 
            // tabPage_hook_r3
            // 
            this.tabPage_hook_r3.Location = new System.Drawing.Point(4, 22);
            this.tabPage_hook_r3.Name = "tabPage_hook_r3";
            this.tabPage_hook_r3.Size = new System.Drawing.Size(681, 348);
            this.tabPage_hook_r3.TabIndex = 4;
            this.tabPage_hook_r3.Text = "应用层钩子";
            this.tabPage_hook_r3.UseVisualStyleBackColor = true;
            // 
            // tabPage_netWork
            // 
            this.tabPage_netWork.Location = new System.Drawing.Point(4, 22);
            this.tabPage_netWork.Name = "tabPage_netWork";
            this.tabPage_netWork.Size = new System.Drawing.Size(681, 348);
            this.tabPage_netWork.TabIndex = 5;
            this.tabPage_netWork.Text = "网络";
            this.tabPage_netWork.UseVisualStyleBackColor = true;
            // 
            // tabPage_regeditInfo
            // 
            this.tabPage_regeditInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPage_regeditInfo.Name = "tabPage_regeditInfo";
            this.tabPage_regeditInfo.Size = new System.Drawing.Size(681, 348);
            this.tabPage_regeditInfo.TabIndex = 6;
            this.tabPage_regeditInfo.Text = "注册表";
            this.tabPage_regeditInfo.UseVisualStyleBackColor = true;
            // 
            // tabPage_fileInfo
            // 
            this.tabPage_fileInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPage_fileInfo.Name = "tabPage_fileInfo";
            this.tabPage_fileInfo.Size = new System.Drawing.Size(681, 348);
            this.tabPage_fileInfo.TabIndex = 7;
            this.tabPage_fileInfo.Text = "文件";
            this.tabPage_fileInfo.UseVisualStyleBackColor = true;
            // 
            // tabPage_bootInfo
            // 
            this.tabPage_bootInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPage_bootInfo.Name = "tabPage_bootInfo";
            this.tabPage_bootInfo.Size = new System.Drawing.Size(681, 348);
            this.tabPage_bootInfo.TabIndex = 8;
            this.tabPage_bootInfo.Text = "启动信息";
            this.tabPage_bootInfo.UseVisualStyleBackColor = true;
            // 
            // tabPage_others
            // 
            this.tabPage_others.Location = new System.Drawing.Point(4, 22);
            this.tabPage_others.Name = "tabPage_others";
            this.tabPage_others.Size = new System.Drawing.Size(681, 348);
            this.tabPage_others.TabIndex = 9;
            this.tabPage_others.Text = "系统杂项";
            this.tabPage_others.UseVisualStyleBackColor = true;
            // 
            // tabPage_about
            // 
            this.tabPage_about.Location = new System.Drawing.Point(4, 22);
            this.tabPage_about.Name = "tabPage_about";
            this.tabPage_about.Size = new System.Drawing.Size(681, 348);
            this.tabPage_about.TabIndex = 12;
            this.tabPage_about.Text = "关于";
            this.tabPage_about.UseVisualStyleBackColor = true;
            // 
            // imageList_process
            // 
            this.imageList_process.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_process.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_process.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // contextMenuStrip_process
            // 
            this.contextMenuStrip_process.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.查看进程模块ToolStripMenuItem,
            this.查看进程线程ToolStripMenuItem,
            this.查看进程句柄ToolStripMenuItem,
            this.查看ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.在下方显示模块窗口ToolStripMenuItem,
            this.在进程中查找模块ToolStripMenuItem,
            this.在进程中查找没有数字签名模块ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.结束进程时删除文件ToolStripMenuItem,
            this.toolStripMenuItem4,
            this.结束进程ToolStripMenuItem,
            this.强制结束进程ToolStripMenuItem,
            this.按进程树结束进程ToolStripMenuItem,
            this.toolStripMenuItem5,
            this.校验数字签名ToolStripMenuItem,
            this.校验所有数字签名ToolStripMenuItem,
            this.暂停运行进程ToolStripMenuItem,
            this.恢复进程运行ToolStripMenuItem,
            this.恢复进程运行ToolStripMenuItem1,
            this.toolStripMenuItem6,
            this.复制进程名ToolStripMenuItem,
            this.复制进程路径ToolStripMenuItem,
            this.toolStripMenuItem7,
            this.在线搜索进程名ToolStripMenuItem,
            this.在线分析ToolStripMenuItem,
            this.toolStripMenuItem8,
            this.定位到进程文件ToolStripMenuItem,
            this.查看进程文件属性ToolStripMenuItem,
            this.toolStripMenuItem9,
            this.定位到GMZ文件管理器ToolStripMenuItem,
            this.toolStripMenuItem10,
            this.导出ToolStripMenuItem});
            this.contextMenuStrip_process.Name = "contextMenuStrip_process";
            this.contextMenuStrip_process.Size = new System.Drawing.Size(243, 598);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.刷新ToolStripMenuItem.Text = "刷新";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(239, 6);
            // 
            // 查看进程模块ToolStripMenuItem
            // 
            this.查看进程模块ToolStripMenuItem.Name = "查看进程模块ToolStripMenuItem";
            this.查看进程模块ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.查看进程模块ToolStripMenuItem.Text = "查看进程模块";
            // 
            // 查看进程线程ToolStripMenuItem
            // 
            this.查看进程线程ToolStripMenuItem.Name = "查看进程线程ToolStripMenuItem";
            this.查看进程线程ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.查看进程线程ToolStripMenuItem.Text = "查看进程线程";
            // 
            // 查看进程句柄ToolStripMenuItem
            // 
            this.查看进程句柄ToolStripMenuItem.Name = "查看进程句柄ToolStripMenuItem";
            this.查看进程句柄ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.查看进程句柄ToolStripMenuItem.Text = "查看进程句柄";
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看1ToolStripMenuItem,
            this.查看2ToolStripMenuItem,
            this.查看3ToolStripMenuItem});
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.查看ToolStripMenuItem.Text = "查看....";
            // 
            // 查看1ToolStripMenuItem
            // 
            this.查看1ToolStripMenuItem.Name = "查看1ToolStripMenuItem";
            this.查看1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.查看1ToolStripMenuItem.Text = "查看1";
            // 
            // 查看2ToolStripMenuItem
            // 
            this.查看2ToolStripMenuItem.Name = "查看2ToolStripMenuItem";
            this.查看2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.查看2ToolStripMenuItem.Text = "查看2";
            // 
            // 查看3ToolStripMenuItem
            // 
            this.查看3ToolStripMenuItem.Name = "查看3ToolStripMenuItem";
            this.查看3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.查看3ToolStripMenuItem.Text = "查看3";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(239, 6);
            // 
            // 在下方显示模块窗口ToolStripMenuItem
            // 
            this.在下方显示模块窗口ToolStripMenuItem.Name = "在下方显示模块窗口ToolStripMenuItem";
            this.在下方显示模块窗口ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.在下方显示模块窗口ToolStripMenuItem.Text = "在下方显示模块窗口";
            // 
            // 在进程中查找模块ToolStripMenuItem
            // 
            this.在进程中查找模块ToolStripMenuItem.Name = "在进程中查找模块ToolStripMenuItem";
            this.在进程中查找模块ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.在进程中查找模块ToolStripMenuItem.Text = "在进程中查找模块";
            // 
            // 在进程中查找没有数字签名模块ToolStripMenuItem
            // 
            this.在进程中查找没有数字签名模块ToolStripMenuItem.Name = "在进程中查找没有数字签名模块ToolStripMenuItem";
            this.在进程中查找没有数字签名模块ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.在进程中查找没有数字签名模块ToolStripMenuItem.Text = "在进程中查找没有数字签名模块";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(239, 6);
            // 
            // 结束进程时删除文件ToolStripMenuItem
            // 
            this.结束进程时删除文件ToolStripMenuItem.Name = "结束进程时删除文件ToolStripMenuItem";
            this.结束进程时删除文件ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.结束进程时删除文件ToolStripMenuItem.Text = "结束进程时删除文件";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(239, 6);
            // 
            // 结束进程ToolStripMenuItem
            // 
            this.结束进程ToolStripMenuItem.Name = "结束进程ToolStripMenuItem";
            this.结束进程ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.结束进程ToolStripMenuItem.Text = "结束进程";
            // 
            // 强制结束进程ToolStripMenuItem
            // 
            this.强制结束进程ToolStripMenuItem.Name = "强制结束进程ToolStripMenuItem";
            this.强制结束进程ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.强制结束进程ToolStripMenuItem.Text = "强制结束进程";
            // 
            // 按进程树结束进程ToolStripMenuItem
            // 
            this.按进程树结束进程ToolStripMenuItem.Name = "按进程树结束进程ToolStripMenuItem";
            this.按进程树结束进程ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.按进程树结束进程ToolStripMenuItem.Text = "按进程树结束进程";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(239, 6);
            // 
            // 校验数字签名ToolStripMenuItem
            // 
            this.校验数字签名ToolStripMenuItem.Name = "校验数字签名ToolStripMenuItem";
            this.校验数字签名ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.校验数字签名ToolStripMenuItem.Text = "校验数字签名";
            // 
            // 校验所有数字签名ToolStripMenuItem
            // 
            this.校验所有数字签名ToolStripMenuItem.Name = "校验所有数字签名ToolStripMenuItem";
            this.校验所有数字签名ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.校验所有数字签名ToolStripMenuItem.Text = "校验所有数字签名";
            // 
            // 恢复进程运行ToolStripMenuItem
            // 
            this.恢复进程运行ToolStripMenuItem.Name = "恢复进程运行ToolStripMenuItem";
            this.恢复进程运行ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.恢复进程运行ToolStripMenuItem.Text = "暂停进程运行";
            // 
            // 暂停运行进程ToolStripMenuItem
            // 
            this.暂停运行进程ToolStripMenuItem.Name = "暂停运行进程ToolStripMenuItem";
            this.暂停运行进程ToolStripMenuItem.Size = new System.Drawing.Size(239, 6);
            // 
            // 恢复进程运行ToolStripMenuItem1
            // 
            this.恢复进程运行ToolStripMenuItem1.Name = "恢复进程运行ToolStripMenuItem1";
            this.恢复进程运行ToolStripMenuItem1.Size = new System.Drawing.Size(242, 22);
            this.恢复进程运行ToolStripMenuItem1.Text = "恢复进程运行";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(239, 6);
            // 
            // 复制进程名ToolStripMenuItem
            // 
            this.复制进程名ToolStripMenuItem.Name = "复制进程名ToolStripMenuItem";
            this.复制进程名ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.复制进程名ToolStripMenuItem.Text = "复制进程名";
            // 
            // 复制进程路径ToolStripMenuItem
            // 
            this.复制进程路径ToolStripMenuItem.Name = "复制进程路径ToolStripMenuItem";
            this.复制进程路径ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.复制进程路径ToolStripMenuItem.Text = "复制进程路径";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(239, 6);
            // 
            // 在线搜索进程名ToolStripMenuItem
            // 
            this.在线搜索进程名ToolStripMenuItem.Name = "在线搜索进程名ToolStripMenuItem";
            this.在线搜索进程名ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.在线搜索进程名ToolStripMenuItem.Text = "在线搜索进程名";
            // 
            // 在线分析ToolStripMenuItem
            // 
            this.在线分析ToolStripMenuItem.Name = "在线分析ToolStripMenuItem";
            this.在线分析ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.在线分析ToolStripMenuItem.Text = "在线分析";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(239, 6);
            // 
            // 定位到进程文件ToolStripMenuItem
            // 
            this.定位到进程文件ToolStripMenuItem.Name = "定位到进程文件ToolStripMenuItem";
            this.定位到进程文件ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.定位到进程文件ToolStripMenuItem.Text = "定位到进程文件";
            // 
            // 查看进程文件属性ToolStripMenuItem
            // 
            this.查看进程文件属性ToolStripMenuItem.Name = "查看进程文件属性ToolStripMenuItem";
            this.查看进程文件属性ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.查看进程文件属性ToolStripMenuItem.Text = "查看进程文件属性";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(239, 6);
            // 
            // 定位到GMZ文件管理器ToolStripMenuItem
            // 
            this.定位到GMZ文件管理器ToolStripMenuItem.Name = "定位到GMZ文件管理器ToolStripMenuItem";
            this.定位到GMZ文件管理器ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.定位到GMZ文件管理器ToolStripMenuItem.Text = "定位到GMZ文件管理器";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(239, 6);
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.导出ToolStripMenuItem.Text = "导出";
            // 
            // GMZ_csharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GMZ_csharp";
            this.Text = "GMZ_csharp";
            this.Load += new System.EventHandler(this.GMZ_csharp_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_processInfo.ResumeLayout(false);
            this.contextMenuStrip_process.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_processInfo;
        private System.Windows.Forms.TabPage tabPage_driverModule;
        private System.Windows.Forms.TabPage tabPage_kernelInfo;
        private System.Windows.Forms.TabPage tabPage_hook_r0;
        private System.Windows.Forms.TabPage tabPage_hook_r3;
        private System.Windows.Forms.TabPage tabPage_netWork;
        private System.Windows.Forms.TabPage tabPage_regeditInfo;
        private System.Windows.Forms.TabPage tabPage_fileInfo;
        private System.Windows.Forms.TabPage tabPage_bootInfo;
        private System.Windows.Forms.TabPage tabPage_others;
        private System.Windows.Forms.TabPage tabPage_about;
        private System.Windows.Forms.ListView listView_process;
        private System.Windows.Forms.ColumnHeader imageName;
        private System.Windows.Forms.ColumnHeader processID;
        private System.Windows.Forms.ColumnHeader fatherProcessID;
        private System.Windows.Forms.ColumnHeader imagePath;
        private System.Windows.Forms.ColumnHeader eprocess;
        private System.Windows.Forms.ColumnHeader r3AccessStatus;
        private System.Windows.Forms.ColumnHeader fileFirm;
        private System.Windows.Forms.ImageList imageList_process;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_process;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 查看进程模块ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看进程线程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看进程句柄ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 在下方显示模块窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 在进程中查找模块ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 在进程中查找没有数字签名模块ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 结束进程时删除文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 结束进程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 强制结束进程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按进程树结束进程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem 校验数字签名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 校验所有数字签名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 恢复进程运行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator 暂停运行进程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 恢复进程运行ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem 复制进程名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制进程路径ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem 在线搜索进程名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 在线分析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem 定位到进程文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看进程文件属性ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem 定位到GMZ文件管理器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
    }
}

