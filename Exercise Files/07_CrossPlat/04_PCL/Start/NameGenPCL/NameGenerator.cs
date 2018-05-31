using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NameGenPCL {
	public static class NameGenerator {

		public static string GetTourName() {



			return "Barcelona Bike Tours";

		}
		public static void BigNumber() {
			var big = new System.Numerics.BigInteger();
			big += 1000 * 1000 * 1000;
			big *= big * big * big;
			big *= big * big;
		}
	}
}
