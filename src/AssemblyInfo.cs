using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Vintagestory.API.Common;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("OneStick")]
[assembly: AssemblyDescription("Currently just fixes what appears to be a bug in the vanilla axe code.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("onestick")]
[assembly: AssemblyCopyright("Copyright ©  2022")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("1BFAA09B-0110-416B-A9A1-8114193365B7")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
[assembly: AssemblyVersion("1.0.1.0")]
[assembly: AssemblyFileVersion("1.0.1.0")]


[assembly: ModDependency("game")]
[assembly: ModInfo("OneStick", "onestick", Version = "1.0.1", Authors = new string[] { "Eforen" },
        Website = "https://github.com/Eforen/OneStick", Description = "Currently just fixes what appears to be a bug in the vanilla axe code.", RequiredOnClient = false)]