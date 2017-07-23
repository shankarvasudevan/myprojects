using System;
using System.Collections.Generic;
using NUnit.Framework;
using PracticeProblems;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class RouteCheckerTest
	{
		private RouteChecker routeChecker;

		[SetUp]
		public void Setup()
		{
			this.routeChecker = new RouteChecker();
		}

		[Test]
		public void RouteExists_OnlyTwoNodesInGraph_ConnectionOnlyOneWay()
		{
			var a = new GraphNode("a");
			var b = new GraphNode("b");

			a.ConnectedNodes.Add(b);

			Assert.That(
				routeChecker.RouteExists(a, b, new List<GraphNode>()), 
				Is.EqualTo(true), 
				"a->b should be true");
			
			Assert.That(
				routeChecker.RouteExists(b, a, new List<GraphNode>()), 
				Is.EqualTo(false), 
				"b->a should be false");
		}

		[Test]
		public void RouteExists_ThreeNodesInGraph_ConnectionOnlyOneWay()
		{
			var a = new GraphNode("a");
			var b = new GraphNode("b");
			var c = new GraphNode("c");

			a.ConnectedNodes.Add(b);
			b.ConnectedNodes.Add(c);

			Assert.That(
				routeChecker.RouteExists(a, b, new List<GraphNode>()), 
				Is.EqualTo(true), 
				"a->b should be true");
			
			Assert.That(
				routeChecker.RouteExists(a, c, new List<GraphNode>()), 
				Is.EqualTo(true), 
				"a->c should be true");

			Assert.That(
				routeChecker.RouteExists(b, a, new List<GraphNode>()), 
				Is.EqualTo(false), 
				"b->a should be false");
			
			Assert.That(
				routeChecker.RouteExists(b, c, new List<GraphNode>()), 
				Is.EqualTo(true), 
				"b->c should be true");

			Assert.That(
				routeChecker.RouteExists(c, a, new List<GraphNode>()), 
				Is.EqualTo(false), 
				"c->a should be false");
			
			Assert.That(
				routeChecker.RouteExists(c, b, new List<GraphNode>()), 
				Is.EqualTo(false), 
				"c->b should be false");
		}

		[Test]
		public void RouteExists_FourNodesInGraph_ConnectionOnlyOneWay()
		{
			var a = new GraphNode("a");
			var b = new GraphNode("b");
			var c = new GraphNode("c");
			var d = new GraphNode("d");

			a.ConnectedNodes.Add(b);
			b.ConnectedNodes.Add(c);
			b.ConnectedNodes.Add(d);

			Assert.That(
				routeChecker.RouteExists(a, b, new List<GraphNode>()), 
				Is.EqualTo(true), 
				"a->b should be true");
			
			Assert.That(
				routeChecker.RouteExists(a, c, new List<GraphNode>()),
				Is.EqualTo(true), 
				"a->c should be true");
			
			Assert.That(
				routeChecker.RouteExists(a, d, new List<GraphNode>()), 
				Is.EqualTo(true), 
				"a->d should be true");

			Assert.That(
				routeChecker.RouteExists(b, a, new List<GraphNode>()), 
				Is.EqualTo(false), 
				"b->a should be false");
			
			Assert.That(
				routeChecker.RouteExists(b, c, new List<GraphNode>()), 
				Is.EqualTo(true), 
				"b->c should be true");
			
			Assert.That(
				routeChecker.RouteExists(b, d, new List<GraphNode>()), 
				Is.EqualTo(true), 
				"b->d should be true");

			Assert.That(
				routeChecker.RouteExists(c, a, new List<GraphNode>()), 
				Is.EqualTo(false), 
				"c->a should be false");
			
			Assert.That(
				routeChecker.RouteExists(c, b, new List<GraphNode>()), 
				Is.EqualTo(false), 
				"c->b should be false");
			
			Assert.That(
				routeChecker.RouteExists(c, d, new List<GraphNode>()), 
				Is.EqualTo(false), 
				"c->d should be false");

			Assert.That(
				routeChecker.RouteExists(d, a, new List<GraphNode>()), 
				Is.EqualTo(false), 
				"d->a should be false");
			
			Assert.That(
				routeChecker.RouteExists(d, b, new List<GraphNode>()), 
				Is.EqualTo(false), 
				"d->b should be false");
			
			Assert.That(
				routeChecker.RouteExists(d, c, new List<GraphNode>()), 
				Is.EqualTo(false), 
				"d->c should be false");
		}

		[Test]
		public void RouteExists_FourNodesWithCycle_ConnectionOnlyOneWay()
		{
			var a = new GraphNode("a");
			var b = new GraphNode("b");
			var c = new GraphNode("c");
			var d = new GraphNode("d");

			a.ConnectedNodes.Add(b);
			b.ConnectedNodes.Add(c);
			c.ConnectedNodes.Add(a);
			b.ConnectedNodes.Add(d);

			Assert.That(
				routeChecker.RouteExists(a, b, new List<GraphNode>()), 
				Is.EqualTo(true), 
				"a->b should be true");
			
			Assert.That(
				routeChecker.RouteExists(a, c, new List<GraphNode>()), 
				Is.EqualTo(true), 
				"a->c should be true");
			
			Assert.That(
				routeChecker.RouteExists(a, d, new List<GraphNode>()), 
				Is.EqualTo(true), 
				"a->d should be true");

			Assert.That(
				routeChecker.RouteExists(b, a, new List<GraphNode>()), 
				Is.EqualTo(true), 
				"b->a should be true");
			
			Assert.That(
				routeChecker.RouteExists(b, c, new List<GraphNode>()), 
				Is.EqualTo(true), 
				"b->c should be true");
			
			Assert.That(
				routeChecker.RouteExists(b, d, new List<GraphNode>()), 
				Is.EqualTo(true), 
				"b->d should be true");

			Assert.That(
				routeChecker.RouteExists(c, a, new List<GraphNode>()), 
				Is.EqualTo(true), 
				"c->a should be true");
			
			Assert.That(
				routeChecker.RouteExists(c, b, new List<GraphNode>()),
				Is.EqualTo(true),
				"c->b should be true");
			
			Assert.That(
				routeChecker.RouteExists(c, d, new List<GraphNode>()),
				Is.EqualTo(true), 
				"c->d should be true");

			Assert.That(
				routeChecker.RouteExists(d, a, new List<GraphNode>()), 
				Is.EqualTo(false), 
				"d->a should be false");
			
			Assert.That(
				routeChecker.RouteExists(d, b, new List<GraphNode>()), 
				Is.EqualTo(false), 
				"d->b should be false");
			
			Assert.That(
				routeChecker.RouteExists(d, c, new List<GraphNode>()), 
				Is.EqualTo(false), 
				"d->c should be false");
		}
	}
}
