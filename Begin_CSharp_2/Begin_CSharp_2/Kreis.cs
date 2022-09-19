using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Begin_CSharp_2
{
    public class Kreis : IGeometry
    {
        public float Radius { get; set; }

        public Kreis(int radius)
        {
            Radius = radius;
        }

        public float Umfang()
        {
            return 2 * (float)Math.PI * Radius;
        }

        public float Flaeche()
        {
            return (float)Math.PI * Radius * Radius;
        }
    }
}
