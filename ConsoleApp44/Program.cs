﻿using System;
using System.Collections.Generic;

namespace ConsoleApp43
{
    class Program
    {


        static void Main(string[] args)
        {

            double Cup = 450;
            double tracklength = 0;
            double velocity = Getspeed();
            double angle = Getangle();
            double strokes = 1; //Getstrokes();
            double balllength = GetLength(angle, velocity);
            double lengTotoCup = Cup - balllength;
            List<string> score = new List<string>();



            tracklength = tracklength + balllength;




            while (score.Count < 10 && lengTotoCup < Cup && lengTotoCup >= 0.1 && tracklength < 700)
            {



                balllength = Math.Round(balllength, 1);
                Console.WriteLine("Ball traveld: " + balllength);

                lengTotoCup = Math.Round(lengTotoCup, 1);
                Console.WriteLine("Left to cup: " + lengTotoCup);
                Console.ReadKey();
                score.Add("Ball travel: " + balllength + " and left to cup: " + lengTotoCup);

                strokes = strokes + 1;
                velocity = Getspeed();
                angle = Getangle();
                balllength = GetLength(angle, velocity);
                lengTotoCup = Math.Abs(lengTotoCup - balllength);




                if (lengTotoCup == 0)
                {
                    Console.WriteLine("you ball hit the cup.");

                }
                else if (strokes > 10)
                {
                    Console.WriteLine("you are out of strokes");
                }





            }

            Console.WriteLine("HISTORY");
            foreach (var item in score)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }



        public static double Getspeed()
        {
            double velocity = 0;
            bool noNumber = false;
            do
            {
                Console.Write("write velocity");
                try
                {

                    velocity = double.Parse(Console.ReadLine());
                    Math.Round(velocity, 1);
                    noNumber = false;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Please write a number.");


                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number you write is not between 1-100");

                }

            } while (noNumber || velocity <= 0.1 && velocity > 100);
            return velocity;
        }// end of method get speed

        public static double Getangle()
        {
            double angle = 0;
            bool noNumber = false;
            do

            {
                Console.Write("write angle");
                try
                {

                    angle = double.Parse(Console.ReadLine());
                    Math.Round(angle, 1);

                    noNumber = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please write a number.");

                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number you write is not between 1-55");

                }
            } while (noNumber || angle <= 0.1 && angle > 90);
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

       

        }


    }


