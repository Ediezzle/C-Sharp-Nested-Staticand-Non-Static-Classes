using System;
using System.Collections.Generic;
using System.Text;

namespace NestedStaticAndNonsStaticClasses
{
    // A user is allowed to inherit a class (including nested class) into another class
    //However static classes are sealed in C#, you can't inherit from them!
    public class Exclass : Outer_Class.Inner_Class
    {
        // Method of derived class 
        public void func()
        {
            Console.WriteLine("Method of derived class");
        }
    }
}
