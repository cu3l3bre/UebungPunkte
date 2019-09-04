using System;
using System.Collections.Generic;

namespace UebungPunkte
{

 
    /*
 * Aufgabe: Definieren Sie zunächst eine Klasse 'PunktXY', deren Instanzen Punkte 
 *          in der Ebene (kartesisches Koordinatensystem) repräsentieren sollen.
 *
 *          Die Koordinaten dieser Punkte sind vom Typ 'double':
 * 
 *             - der Default-Konstruktor der Klasse soll die Koordinaten
 *               jeweils mit dem Wert 0.0 initialisieren
 *             - eine Konstruktorüberladung soll die beiden als Parameter
 *               übergebenen Koordinaten prüfen und ggf. dem Objekt zuweisen
 *               (die Koordinaten dürfen dabei nicht negativ sein)
 *             - eine 'Set(x,y)'-Methode soll den Koordinaten Werte zuweisen,
 *               wobei nur positive Werte oder 0.0 erlaubt sind
 *             - zwei Properties 'X' und 'Y' sollen sowohl Lese- als 
 *               auch Schreibzugriff auf die aktuellen Koordinaten des
 *               aufrufenden 'PunktXY'-Objekts ermöglichen
 *             - eine virtuelle Methode 'AbstandZuNullPunkt()'
 *               soll den Euklid'schen Abstand des aufrufenden 'PunktXY'-Objekts
 *               zum Ursprung (0,0) des Koordinatensystems berechnen und zurückgeben 
 *             - zusätzlich soll eine Methode 'AbstandZuPunkt(PunktXY p)' existieren, 
 *               die den Abstand des aufrufenden 'PunktXY'-Objekts 
 *               zu einem anderen 'PunktXY'-Objekt berechnet und zurückliefert
 *               (wie müsste eine statische Version dieser Methode aussehen?)
 *
 *               Euklid'sche Abstandsberechnung zwischen den Punkten P0 und P1
 *               im zweidimensionalen Fall:
 *               
 *                      distance(P0,P1) = sqrt((x0-x1)² + (y0-y1)²) 
 *               
 *                          mit P0 = (x0,y0) und P1 = (x1,y1)
 *
 * 
 *          Leiten Sie davon eine Klasse 'PunktXYZ' ab, die 'PunktXY' mit möglichst
 *          wenig Aufwand um eine Koordinate z erweitert, welche die dritte Dimension
 *          repräsentiert und für die die gleichen Bedingungen wie für x und y gelten:
 *
 *             - definieren Sie entsprechend eine 'Z'-Property
 *             - implementieren Sie eine 'Set(x,y,z)'-Methode,
 *               welche die 'Set(x,y)'-Methode der Basisklasse 
 *               'PunktXY' benutzt und gleichzeitig überlädt
 *             - überschreiben Sie die geerbte virtuelle Methode 'AbstandZuNullPunkt()',
 *               indem Sie die auf den dreidimensionalen Raum 
 *               erweiterte Euklid'sche Abstandsformel verwenden
 *             - zusätzlich soll eine Methode 'AbstandZuPunkt(PunktXYZ p)' existieren, 
 *               die den Abstand des aufrufenden 'PunktXYZ'-Objekts 
 *               zu einem anderen 'PunktXYZ'-Objekt berechnet und zurückliefert
 *               (wie müsste eine statische Version dieser Methode aussehen?)
 *
 *               Euklid'sche Abstandsberechnung zwischen den Punkten P0 und P1
 *               im dreidimensionalen Fall:
 *               
 *                      distance(P0,P1) = sqrt((x0-x1)² + (y0-y1)² + (z0-z1)²) 
 *               
 *                          mit P0 = (x0,y0,z0) und P1 = (x1,y1,z1)
 * 
 *          Testen Sie ihre Implementierung mittels geeigneter Punkt-Objekte.
 * 
 *          Fügen Sie weiterhin einige 'PunktXY'- und 'PunktXYZ'-Objekte
 *          in eine geeignete Liste mit Referenzen vom Typ 'PunktXY' ein
 *          und rufen Sie beim Durchlaufen dieser Liste über jede Referenz
 *          die Ursprungsabstandsmethode auf.
 */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uebung zu Klassen mit Punkten");

            List<PunktXY> punkte = new List<PunktXY>(); 

            PunktXY p1 = new PunktXY(1.0, 1.0);
            PunktXY p2 = new PunktXY(1.0, 5.0);
            PunktXY p3 = new PunktXY();
            PunktXY p4 = new PunktXY(2.0, 2.0);

            PunktXY p5 = new PunktXY(3.0, 0.0);
            PunktXY p6 = new PunktXY(0.0, 11.0);
            PunktXY p7 = new PunktXY(2.0, 2.0);

            //Console.WriteLine("p1(" + p1.X + "," + p1.Y + ")");
            p1.print();
            p2.print();
            p3.print();

            p3.set(10.0, 1.0);
            p3.print();


            Console.WriteLine(p1.AbstandZuPunkt(p2));

            Console.WriteLine(PunktXY.AbstandZuPunkt(p1, p2));


            Console.WriteLine(p1.AbstandZuPunkt(p3));
            Console.WriteLine(p1.AbstandZuPunkt(p4));

            Console.WriteLine(p5.AbstandZuNullPunkt());
            Console.WriteLine(p6.AbstandZuNullPunkt());
            Console.WriteLine(p7.AbstandZuNullPunkt());


            PunktXYZ p1_3D = new PunktXYZ(1.0, 0.0, 0.0);
            PunktXYZ p2_3D = new PunktXYZ(0.0, 1.0, 0.0);
            PunktXYZ p3_3D = new PunktXYZ(0.0, 0.0, 1.0);
            PunktXYZ p4_3D = new PunktXYZ(1.0, 1.0, 1.0);
            PunktXYZ p5_3D = new PunktXYZ(2.0, 2.0, 2.0);

            Console.WriteLine();
            Console.WriteLine(p1_3D.AbstandZuNullPunkt());
            Console.WriteLine(p2_3D.AbstandZuNullPunkt());
            Console.WriteLine(p3_3D.AbstandZuNullPunkt());
            Console.WriteLine(p4_3D.AbstandZuNullPunkt());

            Console.WriteLine(p4_3D.AbstandZuPunkt(p5_3D));

            //Console.WriteLine(p4_3D.AbstandZuPunkt(p5));

            Console.WriteLine(PunktXYZ.AbstandZuPunkt(p5_3D , p4_3D));


            punkte.Add(p1);
            punkte.Add(p2);
            punkte.Add(p3);
            punkte.Add(p4);
            punkte.Add(p5);
            punkte.Add(p6);
            punkte.Add(p7);

            punkte.Add(p1_3D);
            punkte.Add(p2_3D);
            punkte.Add(p3_3D);
            punkte.Add(p4_3D);
            punkte.Add(p5_3D);

            Console.WriteLine();

            foreach (PunktXY p in punkte)
            {
                Console.Write(p.GetType() + "\t");
                p.print();
            }




            Console.ReadKey();
        }
    }
}
