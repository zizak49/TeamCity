using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Pood.TeamCityTest
{
	[TestClass]
	public class TestSquared
	{
		[TestMethod]
		public void SquaredReturns4forArgument2()
		{
			Assert.AreEqual(4, MyMath.Squared(2));
		}

		[TestMethod]
		public void SquaredReturns0forArgument0()
		{
			Assert.AreEqual(0, MyMath.Squared(0));
		}

		[TestMethod]
		public void SquaredReturns4forArgumentMinus2()
		{
			Assert.AreEqual(4, MyMath.Squared(-2));
		}
	}
}

