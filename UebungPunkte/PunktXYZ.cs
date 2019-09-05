using System;
using System.Collections.Generic;
using System.Text;

namespace UebungPunkte
{
    public class PunktXYZ : PunktXY
    {
        private double z;

        public PunktXYZ()
        {
          //  this.x = 0.0;   // es wird automaisch der std konstruktor der basisklasssen aufgerufen, deswegen brauch ich das hier nicht machen
          //  this.y = 0.0;
            this.z = 0.0;
        }
        
        public PunktXYZ(double x, double y , double z) : this() // Aufruf von 3 Konstruktoren, den hier, dann dden STD von XYZ und den STD von XY
        {                                                       // so sind dann alle Werte zugewiesen
            set(x, y, z);
        }



        // Getter , Setter
        public double Z
        {
            get { return this.z; }
            set
            {
                if (value >=  0)
                {
                    this.z = value;
                }
            }
        }




        public bool set(double x, double y, double z)
        {

            if (set(x,y) && z >= 0)
            {
                this.z = z;
                return true;
            }
            return false;

            /*
            else
            {
                this.x = 0.0;
                this.y = 0.0;
                this.z = 0.0;
            }
            */
        }

        public override double AbstandZuNullPunktVirtual()
        {
            Console.WriteLine("PunktXYZ.AbstandZuNullPunktVirtual()");
            //  distance(P0, P1) = sqrt((x0)² + (y0)² + (z0)²)
            double abstand = Math.Sqrt(Math.Pow((this.X), 2) + Math.Pow((this.Y), 2) + Math.Pow((this.z), 2));
            return abstand;
        }


        // Beispiel einer nicht-virtuellen Methode der Basisklasse mittels Operator "new"
        public new double AbstandZuNullPunkt()
        {
            Console.WriteLine("PunktXYZ.AbstandZuNullPunkt()");
            //  distance(P0, P1) = sqrt((x0)² + (y0)²)
            double abstand = Math.Sqrt(Math.Pow((this.X), 2) + Math.Pow((this.Y), 2) + Math.Pow((this.z), 2));
            return abstand;
        }







        public double AbstandZuPunkt(PunktXYZ pn)
        {
            //  distance(P0, P1) = sqrt((x0 - x1)² +(y0 - y1)² + (z0-z1)²)
            double abstand = Math.Sqrt(Math.Pow((this.X - pn.X), 2) + Math.Pow((this.Y - pn.Y), 2) + Math.Pow((this.z - pn.z), 2));
            return abstand;
        }

        public static double AbstandZuPunkt(PunktXYZ p1, PunktXYZ p2)
        {
            double abstand = Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2) + Math.Pow((p1.z - p2.z), 2));
            return abstand;
        }

        public override void print()
        {
           Console.WriteLine("(" + this.X + "," + this.Y + "," + this.z + ")");
        }

    }
}
