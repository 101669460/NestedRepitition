using System;

namespace NestedRepitition
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            
            //1. create string "name"
            //2. set string to user input
            //3. create integer "counter"
            //4. set counter = 0
            //5. create integer "counter2"
            //6. set counter2 = 0
            //7. create integer "max1"
            //8. set max1 = user input
            //9. create integer "max2"
            //10. set max2 = user input
            //11. while counter < max1
                	//11.1 counter = counter + 1
                    //11.2 set counter 2 = 0
                    //11.3 while counter2 < max2
                        //11.3.1 counter2 = counter2 + 1
                        //11.3.2 print "name"
                    //11.4 print new line
            //12. print goodbye
            //13. end script

            //Advanced Exercise
            int counter = 0;
            int counter2 = 0;
            int counter3 = 0;
            int max1 = Convert.ToInt32(Console.ReadLine());
            int max2 = 1;
            int max3 = max1 - 1;
            while (counter < max1){
                counter++;
                counter2 = 0;
                while (counter2 < max2)
                {
                    
                    while (counter3 < max3){
                        counter3++;
                        System.Console.Write(" ");
                    }
                    counter2++;
                    System.Console.Write("x");
                }
                System.Console.WriteLine();
                max2++;
                max2++;
                max3--;
                counter3 = 0;
             }
        }
    }
}
