using System;

namespace NestedStaticAndNonsStaticClasses
{
    //Driver class
    class Program
    {
        // Main method 
        static public void Main()
        {

            // Create the instance of outer class 
            Outer_Class obj1 = new Outer_Class();
            obj1.OuterMethod();

            // This statement gives an error because 
            // you are not allowed to access inner  
            // class methods with outer class objects 
            // obj1. InnerMethod(); 

            // Creating an instance of inner class 
            Outer_Class.Inner_Class obj2 = new Outer_Class.Inner_Class();

            // Accessing the method of inner class 
            obj2.InnerMethod();
            obj2.InnerClassObject();

            // Creating object of  
            // the derived class 
            Exclass obj = new Exclass();
            obj.func();
            obj.InnerClassObject();

            //accessing a static method inside a static inner class nested in a non-static outer class
            //Remember C# doesn't allow non-static methods inside a static class, whether inner or outer
            Outer_Class.StaticInnerClass.StaticInnerClassObject();
        }
    }
}
