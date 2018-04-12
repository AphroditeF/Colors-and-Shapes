using System;
using System.Collections.Generic;

namespace ShapesAndColors
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Rectangle> rectangles = new List<Rectangle>();

            rectangles.Add(new Rectangle(7, 7));
            rectangles.Add(new Rectangle(4, 6));
            rectangles.Add(new Rectangle(5, 7));
            rectangles.Add(new Square(6));
            rectangles.Add(new Square(7));
            rectangles.Add(new Square(8));

            rectangles.Sort();

            foreach (Rectangle item in rectangles)
            {        //Print after sorting
                Console.WriteLine(item);
            }


           /* 

            testing

            string message;

            Rectangle rec1= new Rectangle(7,7);
            message = rec1.GetInfo();
            Console.WriteLine(message);
            Console.WriteLine(rec1.ToString()); 

            Rectangle rec2 = new Rectangle(6, 5);
            message = rec2.GetInfo();
            Console.WriteLine(message);//override ToString()

            Shape boo = new Rectangle(5, 6);
            message = boo.GetInfo();
            Console.WriteLine(message);

            Square sq1 = new Square(7);
            message = sq1.GetInfo();
            Console.WriteLine(message);

            Rectangle sq2 = new Square(8);
            message = sq2.GetInfo();
            Console.WriteLine(message);

            Shape sq3 = new Square(9);
            message = sq3.GetInfo();
            Console.WriteLine(message);

            Console.WriteLine(
                rec1.CompareTo(sq1));

            Console.WriteLine(
                rec1.Equals(sq1));

            Console.WriteLine(
                rec1.GetArea());*/
            
        }
    }
}
