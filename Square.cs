using System;
namespace ShapesAndColors
{
    public sealed class Square : Rectangle
    { 
        //--------------------------------------------------------------------
        public Square(double side):base ( side,  side){
            //double side;
        }


        //--------------------------------------------------------------------
        public new string GetInfo()     //It's a "new" method. So, I have access to GetInfo() of class Shape if there is need in future
                                        //Shape boo=new Rectangle(4,5); 
                                        //boo.GetInfo(); 

        {
            string s;
            s = "Square of color ";
            s += Color.ToString();
            s += "and side length ";
            s += Width;                 //or s+=Height; They have the same value, but different refs.
            s += ".";

            return s;
        }


        //----------------- override ToString() -------------------------------  
        //I override this method in 3 classes: Shape, Rectangle and Square to use "the specific object's info". 
        public override string ToString()
        {
            return GetInfo();
        }
        //--------------- end override ToString() ----------------------------- 

    
    }
        
}
