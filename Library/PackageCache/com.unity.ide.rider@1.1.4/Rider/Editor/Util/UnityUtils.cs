<<<<<<< HEAD
using System;
using System.Linq;
using UnityEngine;

namespace Packages.Rider.Editor.Util
{
  public static class UnityUtils
  {
    internal static readonly string UnityApplicationVersion = Application.unityVersion;
    
    public static Version UnityVersion
    {
      get
      {
        var ver = UnityApplicationVersion.Split(".".ToCharArray()).Take(2).Aggregate((a, b) => a + "." + b);
        return new Version(ver);
      }
    }
  }
=======
using System;
using System.Linq;
using UnityEngine;

namespace Packages.Rider.Editor.Util
{
  public static class UnityUtils
  {
    internal static readonly string UnityApplicationVersion = Application.unityVersion;
    
    public static Version UnityVersion
    {
      get
      {
        var ver = UnityApplicationVersion.Split(".".ToCharArray()).Take(2).Aggregate((a, b) => a + "." + b);
        return new Version(ver);
      }
    }
  }
>>>>>>> 5e7ae5c3b374057726d5247cc162925099acd9f6
}