using System;
using System.Collections.Generic;
using System.Text;

namespace NestedStaticAndNonsStaticClasses
{
    //Outer class
    public class Outer_Class
    {
        public static string str = "Geeksforgeeks";
        private string webAddress = "www.geeksforgeeks.org";

        // Method of outer class 
        public void OuterMethod()
        {
            Console.WriteLine("Outer class method");
        }

        public static void StaticOuterMethod()
        {
            Console.WriteLine("Outer class static method");
        }

        // Another method of outer class
        //You are allowed to create objects of inner class in outer class
        public void InnerClassObject()
        {
            Inner_Class ic = new Inner_Class();
        }

        // Inner class 
        //By default the nested class is private
        public class Inner_Class
        {

            // Method of inner class 
            public void InnerMethod()
            {
                Console.WriteLine("Inner class Method");
            }

            //You are also allowed to create objects of outer class in inner class
            public void InnerClassObject()
            {
                Outer_Class oc = new Outer_Class();

                //Inner class can access both static and non-static members of oter class 
                Console.WriteLine(Outer_Class.str);
                Console.WriteLine(oc.webAddress);
            }
        }

        public static class StaticInnerClass
            {
            // Method of inner class 
            //Unlike in Java, you can't have non-static methods inside a static class (outer or inner)
            /*public void InnerMethod()
            {
                Console.WriteLine("Inner class Method");
            }*/

            public static void StaticInnerMethod()
            {
                Console.WriteLine("Static inner class Method");
            }

            //You are also allowed to create objects of outer class in inner class
            public static void StaticInnerClassObject()
            {
                Outer_Class oc = new Outer_Class();

                //Inner class can access both static and non-static members of oter class 
                Console.Write("StaticInnerClassObject: ");
                Console.Write(Outer_Class.str);
                Console.Write(", ");
                Console.WriteLine(oc.webAddress);
            }

        }
    }
}
