using _3S.CoDeSys.Core.Commands;
using _3S.CoDeSys.Core.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    [TypeGuid("{E9156C5C-9021-4821-960C-57FB0BEE233B}")]
    public class Command : IStandardCommand
    {
        public Guid Category => new Guid("{AB91AD5B-A221-457b-B0A7-04DEC62342CB}");

        public string Name => Resource.HelloWorldCommandName;

        public string Description => Resource.HelloWorldCommandDescription;

        public string ToolTipText => "tool tip for command";

        public Icon SmallIcon => Resource.Icon1;

        public Icon LargeIcon => SmallIcon;

        public bool Enabled => true;

        public string[] BatchCommand => new string[] { "text", "hello" }; 

        public void AddedToUI()
        {
        }

        public string[] CreateBatchArguments()
        {
            return new string[0];
        }

        public void ExecuteBatch(string[] arguments)
        {
            MessageBox.Show("Hello world!");
        }

        public bool IsVisible(bool bContextMenu)
        {
            return true;
        }

        public void RemovedFromUI()
        {
        }
    }
}
