#region Using directives

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;

#endregion

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle(@"")]
[assembly: AssemblyDescription(@"")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(@"BrainTec")]
[assembly: AssemblyProduct(@"NHibernateDesigner")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: System.Resources.NeutralResourcesLanguage("en")]

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

[assembly: AssemblyVersion(@"1.0.0.0")]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
[assembly: ReliabilityContract(Consistency.MayCorruptProcess, Cer.None)]

//
// Make the Dsl project internally visible to the DslPackage assembly
//
[assembly: InternalsVisibleTo(@"BrainTec.NHibernateDesigner.DslPackage, PublicKey=0024000004800000940000000602000000240000525341310004000001000100D7DD1AD5C887EDCCCD587C276671714672235DB1732999DE9B929A74C98C23F2D97BDA574092FE323A23ED5AAC5FFC72439249B120C4583F983AC596DF974791DF92F36B52AC77FB9F41DBE8BB4CAA07CFCBBEA2B6BB9CB9CC78C5295301936ABE40ECE0E0DC306AC389547D2C324E1486C0E9FAEACA1CA7871EFF43BBECC19C")]