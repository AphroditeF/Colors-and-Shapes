using System;
namespace ShapesAndColors
{
    public abstract class Shape
    {
        protected Color _color;         //It's an enum
        public Color Color { get { return _color; }} //_color property is only accessed by method set_color, that's why there is no set

        public void set_color(Color color){
            _color = color;
        }

        public virtual string GetInfo(){ //An abstract method cannot have body, so I created a virtual method, which "behaves as an abstract method with body".
            string s;
            s = "Shape of color ";
            s += Color.ToString();
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
