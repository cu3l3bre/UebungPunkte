using System;
//using System.Math;
using System.Collections.Generic;
using System.Text;

namespace UebungPunkte
{
    public class PunktXY
    {
        private double x;
        private double y;

        public PunktXY()
        {
            this.x = 0.0;
            this.y = 0.0;
        }

        public PunktXY(double x, double y) : this() // Aufruf des Std Konstruktos das die werte erstmal 0 sind
        {
            set(x, y);
        }

        // Getter , Setter
        public double X
        {
            get { return this.x; }
            set
            {
                if (value >= 0)
                {
                    this.x = value;
                }
            }
        }

        public double Y
        {
            get { return this.y; }
            set
            {
                if (value >= 0)
                {
                    this.y = value;
                }
            }
        }

        // Setzen der Werte für einen Punkt
        public bool set(double x, double y)
        {
            if (x >= 0 && y >= 0)
            {
                this.x = x;
                this.y = y;
                return true;
            }
            /*
            else
            {
                this.x = 0.0;
                this.y = 0.0;
                return false;
            }
            */
            return false;
        }
        
        public virtual void print()
        {
            Console.WriteLine("(" + this.x + "," + this.y + ")" );
        }




        public virtual double AbstandZuNullPunktVirtual()
        {
            //  distance(P0, P1) = sqrt((x0)² + (y0)²)
            Console.WriteLine("PunktXY.AbstandZuNullPunktVirtual()");
            double abstand = Math.Sqrt(Math.Pow((this.x), 2) + Math.Pow((this.y), 2));
            return abstand;
        }


        public double AbstandZuNullPunkt()
        {
            Console.WriteLine("PunktXY.AbstandZuNullPunkt()");
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
