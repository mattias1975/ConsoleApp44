using System;

namespace ConsoleApp43
{
    class Program
    {


        static void Main(string[] args)
        {


            double Cup = 450;
            double velocity = Getspeed();
            double angle = Getangle();
            double strokes = 1; //Getstrokes();
            double balllength = GetLength(angle, velocity);
            double lengTotoCup = Cup - balllength;

                     
            { 
            while (strokes < 10 && lengTotoCup < Cup || lengTotoCup != 0)

            {
             
                {


                    Console.WriteLine("Ball traveld: " + balllength);
                    Console.WriteLine("Left to cup: " + lengTotoCup);
                    Console.ReadKey();


                    strokes = strokes + 1;
                    velocity = Getspeed();
                    angle = Getangle();
                    balllength = GetLength(angle, velocity);
                    lengTotoCup = Math.Abs(lengTotoCup - balllength);
                    Console.ReadKey();

                        if (strokes > 10)
                        {
                            Console.WriteLine("You are out of strokes");
                            Console.ReadKey();
                        }
                        else if (lengTotoCup == 0)
                        {
                            Console.WriteLine("You got ball in cup");
                            Console.ReadKey();
                        }
                                                
                                        }
                                                  
                  

            }

            
        }
            }
      
        
        public static double Getspeed()
        {
            Console.Write("write velocityt");
            double velocity = double.Parse(Console.ReadLine());
            return velocity;
        }

        public static double Getangle()
        {


            Console.Write("write angle");

            double angle = double.Parse(Console.ReadLine());
            return angle;
        }
        public static double GetLength(double angle, double velocity)
        {
            double length;



            double angleRad = (Math.PI / 180) * angle;
            // Distance: Math.Pow(velocity, 2) / GRAVITY * Math.Sin(2 * angleInRadians)
            length = Math.Pow(velocity, 2) / 9.8 * Math.Sin(2 * angleRad);

            return length;

        }


        private static double Getstrokes()
        {
                {

                    double strokes = double.Parse(Console.ReadLine());
                    strokes = strokes + strokes;
                    return strokes;
                
                }

            
                }
        }


    }



