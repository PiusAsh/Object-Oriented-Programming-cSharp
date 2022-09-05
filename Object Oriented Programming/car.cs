using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming
{
   public class car 
    {
       public string color = "red"; //This is a field
        public int maxSpeed = 200;  //This is a field
        public int sem;  //Blank field
        public string model; //this is a blank field
        public string type;
        public int year; 

        public car(string modelName, string typeName, int modelYear)
        {
            // model = "Venza";
            model = modelName;
            type = typeName;
            year = modelYear;
            

        }


        public void full()
        {
            Console.WriteLine("The car is going as fast as it can");
        }
    }


}
