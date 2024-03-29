using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bright_Minecraft_Platform.ViewModels
{
    internal partial class ServerListViewModel : ObservableObject
    {
        [ObservableProperty]//#2A2929
        private String _serverName = "Server Name";

        [ObservableProperty]//#2A2929
        private String _serverSynopsis = "Server Synopsis";

        [ObservableProperty]//#2A2929
        private String _serverVersions = "Server Version";

    }
}
