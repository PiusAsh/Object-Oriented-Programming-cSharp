using System;

namespace Object_Oriented_Programming
{
    class Program 
    {
        

        static void Main(string[] args)
        {
            car myObject = new car("Venza", "Testing", 4004);

           
            myObject.color = "blue";  //This is setting
            myObject.sem = 300;
            car modelName = new car("Venza", "Testing", 4000);
            Console.WriteLine(myObject.color);
          myObject.full();
            Console.WriteLine(modelName.model);
            Console.WriteLine(myObject.model);
            Console.WriteLine($"{modelName.type}, { modelName.type}, { modelName.color},{ modelName.sem}");
            Console.WriteLine(modelName.type);
            Console.WriteLine(modelName.color);
        }
    }
}
