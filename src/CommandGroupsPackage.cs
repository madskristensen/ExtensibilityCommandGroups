using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace ExtensibilityCommandGroups
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)]
    [Guid("fb035c37-9d8e-4c86-856f-aada23222675")]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    public sealed class CommandGroupsPackage : AsyncPackage
    {
    }
}
