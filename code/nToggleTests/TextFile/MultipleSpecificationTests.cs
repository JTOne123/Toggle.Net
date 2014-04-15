﻿using nToggle.Internal;
using nToggle.Providers.TextFile;
using nToggleTests.TextFile.Helpers;
using NUnit.Framework;
using SharpTestsEx;

namespace nToggleTests.TextFile
{
	public class MultipleSpecificationTests
	{
		[Test]
		public void ShouldBeDisabled()
		{
			var content = new[]
			{
				"someflag=false",
				"someflag=true"
			};
			var toggleChecker = new ToggleChecker(new FileProvider(new FileReaderHardCoded(content)));
			toggleChecker.IsEnabled("someflag")
				.Should().Be.False();
		}
	}
}