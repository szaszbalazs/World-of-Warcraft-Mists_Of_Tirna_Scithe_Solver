using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MistsOfTirnaScithe
{
    public class Input
    {
		private bool circle;

		public bool Circle
		{
			get { return circle; }
			set { circle = value; }
		}

		private string mainprop;

		public string Mainprop //leaf or flower
		{
			get { return mainprop; }
			set { mainprop = value; }
		}

		private bool colored;

        

        public bool Colored
		{
			get { return colored; }
			set { colored = value; }
		}

        public Input(bool circle, string mainprop, bool colored)
        {
            Circle = circle;
            Mainprop = mainprop;
            Colored = colored;
        }
    }
}
