using System;
//using System.Math;
using System.Collections.Generic;
using System.Text;

namespace UebungPunkte
{
    public class PunktXY
    {
        protected double x;
        protected double y;

        public PunktXY()
        {
            this.x = 0.0;
            this.y = 0.0;
        }

        public PunktXY(double x, double y)
        {
            set(x, y);

            //this.x = x;
            //this.y = y;
        }

        // Getter , Setter
        public double X
        {
            get { return this.x; }
            set { this.x = value;  }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        // Setzen der Werte für einen Punkt
        public void set(double x, double y)
        {
            if (x >= 0 && y >= 0)
            {
                this.x = x;
                this.y = y;
            }
            else
            {
                this.x = 0.0;
                this.y = 0.0;
            }
        }
        
        public virtual void print()
        {
            Console.WriteLine("(" + this.x + "," + this.y + ")" );
        }



        public virtual double AbstandZuNullPunkt()
        {
            //  distance(P0, P1) = sqrt((x0)² + (y0)²)
            double abstand = Math.Sqrt(Math.Pow((this.x), 2) + Math.Pow((this.y), 2));
            return abstand;
        }

        public double AbstandZuPunkt(PunktXY pn)
        {
            //  distance(P0, P1) = sqrt((x0 - x1)² +(y0 - y1)²)
            double abstand = Math.Sqrt( Math.Pow((this.x - pn.x),2)   + Math.Pow((this.y - pn.y), 2));
            return abstand;
        }


        public static double AbstandZuPunkt(PunktXY p1, PunktXY p2)
        {
            double abstand = Math.Sqrt(Math.Pow((p1.x - p2.x), 2) + Math.Pow((p1.y - p2.y), 2));
            return abstand;
        }



    }
}
