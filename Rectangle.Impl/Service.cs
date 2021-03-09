using System;
using System.Collections.Generic;
using System.Linq;

namespace Rectangle.Impl
{
	public static class Service
	{
		/// <summary>
		/// See TODO.txt file for task details.
		/// Do not change contracts: input and output arguments, method name and access modifiers
		/// </summary>
		/// <param name="points"></param>
		/// <returns></returns>
		public static Rectangle FindRectangle(List<Point> points)
		{
			var xMax = points.Max(x => Math.Abs(x.X));
			var yMax = points.Max(y => Math.Abs(y.Y));

			if (xMax > yMax)
				xMax--;
			else
				yMax--;

			var width = GetDistanceToStart(new Point(xMax, 0)) * 2;
			var height = GetDistanceToStart(new Point(yMax, 0)) * 2;

			return new Rectangle(xMax, yMax, width, height);
		}

		private static int GetDistanceToStart(Point point)
        {
			return (int)Math.Sqrt(Math.Pow(point.X, 2) + Math.Pow(point.Y, 2));
		}
	}
}
