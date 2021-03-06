// <copyright file="PexAssemblyInfo.cs">joe</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "NUnit2")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("NinjaSearchCross")]
[assembly: PexInstrumentAssembly("System.Resources.ResourceManager")]
[assembly: PexInstrumentAssembly("System.Globalization")]
[assembly: PexInstrumentAssembly("System.Reflection")]
[assembly: PexInstrumentAssembly("System.Diagnostics.Debug")]
[assembly: PexInstrumentAssembly("System.Runtime")]
[assembly: PexInstrumentAssembly("ReactiveUI")]
[assembly: PexInstrumentAssembly("System.Diagnostics.Tools")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Resources.ResourceManager")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Globalization")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Reflection")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Diagnostics.Debug")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Runtime")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "ReactiveUI")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Diagnostics.Tools")]

