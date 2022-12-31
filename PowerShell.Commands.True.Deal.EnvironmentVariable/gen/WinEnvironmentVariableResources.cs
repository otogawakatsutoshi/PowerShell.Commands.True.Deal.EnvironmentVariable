
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a dotnet run from ResGen project.
//     To add or remove a member, edit your .resx file then rerun ResGen.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Reflection;

/// <summary>
///   A strongly-typed resource class, for looking up localized strings, etc.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]

internal class WinEnvironmentVariableResources {

    private static global::System.Resources.ResourceManager resourceMan;

    private static global::System.Globalization.CultureInfo resourceCulture;

    /// <summary>constructor</summary>
    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal WinEnvironmentVariableResources() {
    }

    /// <summary>
    ///   Returns the cached ResourceManager instance used by this class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Resources.ResourceManager ResourceManager {
        get {
            if (resourceMan is null) {
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PowerShell.Commands.resources.WinEnvironmentVariableResources", typeof(WinEnvironmentVariableResources).Assembly);
                resourceMan = temp;
            }

            return resourceMan;
        }
    }

    /// <summary>
    ///   Overrides the current threads CurrentUICulture property for all
    ///   resource lookups using this strongly typed resource class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Globalization.CultureInfo Culture {
        get {
            return resourceCulture;
        }

        set {
            resourceCulture = value;
        }
    }
    

    /// <summary>
    ///   Looks up a localized string similar to 
    ///    Set string {0} to the EnvironmentVariable {1} with a Type {2}.
    ///  
    /// </summary>
    internal static string SetWinEnvironmentVariable {
        get {
            return ResourceManager.GetString("SetWinEnvironmentVariable", resourceCulture);
        }
    }


    /// <summary>
    ///   Looks up a localized string similar to 
    ///    Append switch parameter is required Delimiter parameter except Path, PATHEXT and PSModulePath.
    ///  
    /// </summary>
    internal static string DelimterNotDetected {
        get {
            return ResourceManager.GetString("DelimterNotDetected", resourceCulture);
        }
    }


    /// <summary>
    ///   Looks up a localized string similar to 
    ///    The existing EnvironmentVariable having RegistryKindValue is not a String or ExpandString, so it cannot be appended.
    ///  
    /// </summary>
    internal static string RegistryKindValueWrong {
        get {
            return ResourceManager.GetString("RegistryKindValueWrong", resourceCulture);
        }
    }


    /// <summary>
    ///   Looks up a localized string similar to 
    ///    {0} The length of variable or value is greater than or equal to 32,767 characters. or other error.
    ///  
    /// </summary>
    internal static string SetWinEnvironmentVariableArgumentError {
        get {
            return ResourceManager.GetString("SetWinEnvironmentVariableArgumentError", resourceCulture);
        }
    }


    /// <summary>
    ///   Looks up a localized string similar to 
    ///    Set an environment variable '{0}' with a Type '{1}' and a delimiter '{2}', and the value is as follows.
    ///{3}
    ///  
    /// </summary>
    internal static string SetMultipleEnvironmentVariable {
        get {
            return ResourceManager.GetString("SetMultipleEnvironmentVariable", resourceCulture);
        }
    }


    /// <summary>
    ///   Looks up a localized string similar to 
    ///    EnvironmentVariable '{0}' has been removed.
    ///  
    /// </summary>
    internal static string WinEnvironmentVariableRemoved {
        get {
            return ResourceManager.GetString("WinEnvironmentVariableRemoved", resourceCulture);
        }
    }


    /// <summary>
    ///   Looks up a localized string similar to 
    ///    Cannot set {0} EnvironmentVariable. You dont have the required permission to set Environment Variable in {1} target
    ///  
    /// </summary>
    internal static string CantSetWinEnvironmentVariable {
        get {
            return ResourceManager.GetString("CantSetWinEnvironmentVariable", resourceCulture);
        }
    }


    /// <summary>
    ///   Looks up a localized string similar to 
    ///    Cannot find EnvironmentVariable '{0}' or content is Empty.
    ///  
    /// </summary>
    internal static string EnvironmentVariableNotFoundOrEmpty {
        get {
            return ResourceManager.GetString("EnvironmentVariableNotFoundOrEmpty", resourceCulture);
        }
    }

}
