// -----------------------------------------------------------------------
// <copyright file="AssemblyInfo.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// The models assembly will expose its internals to the SDK project, extensions, internal SDK and the test projects.
[assembly: InternalsVisibleTo("Microsoft.Store.PartnerCenter")]

[assembly: InternalsVisibleTo("Microsoft.Store.PartnerCenter.Extensions")]

[assembly: InternalsVisibleTo("Microsoft.Store.PartnerCenter.Internal")]

[assembly: InternalsVisibleTo("Microsoft.Store.PartnerCenter.UnitTests")]

[assembly: InternalsVisibleTo("Microsoft.Store.PartnerCenter.Fakes")]

[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Microsoft.Store.PartnerCenter.Models")]
[assembly: AssemblyDescription("Contains partner center API data models.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Microsoft")]
[assembly: AssemblyProduct("PartnerSdk.Models")]
[assembly: AssemblyCopyright("Copyright © 2023")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("b474b775-5d0f-4582-879d-b2838c4ba951")]

[assembly: CLSCompliant(true)]

// Version information for an assembly consists of the following 3 values:
//
//      Major Version
//      Minor Version
//      Patch Version
//
// You can specify all the values or you can default the Minor and Patch Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("3.4.0")]
[assembly: AssemblyFileVersion("3.4.0")]