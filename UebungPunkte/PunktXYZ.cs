using System;
using System.Collections.Generic;
using System.Text;

namespace UebungPunkte
{
    public class PunktXYZ : PunktXY
    {
        double z;

        public PunktXYZ()
        {
            this.x = 0.0;
            this.y = 0.0;
            this.z = 0.0;
        }
        
        public PunktXYZ(double x, double y , double z) : base(x, y)
        {
            set(x, y, z);
        }



        // Getter , Setter
        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }




        public void set(double x, double y, double z)
        {

            if (x >= 0 && y >= 0 && z >= 0)
            {
                base.set(x, y);
                this.z = z;
            }
            else
            {
                this.x = 0.0;
                this.y = 0.0;
                this.z = 0.0;
            }
        }

        public override double AbstandZuNullPunkt()
        {
            //  distance(P0, P1) = sqrt((x0)² + (y0)² + (z0)²)
            double abstand = Math.Sqrt(Math.Pow((this.x), 2) + Math.Pow((this.y), 2) + Math.Pow((this.z), 2));
            return abstand;
        }


        public double AbstandZuPunkt(PunktXYZ pn)
        {
            //  distance(P0, P1) = sqrt((x0 - x1)² +(y0 - y1)² + (z0-z1)²)
            double abstand = Math.Sqrt(Math.Pow((this.x - pn.x), 2) + Math.Pow((this.y - pn.y), 2) + Math.Pow((this.z - pn.z), 2));
            return abstand;
        }

        public static double AbstandZuPunkt(PunktXYZ p1, PunktXYZ p2)
        {
            double abstand = Math.Sqrt(Math.Pow((p1.x - p2.x), 2) + Math.Pow((p1.y - p2.y), 2) + Math.Pow((p1.z - p2.z), 2));
            return abstand;
        }

        public override void print()
        {
           Console.WriteLine("(" + this.x + "," + this.y + "," + this.z + ")");
        }

    }
}
