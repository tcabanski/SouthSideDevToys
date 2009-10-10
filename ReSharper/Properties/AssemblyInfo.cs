using System.Reflection;
using JetBrains.ActionManagement;
using JetBrains.UI.Application.PluginSupport;

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//

[assembly: AssemblyTitle("SouthSideSharper")]
[assembly: AssemblyDescription("Add in for Resharper")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("SouthSideDevToys")]
[assembly: AssemblyCopyright("Copyright © Tom Cabanski 2009")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

//
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:

[assembly: AssemblyVersion("1.0.0.*")]
[assembly: PluginTitle("SouthSideSharper Sharper Plugin")]
[assembly: PluginVendor("Tom Cabanski")]
[assembly: PluginDescription("Basic Refactorings")]
[assembly: ActionsXml("SouthSideSharper.Actions.xml", Precompile = false)]