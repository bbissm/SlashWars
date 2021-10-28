<<<<<<< HEAD
using JetBrains.Annotations;
using Packages.Rider.Editor;
using Unity.CodeEditor;

// Is called via commandline from Rider Notification after checking out from source control.

// ReSharper disable once CheckNamespace 
namespace JetBrains.Rider.Unity.Editor
{
  public static class RiderMenu
  {
    [UsedImplicitly]
    public static void MenuOpenProject()
    {
      if (RiderScriptEditor.IsRiderInstallation(RiderScriptEditor.CurrentEditor))
      {
        // Force the project files to be sync
        CodeEditor.CurrentEditor.SyncAll();

        // Load Project
        CodeEditor.CurrentEditor.OpenProject();
      }
    }
  }
=======
using JetBrains.Annotations;
using Packages.Rider.Editor;
using Unity.CodeEditor;

// Is called via commandline from Rider Notification after checking out from source control.

// ReSharper disable once CheckNamespace 
namespace JetBrains.Rider.Unity.Editor
{
  public static class RiderMenu
  {
    [UsedImplicitly]
    public static void MenuOpenProject()
    {
      if (RiderScriptEditor.IsRiderInstallation(RiderScriptEditor.CurrentEditor))
      {
        // Force the project files to be sync
        CodeEditor.CurrentEditor.SyncAll();

        // Load Project
        CodeEditor.CurrentEditor.OpenProject();
      }
    }
  }
>>>>>>> 5e7ae5c3b374057726d5247cc162925099acd9f6
}