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
            Console.WriteLine("Hello World!");
        }
    }
}
