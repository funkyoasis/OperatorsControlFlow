using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OperatorsApp;


namespace OperatorsControlFlowTest
{
	class StoneTest
	{
		[SetUp]
		public void Setup()
		{
		}
		[TestCase(144,10)]
		public void Given_144_Pounds_Stone_Returns_10(int pounds, int expStones)
		{
			var result = Methods.GetStones(pounds);
			Assert.That(result, Is.EqualTo(expStones));

		}
		[TestCase(0)]
		[TestCase(40)]
		[TestCase(64)]
		public void GivenAMarkLessThan65_Grade_returnsFail(int mark)
		{
			Assert.That(Methods.Grade(mark), Is.EqualTo("Fail"));
		}

		[TestCase(65)]
		[TestCase(73)]
		public void GivenAMarkLessThan65_Grade_returnsPass(int mark)
		{
			Assert.That(Methods.Grade(mark), Is.EqualTo("Pass"));
		}

		[TestCase(85)]
		[TestCase(99)]
		public void GivenAMarkLessThan65_Grade_returnsDistinction(int mark)
		{
			Assert.That(Methods.Grade(mark), Is.EqualTo("Distinction"));
		}
	}
}
