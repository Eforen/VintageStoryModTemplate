using System.Reflection;
  using System.Runtime.CompilerServices;
  using System.Runtime.InteropServices;
  using Vintagestory.API.Common;

  // General Information about an assembly is controlled through the following 
  // set of attributes. Change these attribute values to modify the information
  // associated with an assembly.
  [assembly: AssemblyTitle("Eforen's Mod Template")]
  [assembly: AssemblyDescription("Eforen's Mod Template")]
  [assembly: AssemblyConfiguration("Debug")]
  [assembly: AssemblyCompany("")]
  [assembly: AssemblyProduct("eforenmodtemplate")]
  [assembly: AssemblyCopyright("")]
  [assembly: AssemblyTrademark("")]
  [assembly: AssemblyCulture("")]

  // Setting ComVisible to false makes the types in this assembly not visible 
  // to COM components.  If you need to access a type in this assembly from 
  // COM, set the ComVisible attribute to true on that type.
  [assembly: ComVisible(false)]

  // The following GUID is for the ID of the typelib if this project is exposed to COM
  [assembly: Guid("00000000-0000-0000-0000-000000000000")]

  // Version information for an assembly consists of the following four values:
  //
  //      Major Version
  //      Minor Version 
  //      Build Number
  //      Revision
  //
  [assembly: AssemblyVersion("0.0.1.0")]
  [assembly: AssemblyFileVersion("0.0.1.0")]


  [assembly: ModDependency("game","1.17.0rc5"), ModDependency("survival"), ModDependency("onestick", "1.0.1")]
  [assembly: ModInfo("Eforen's Mod Template", "eforenmodtemplate", Version = "0.0.1", Authors = new string[] { "Author1", "Author2" },
          Website = "https://github.com/Eforen/VintageStoryModTemplate", Description = "Eforen's Mod Template", RequiredOnClient = true)]
