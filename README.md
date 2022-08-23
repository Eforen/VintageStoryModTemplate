# VintageStoryModTemplate
Simple Mod Template I use for my mods

# Build Pipeline
The following is the current pipeline flow.
```mermaid
flowchart TD
Build --> |default| Debug
Build --> Release
Debug --> Assets[Gather assets\**]
Release --> Assets
Assets --> mkAssemblyInfo[Create AssemblyInfo.cs]
mkAssemblyInfo --> Src[Gather src\**]
Src --> targetBuild[Run Build Target]
targetBuild --> targetModInfo[Write Mod Info]
targetModInfo --> gtargetZip
subgraph gtargetZip[Target ZipOutput]
mkDirMods[Make Mods Dir]-->mkZip[Make Zip File of OutputDir and place it in BuildBaseDir]
mkZip-->isDebug{isDebug?}
isDebug-- Yes --> moveZip[Move Zip to ModsOutputDir]
isDebug-- No -->gtargetZipContinue[Continue]
moveZip-->gtargetZipContinue[Continue]
end
gtargetZip -->|2|targetwriteLaunchFile[Run Target WriteLaunchFile]
```


### Thanks to
Discord
* Fulgen
  * Help with `ModDependency` Attribute format/usage
* https://github.com/Copygirl/howto-example-mod
  * Showing me the correct way to get vscode to launch the game in debug mode