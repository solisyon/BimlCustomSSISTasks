using System;
using System.Windows.Forms;
using Microsoft.SqlServer.Dts.Runtime;
using Microsoft.SqlServer.Dts.Runtime.Design;

namespace oh22is.DTS.Task.ZIP
{
    class ZipUI : Microsoft.SqlServer.Dts.Runtime.Design.IDtsTaskUI
    {

        private TaskHost _taskHost;
        private Connections _connections;

        public void Delete(IWin32Window parentWindow)
        {

        }

        public ContainerControl GetView()
        {
            // Launch your editor with information from your task and available connections
            return new frmZipUI(_taskHost, _connections);
        }

        public void Initialize(TaskHost taskHost, IServiceProvider serviceProvider)
        {
            _taskHost = taskHost;
            var cs = serviceProvider.GetService(typeof(IDtsConnectionService)) as IDtsConnectionService;
            if (cs != null) _connections = cs.GetConnections();
        }

        public void New(IWin32Window parentWindow)
        {
            
        }
    }
}
