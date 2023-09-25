// -----------------------------------------------------------------------
// <copyright file="AssemblyInfo.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

// The Sdk will expose its internals to the extensions as well as the test projects to allow them to reuse its infrastructure: retries,
// error handling, logging and so forth...
using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Microsoft.Store.PartnerCenter.Extensions")]

[assembly: InternalsVisibleTo("Microsoft.Store.PartnerCenter.Internal")]

[assembly: InternalsVisibleTo("Microsoft.Store.PartnerCenter.UnitTests")]

[assembly: InternalsVisibleTo("Microsoft.Store.PartnerCenter.Fakes")]

[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

[assembly: InternalsVisibleTo("Microsoft.Store.PartnerCenter.Internal.Test")]

[assembly: InternalsVisibleTo("Microsoft.Store.PartnerCenter.0.0.0.1.Fakes")]

[assembly: CLSCompliant(true)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: AssemblyTitle("Microsoft Partner Center SDK")]
[assembly: AssemblyDescription("SDK for accessing Microsoft Partner Center APIs.")]
[assembly: AssemblyCompany("Microsoft")]
[assembly: AssemblyProduct("PartnerSdk")]
[assembly: AssemblyCopyright("Copyright © 2023")]
[assembly: AssemblyVersion("3.4.0")]
[assembly: AssemblyFileVersion("3.4.0")]
