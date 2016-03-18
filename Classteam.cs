using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Osztalyteam
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader inputData = new StreamReader("osztalyteam.csv", Encoding.UTF7);
            string textInOnePiece = inputData.ReadToEnd();



            string[] allText = textInOnePiece.Split('\r');
            foreach (string lineOfText in allText)
            {
                Console.WriteLine(lineOfText);
            }

            //string[] schoolclasses = textInOnePiece.Split(';');
            //foreach (string schoolclass in schoolclasses)
            //{
            //    Console.WriteLine(schoolclass);
            //}

            //4 sáv létrehozása
            //egy lehetséges sorrendje az osztályoknak (majd az összes sorrend, azaz sávokba választjuk az osztályokat)
            //tanárok hozzárendelése az osztályokhoz:
            // - ha osztályfőnök, akkor abba az osztályban teszzük, ahol ofő
            // - ha nem ofő, akkor betesszük az első osztályba, ahol tanít
            //sávonként nézzük a beosztást:
            //összes lehetséges beosztás elkészítése, minimum létszám megmondása
            //Ha a currentmin kisebb mint a min akkor az lesz az új min és az állást betesszük a bestDisposition-ba 

            int numberOfLanes = 4;
            int[][] lanes = new int[numberOfLanes][];
            Console.ReadKey();
        }
    }
}


