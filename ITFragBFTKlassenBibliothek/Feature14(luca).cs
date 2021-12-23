using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITFragBFTKlassenBibliothek
{
 /*
 WICHTIG!!! 

 Bitte erstelle eine neue Branch basierend auf ITEntwickellung und bearbeite da diese datei. 
 Bitte keine Änderungen an anderen dateien vornehmen.
 Wenn du möchtest das ich (Angelo) das menü für dein Feature erstelle, dann lass es mich wissen.
 Wenn du mir nichts Mitteilst gehe ich davon aus das du das Menü selber erstellst.
 Der Einstiegspunkt für deine Klasse ist die FeatureMenue Methode.
 */
    class Feature14
    {
        internal static void FeatureMenue()
        {

                double Vek_x, Vek_y, Vek_z;
                double Vek2_x, Vek2_y, Vek2_z;
            redo:
                try
                {

                    Console.WriteLine("Eingabe des Vektor 1");
                    Console.Write("\nx = ");
                    Vek_x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("y = ");
                    Vek_y = Convert.ToDouble(Console.ReadLine());
                    Console.Write("z = ");
                    Vek_z = Convert.ToDouble(Console.ReadLine());


                    Console.Write("\nEingabe des Vektor 2");
                    Console.Write("\nx = ");
                    Vek2_x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("y = ");
                    Vek2_y = Convert.ToDouble(Console.ReadLine());
                    Console.Write("z = ");
                    Vek2_z = Convert.ToDouble(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Es sind nur Richtige eingaben Erlaubt!");
                    Console.WriteLine("Bitte Geben sie nur Zahlen ein!");
                    Console.ReadKey();
                    Console.Clear();
                    goto redo;
                }

                Vector v0 = new Vector(Vek_x, Vek_y, Vek_z);


                Vector v1 = new Vector(Vek2_x, Vek2_y, Vek2_y);



                bool Hmenue;

                do
                {
                    Hmenue = false;
                    Console.Clear();
                    Console.WriteLine("Welche Art von Berechnung wollen sie vornehmen?");

                    Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                    Console.WriteLine("\t1 - Addition");
                    Console.WriteLine("\t2 - Subraktion");
                    Console.WriteLine("\t3 - Skalarprodukt\n");

                    Console.WriteLine("\t6 - Neu Eingabe der Vektoren\n");

                    Console.WriteLine("\ts - Submenü");
                    Console.WriteLine("\te - Exit\n");

                    Console.Write("Eingabe:");
                    String HauptAusw = Console.ReadLine().ToLower();

                    switch (HauptAusw)
                    {

                        case "1":
                            Console.Clear();

                            Console.WriteLine(v0);
                            Console.WriteLine(v1);

                            Console.WriteLine(v0 + v1);

                            Console.ReadKey();


                            break;

                        case "2":
                            Console.Clear();

                            Console.WriteLine(v0);
                            Console.WriteLine(v1);

                            Console.WriteLine(v0 - v1);

                            Console.ReadKey();


                            break;

                        case "3":
                            Console.Clear();

                            Console.WriteLine(v0);
                            Console.WriteLine(v1);

                            double s = v0 * v1;

                            Console.WriteLine("\nDer Skalarwert liegt bei {0}", s);


                            Console.ReadKey();

                            break;

                        case "6":
                            Console.Clear();

                            goto redo;

                        case "s":

                            Hmenue = true;
                        Console.Clear();
                            break;

                        case "e":

                            Environment.Exit(0);
                            break;

                        default:


                            Console.WriteLine("\nUngültige Eingabe");

                            Console.ReadKey();

                            (int, int) cPosAM = Console.GetCursorPosition();

                            break;

                    }

                } while (!Hmenue);

        }


            public class Vector
            {

                public double X { get; set; }
                public double Y { get; set; }
                public double Z { get; set; }


                public double this[int i]
                {
                    get
                    {
                        if (i == 0)
                        {
                            return this.X;
                        }
                        else if (i == 1)
                        {
                            return this.Y;
                        }
                        else if (i == 2)
                        {
                            return this.Z;
                        }
                        throw new Exception();
                    }
                    set
                    {
                        if (i == 0)
                        {
                            this.X = value;
                        }
                        else if (i == 1)
                        {
                            this.Y = value;
                        }
                        else if (i == 2)
                        {
                            this.Z = value;
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }



                public static Vector XAxis
                {
                    get => new Vector(1, 0, 0);
                }
                public static Vector YAxis
                {
                    get => new Vector(0, 1, 0);
                }
                public static Vector ZAxis
                {
                    get => new Vector(0, 0, 1);
                }

                public double Length
                {
                    get
                    {
                        return GetLength();
                    }
                }


                public Vector()
                {
                    this.X = 0;
                    this.Y = 0;
                    this.Z = 0;
                }

                public Vector(double x, double y, double z)
                {
                    this.X = x;
                    this.Y = y;
                    this.Z = z;
                }

                public Vector(Vector other)
                {
                    this.X = other.X;
                    this.Y = other.Y;
                    this.Z = other.Z;
                }


                private double GetLength()
                {
                    double sql = this.X * this.X + this.Y * this.Y + this.Z * this.Z;
                    double len = Math.Sqrt(sql);
                    return len;
                }

                public void Reverse()
                {
                    this.X = -this.X;
                    this.Y = -this.Y;
                    this.Z = -this.Z;
                }

                public void Scale(double factor)
                {
                    this.X *= factor;
                    this.Y *= factor;
                    this.Z *= factor;
                }

                public bool Unitize()
                {
                    double len = this.GetLength();
                    if (len <= 0)
                    {
                        return false;
                    }

                    this.X /= len;
                    this.Y /= len;
                    this.Z /= len;
                    return true;
                }

                public void Add(Vector other)
                {
                    this.X += other.X;
                    this.Y += other.Y;
                    this.Z += other.Z;
                }



                public static Vector operator +(Vector a, Vector b)
                {
                    return Vector.Addition(a, b);
                }

                public static double operator *(Vector a, Vector b)
                {
                    return Vector.DotProduct(a, b);
                }
                public static Vector operator -(Vector a, Vector b)
                {
                    return Vector.Subraktion(a, b);
                }
                public static Vector operator *(double a, Vector b)
                {
                    Vector v = new Vector(b);
                    v.Scale(a);
                    return v;
                }


                public static Vector Addition(Vector a, Vector b)
                {
                    double newX = a.X + b.X;
                    double newY = a.Y + b.Y;
                    double newZ = a.Z + b.Z;
                    Vector v = new Vector(newX, newY, newZ);
                    return v;
                }

                public static double DotProduct(Vector a, Vector b)
                {
                    return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
                }

                public static Vector Subraktion(Vector a, Vector b)
                {
                    double newX = a.X - b.X;
                    double newY = a.Y - b.Y;
                    double newZ = a.Z - b.Z;
                    Vector v = new Vector(newX, newY, newZ);
                    return v;
                }

                public static Vector Equals(Vector a, Vector b)
                {
                    double x = a.Y * b.Z - a.Z * b.Y;
                    double y = a.Z * b.X - a.X * b.Z;
                    double z = a.X * b.Y - a.Y * b.X;
                    return new Vector(x, y, z);
                }

                public Vector cross(Vector w)
                {
                    return new Vector(Y * w.Z - Z * w.Y, Z * w.X - X * w.Z, X * w.Y - Y * w.X);
                }


                // Overrides
                public override string ToString()
                {
                    return $"[{this.X}, {this.Y}, {this.Z}]";
                }


            }

    }
}
