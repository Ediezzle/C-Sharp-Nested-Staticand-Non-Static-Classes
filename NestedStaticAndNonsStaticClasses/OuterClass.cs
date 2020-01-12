using System;
using System.Collections.Generic;
using System.Text;

namespace NestedStaticAndNonsStaticClasses
{
    //Outer class
    public static class OuterClass
    {
        public static string str = "Geeksforgeeks";

        //Unlike in Java , a static class cannot have instance members in C#
        //private string webAddress = "www.geeksforgeeks.org";

        // Unlike in Java, you static classes cannot have non-static methods
        /*
         public void OuterMethod()
        {
            Console.WriteLine("Outer class method");
        }
        */

        public static void StaticOuterMethod()
        {
            Console.WriteLine("Outer class static method");
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
            }

        }
    }
}
