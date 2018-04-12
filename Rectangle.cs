using System;
namespace ShapesAndColors
{
    public class Rectangle : Shape, IComparable, IEquatable<Rectangle> //Square class inherit all these!!

    {
        //------------ Immutable objects --------------------------------------
        protected readonly double _width;
        protected readonly double _height;

        public double Width { get { return _width; } }     //two public properties which return width and height 
        public double Height { get { return _height; } }

        public Rectangle(double width, double height)  //constructor
        {
            _width = width;
            _height = height;
        }
        //---------------------------------------------------------------------

        public double GetArea()
        {    //The exercise asks for public virtual void  GetArea(){....}, 
            //but because of the name "GetArea" I want my function returning the result in a double type.
            //I don't use "virtual", because there is no need.
            return Width * Height;
        }

		
        //--------------------------------------------------------------------
        public new string GetInfo()     //It's a "new" method. So, I have access to GetInfo() of the parent class: Shape if there is need in future
                                        //Shape boo=new Rectangle(4,5); 
                                        //boo.GetInfo(); 
                                         
		{
            string s;
            s = "Rectangle of color ";
            s += Color.ToString();
            s += ", width ";
            s += Width;
            s += " and height ";
            s += Height;
            s += ".";

            return s;

		}
        //---------------------------------------------------------------------
        private string _name; //This field is inheried by subclasses.
                               //The exercise asked for this. There is no need to use it.


        //----------------- override ToString() -------------------------------  
        //I override this method in 3 classes: Shape, Rectangle and Square to use "the specific object's info". 
        public override string ToString()
        {
            return GetInfo();
        }
        //--------------- end override ToString() ----------------------------- 



        //---------------------------------------------------------------------

        public int CompareTo(object obj) //Adapt CompareTo to my class, so I can use it on my class. It's necessary for IComparable and IEquatable<Rectangle> 
        {
            int result = -10;
            if(obj is Rectangle other){
                if ( (int)other.GetArea() > (int)this.GetArea())

                {
                    result = -1;
                }

                else if((int)other.GetArea() < (int)this.GetArea()){
                    result = 1;
                }
                else if((int)other.GetArea() == (int)this.GetArea()){
                    result = 0;
                }
            }

            return result;
        }

        //---------------------------------------------------------------------
        public bool Equals(Rectangle obj) ////Adapt Equals to my class, so I can use it on my class. It's necessary for IEquatable<Rectangle> 
        {
            Rectangle other = obj as Rectangle;
            bool result = false;
            if ((int)this.GetArea() == (int)other.GetArea())
            {
                result = true;
            }
            //Second way
            //if (this.CompareTo(other) == 0)
               // result = true;
            return result;
        }

	}
}
