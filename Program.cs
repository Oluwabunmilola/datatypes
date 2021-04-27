using System;

namespace DATATYPES
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
//            Write a C# Sharp program that takes three letters as input and 
            // display them in reverse order. 

// Enter letter: b
// Enter letter: a
// Enter letter: t
// Expected Output :
// t a b
           // Console.WriteLine("enter first letter");
        //    var firstLetter=Console.ReadLine();

    //        Console.WriteLine("enter second letter");
  //          var secondLetter=Console.ReadLine(); 
//
  //          Console.WriteLine("enter third letter");
    //        var thirdLetter=Console.ReadLine();

//            Console.WriteLine(thirdLetter+secondLetter+firstLetter);
            


 // Write a C# Sharp program that takes Name and password as input
           //shows welcome if both is correct and shows please login when any of them is wrong correct          
//Converting to upper cases.    
    //  Console.WriteLine("Please enter name");
    //  string yourName = Console.ReadLine();
    //  string nameToUpper = yourName.ToUpper();

    //  Console.WriteLine("Please enter password");
    //  string yourPassword = Console.ReadLine();


    //  if (nameToUpper == "PRECIOUS" && yourPassword == "precious1234")
    //  {

    //  Console.WriteLine(" Welcome " + nameToUpper + " " + yourPassword);
    //  }

    //  else
    //  {
    //  Console.WriteLine("Wrong name or password");
    //  }


     //Refrence types--They are  nullable
     //strings
     //Value types--They are not nullalbe
    // int,float,double
    

    // int myInt = 10;
    //         string values = "100";

    //         double myDouble = 5.25;
    //         bool myBool = true;

    //         Console.WriteLine(Convert.ToInt32(values));
    //         Console.WriteLine(Convert.ToDouble(myInt));
    //         Console.WriteLine(Convert.ToInt32(myDouble));
    //         Console.WriteLine(Convert.ToSingle(myBool));
    

                
    //  Console.WriteLine("Please enter name");
    //  string yourName = Console.ReadLine();

    //  Console.WriteLine("Please enter password");
    //  string yourPassword = Console.ReadLine();

    //  if (yourName == "Precious" && yourPassword == "precious1234")
    //  {

    //  Console.WriteLine(" Welcome " + yourName + " " + yourPassword);
    //  }

    //  else
    //  {
    //  Console.WriteLine("Wrong name or password");
    //  }


  //To clear empty spaces  
// string values="t g";
// string newValues=values.Replace(" ","");
// Console.WriteLine(newValues);    

//   Using the  string.IsNullOrEmpty();

            Console.WriteLine("Enter Something");
            string val=Console.ReadLine();
            if(string.IsNullOrEmpty(val))
           {
               
             Console.WriteLine("Enter Something becuase its empty");
           }
           else{
               Console.WriteLine("Hello");
           }


    
    
    
    
        }
    }
}
