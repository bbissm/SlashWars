<<<<<<< HEAD
using Unity.CodeEditor;
using UnityEditor;

namespace Packages.Rider.Editor.PostProcessors
{
  public class RiderAssetPostprocessor: AssetPostprocessor
  {
    public static bool OnPreGeneratingCSProjectFiles()
    {
      var path = RiderScriptEditor.GetEditorRealPath(CodeEditor.CurrentEditorInstallation);
      if (RiderScriptEditor.IsRiderInstallation(path))
        return !ProjectGeneration.isRiderProjectGeneration;
      return false;
    }
  }
=======
using Unity.CodeEditor;
using UnityEditor;

namespace Packages.Rider.Editor.PostProcessors
{
  public class RiderAssetPostprocessor: AssetPostprocessor
  {
    public static bool OnPreGeneratingCSProjectFiles()
    {
      var path = RiderScriptEditor.GetEditorRealPath(CodeEditor.CurrentEditorInstallation);
      if (RiderScriptEditor.IsRiderInstallation(path))
        return !ProjectGeneration.isRiderProjectGeneration;
      return false;
    }
  }
>>>>>>> 5e7ae5c3b374057726d5247cc162925099acd9f6
}