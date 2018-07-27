using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGeneration
{
    class OOPs
    {
        public OOPs()
        {
            Pet pet=new Cat();
            Shape shape=new Ball();
            //Ball shape = new Ball();
            Console.WriteLine($"My {pet.GetName()} is playing with a {shape.GetName()}");
            Console.ReadLine();//my cat is plying with a ball
        }
    }

    public class Shape
    {
        public  string GetName()
        {
            return "shape";
        }
    }


    public class Ball : Shape
    {
        public  string GetName()
        {
            return "ball";
        }
    }

    public class Pet
    {
        public virtual string GetName()
        {
            return "pet";
        }
    }

    public class Cat : Pet
    {
        public override string GetName()
        {
            return "cat";
        }

    }
}
