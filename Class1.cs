using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NullableEnumDataRow
{
	public enum CountryCode
	{
		NL = 1,
		GB = 2,
		FR = 3
	}

	[TestClass]
	public class UnitTests
	{
		[DataTestMethod]
		[DataRow("NL", CountryCode.NL)]
		[DataRow("GB", CountryCode.GB)]
		[DataRow("FR", CountryCode.FR)]
		[DataRow("UK", null)]
		public void Test_GetCountryCodeByCountryName(string countryName, CountryCode? expectedCountryCode)
		{
		}
	}
}