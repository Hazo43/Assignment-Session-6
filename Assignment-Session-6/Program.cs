using System.Data;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace Assignment_Session_6
{
    internal class Program
    {

        public static void numbers( int  num1 , int num2 , int num3, int num4,  out int sum , out int sub)
        {
            sum = num1 + num2;
            sub = num3 - num4;
        }

        public static void SWAP( /* ref */ int x , /* ref */ int y)
        {
            int temp = x;    // => (x,y) دي حاجه موقته عشان تحفظ قيمه ال temp ال 
             x = y;          // و انا مش عاوز كدا y هتخزن ال  x كانت ال  temp لو معملناش ال 
            y = temp; 
        }

        public static int SumArray ( /* ref */ int[] arr)   // => passing by value not Reference نلاحظ هن  
        {
            int sum = 0;
            if (arr != null)
            {
                arr = [100 , 200 , 300 , 400 , 500];

                for( int i = 0; i < arr.Length; i++ )
                    sum += arr[i];

            }
            return sum;
        }

        public static bool IsPrime (int number )
        {
            if ( number <= 1  )
                return false;

            if ( number == 2 )
                return false;


            for (int i = 2; i < number; i++ )
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        public static void MinMaxArray (ref int[] array , ref int min , ref int max)
        {
             min = array[0];
             max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
            }
        }

        public static int  Factorial(int number)
        {
            int result = 1;

            for (int i = 1;i <= number;i++)
            {
                result *= i;
            }

            return result;
        }
      

        static void Main(string[] args)
        {
            #region Examples
            // int? x  = null;
            //  x = 10;
            //// if ( x.HasValue)
            //// {
            ////     Console.WriteLine(x.Value);
            //// }
            //// else
            //// {
            ////     throw new Exception(" X is Null");
            //// }

            // string y = x.HasValue ? x.Value.ToString() : " X is Null";
            #endregion

            #region Q1 

            /*
             1- Explain the difference between passing (Value type parameters) 
                by value and by reference then write a suitable c# example.
             */

            #region By Value 

            // int a = 10 , b = 15;

            //Console.WriteLine("================ Before ==============");
            //Console.WriteLine(a);      // 10
            //Console.WriteLine(b);      // 15

            //Console.WriteLine("================ After SWAP ==============");
            //SWAP01(a , b);
            //Console.WriteLine(a);    // 10   =>  copy(a,b) واخد  SWAP هيطبع نفس الحاجه عشان ال 
            //Console.WriteLine(b);    // 15   =>  copy(a,b) واخد  SWAP هيطبع نفس الحاجه عشان ال 

            #endregion


            #region By Reference  


            //int a = 10, b = 15;

            //Console.WriteLine("================ Before ==============");
            //Console.WriteLine(a);      // 10
            //Console.WriteLine(b);      // 15

            //Console.WriteLine("================ After SWAP ==============");
            //SWAP(ref a, ref  b);
            //Console.WriteLine(a);    // 15  =>   ref عادي عشان انا بعتلو  SWAP هنا هيعمل 
            //Console.WriteLine(b);    // 10   =>   ref عادي عشان انا بعتلو  SWAP هنا هيعمل 
            #endregion

            #endregion

            #region Q2 

            /*
             2- Explain the difference between passing (Reference type 
              parameters) by value and by reference then write a suitable c# example. 
             */


            #region By Value 

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //Console.WriteLine(" ------------ Before -------------");
            //Console.WriteLine($" Code -> {numbers.GetHashCode()}"); // passing by value نفس الكود اللي تحت مفيش فرق لان دا
            //int result = SumArray( numbers );
            //Console.WriteLine(" ------------ After -------------");
            //Console.WriteLine($" Code -> {numbers.GetHashCode()}");    //   passing by value نفس الكود اللي فوق  مفيش فرق لان دا 
            //Console.WriteLine($" Result :{ result}");              // 150  


            #endregion

            #region By Reference 

            //int[] numbers = [ 10, 20, 30, 40, 50 ];                     // فوق arr كانها ملهاش لزمه عشان انا معرف 
            //Console.WriteLine(" ------------ Before -------------"); 
            //Console.WriteLine($" Code -> {numbers.GetHashCode()}");     //  ref الكود هيبقي مختلق لان دي      
            //int result = SumArray( /* ref */ numbers);
            //Console.WriteLine(" ------------ After -------------");
            //Console.WriteLine($" Code -> {numbers.GetHashCode()}");     //  ref الكود هيبقي مختلق لان دي
            //Console.WriteLine($" Result :{result}");                    //    1500           
            //Console.WriteLine($" Numbers[0] => {numbers[0]}");          // 100

            #endregion

            #endregion

            #region Q3 

            /*
               3- Write a c# Function that accept 4 parameters from user and 
                  return result of summation and subtracting of two numbers
            */

            //Console.WriteLine(" Enter the Number 1 ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine(" Enter the Number 2 ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine(" Enter the Number 3 ");
            //int num3 = int.Parse(Console.ReadLine());

            //Console.WriteLine(" Enter the Number 4 ");
            //int num4 = int.Parse(Console.ReadLine());

            //numbers(num1, num2, num3, num4, out int sum, out int sub);

            //Console.WriteLine($" Summation {sum}");
            //Console.WriteLine($" Substracting {sub}");


            /* الكود بطريقه تانيه */

            //Console.WriteLine(" Please Enter Parameter 1 ");
            //int.TryParse(Console.ReadLine(), out int Parameter1);

            //Console.WriteLine(" Please Enter Parameter 2 ");
            //int.TryParse(Console.ReadLine(), out int Parameter2);


            //Console.WriteLine(" Please Enter Parameter 3 ");
            //int.TryParse(Console.ReadLine(), out int Parameter3);

            //Console.WriteLine(" Please Enter Parameter 4 ");
            //int.TryParse(Console.ReadLine(), out int Parameter4);

            //// جمع
            //int summation = Parameter1 + Parameter2;

            //Console.Clear();
            //Console.WriteLine($" Summation is => {summation} \n");

            //// طرح
            //int subtracting = Parameter3 - Parameter4;


            //Console.WriteLine($" Subtracting is => {subtracting}");





            #endregion

            #region Q4 

            /*
              4- Write a program in C# Sharp to create a function to calculate the sum of the 
                individual digits of a given number. 
                Output should be like  
                Enter a number: 25                                                                                             
                The sum of the digits of the number 25 is: 7
             */

            #endregion



            #region Q5 


            /*
             5- Create a function named "IsPrime", which receives an integer number 
                 and retuns true if it is prime, or false if it is not:
             */

            //Console.WriteLine(" Enter Your Number Integer :");
            //int value = int.Parse( Console.ReadLine() );

            //if (IsPrime(value))
            //    Console.WriteLine($"  Is prime {value}");
            //else
            //    Console.WriteLine($"  Is not a prime {value}");


            #endregion

            #region Q6

            /*
             6- Create a function named MinMaxArray, to return the minimum and 
                maximum values stored in an array, using reference parameters
             */

            //int[] numbers = { 10, 20, 80, 85, 5 };
            //int min = 0;
            //int max = 0;

            //MinMaxArray (ref numbers, ref min, ref max);

            //Console.WriteLine($" Max -> {max}");
            //Console.WriteLine($" Min -> {min}");

            #endregion

            #region Q7 
            /*
             7- Create function to calculate the factorial of the number specified as parameter 
             */

            //Console.WriteLine("Enter a number: ");
            //int input = int.Parse(Console.ReadLine());

            //int factorial  = Factorial(input);

            //Console.WriteLine($"Factorial of {input} is: {factorial}");

            #endregion


            #region Q8 

            /*
             8- Create a function named "ChangeChar" to modify a letter in a certain 
                position (0 based) of a string, replacing it with a different letter 
             */


            /// ????????????????????????? ///
            /// ????????????????????????? ///
           

            #endregion

        }
    }
}
