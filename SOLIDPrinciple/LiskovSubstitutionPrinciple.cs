using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SOLIDPrinciple
{
    /*
    What is LSP?
    You might be wondering why we are defining it prior to examples and problem discussions.Simply put, 
    I thought it will be more sensible here.

    It says, "Subclasses should be substitutable for base classes." Don’t you think this statement is strange? 
    If we can always write BaseClass b = new DerivedClass() then why would such a principle be made?

        Real World Comparison
	A father is a real estate business man whereas his son wants to be cricketer.
    A son can’t replace his father in spite of the fact that they belong to same family hierarchy. 


        public class Rectangle
        {
            public int Width { get; set; }
            public int Height { get; set; }
        }

        public class Square:Rectangle
        {
            //codes specific to
            //square will be added
        }
        One can say,

        
        Rectangle o = new Rectangle();
        o.Width = 5;
        o.Height = 6;
        Perfect but as per LSP we should be able to replace Rectangle with square. Let’s try to do so.

        
        Rectangle o = new Square();
        o.Width = 5;
        o.Height = 6;
        What is the matter? Square cannot have different width and height.

        What it means? It means we can’t replace base with derived. Means we are violating LSP.

        Why don’t we make width and height virtual in Rectangle, and override them in Square?

    */
    class LiskovSubstitutionPrinciple
    {
        public LiskovSubstitutionPrinciple()
        {
            Shape _oShape = new Rectangle();
            _oShape.Width = 5;
            _oShape.Height = 6;

            Shape o1 = new Square();
            o1.Width = 5; //both height and width become 5
            o1.Height = 6; //both height and width become 6
        }
    }

    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public abstract class Shape
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
    }

    public class Square : Shape
    {
        public override int Width
        {
            get => base.Width;
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
        public override int Height
        {
            get => base.Height;
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
    }
}
