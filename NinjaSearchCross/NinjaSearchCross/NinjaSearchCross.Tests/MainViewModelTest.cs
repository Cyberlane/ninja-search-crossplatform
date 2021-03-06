// <copyright file="MainViewModelTest.cs">joe</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using NUnit.Framework;
using NinjaSearchCross.ViewModels;

namespace NinjaSearchCross.ViewModels.Tests
{
    /// <summary>This class contains parameterized unit tests for MainViewModel</summary>
    [PexClass(typeof(MainViewModel))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestFixture]
    public partial class MainViewModelTest
    {
    }
}
