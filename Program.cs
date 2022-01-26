// See https://aka.ms/new-console-template for more informationusing System;
using System.Collections.Generic;

namespace UrbanPlanner
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Name each building and give them properties
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            FiveOneTwoEigth.Width = 700;
            FiveOneTwoEigth.Depth = 400;
            FiveOneTwoEigth.Stories = 10;
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Whit");

            Building OneTwoThree = new Building("12 3rd Avenue");
            OneTwoThree.Width = 1100;
            OneTwoThree.Depth = 1500;
            OneTwoThree.Stories = 15;
            OneTwoThree.Construct();
            OneTwoThree.Purchase("Polo");


            Building TwelveTwelveTwelve = new Building("1212 12th Avenue");
            TwelveTwelveTwelve.Width = 1200;
            TwelveTwelveTwelve.Depth = 900;
            TwelveTwelveTwelve.Stories = 13;
            TwelveTwelveTwelve.Construct();
            TwelveTwelveTwelve.Purchase("Shine");


            Building OneTwoThirtyFour = new Building("12 34th Avenue");
            OneTwoThirtyFour.Width = 850;
            OneTwoThirtyFour.Depth = 1600;
            OneTwoThirtyFour.Stories = 22;
            OneTwoThirtyFour.Construct();
            OneTwoThirtyFour.Purchase("Jasmyn");


            Building Thirteenth = new Building("13th Avenue");
            Thirteenth.Width = 920;
            Thirteenth.Depth = 380;
            Thirteenth.Stories = 30;
            Thirteenth.Construct();
            Thirteenth.Purchase("Jason");

            //Make a list of all the buildings
            List<Building> Buildings = new List<Building>()
            {
                FiveOneTwoEigth,
                OneTwoThree,
                TwelveTwelveTwelve,
                OneTwoThirtyFour,
                Thirteenth
            };

            //Loop through the list and print desired information
            foreach (Building building in Buildings)
            {
                Console.WriteLine(building.Address);
                Console.WriteLine("---------------");
                Console.WriteLine($"Designer: {building.Designer}");
                Console.WriteLine($"Construction Date: {building.ConstructedDate}");
                Console.WriteLine($"Owner: {building.Owner}");
                Console.WriteLine($"{building.Volume} cubic meters");
                Console.WriteLine();
            }


        }
    }
}