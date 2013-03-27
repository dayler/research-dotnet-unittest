using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;


// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("ProjectToTest")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Microsoft")]
[assembly: AssemblyProduct("ProjectToTest")]
[assembly: AssemblyCopyright("Copyright © Microsoft 2013")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("a9a15833-616d-4031-ab2d-73dd753ad7c4")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

// Assembly visbles for unit tests
[assembly: InternalsVisibleTo("ProjectToTestNUnitTest")]
[assembly: InternalsVisibleTo("ProjectToTestMSTest")]
[assembly: InternalsVisibleTo("ProjectToTestMbUnit")]

// Directive used to enable the internal access for NSubrutine
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]


