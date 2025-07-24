using System.Data;
using System.Formats.Tar;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using static System.Collections.Specialized.BitVector32;

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

        public static int TakeNumFromUser()
        {
            int Number;
            bool flag;
            do
            {
                Console.WriteLine(" Please Enter Number  ");
                flag = int.TryParse(Console.ReadLine(), out Number);
                if (flag == false)
                {
                    Console.WriteLine(" Error , Please Enter Numbery Again ");
                }
            } while (flag == false);
            return Number;
            
        }

        public static int FullArrayFromUser(int number)
        {
            bool flag;
            int[] numbers = new int[number];

            for (int i = 0; i < numbers.Length; i++)
            {
                do
                {
                    Console.WriteLine($" Enter Element {i + 1} Of Array");
                    flag = int.TryParse(Console.ReadLine(), out numbers[i]);

                } while (flag == false);
            }
            return number;
        }



        // 3

        public static void SumAndSubstraction ( double X,double Y ,out double sumtion,out double abstraction)
        {
            sumtion = X + Y;
            abstraction = X * Y;
        }



        

        // Ex 4 

        public static int SumOfDigit(int number)
        {
            int Sum = 0;
            int result = 0;
            while ( number != 0 )
            {             
                result = number % 10;   // بتحصل ع اخر رقم 
                Sum += result;          // بتخزن كل مرا 
                number /= 10;          // بتحذف اخر رقم
            }
            return Sum;
        }

        // Ex 5

        public static bool IsPrime(int number)
        {
            if (number < 2 )
                return false;

            for (int i = 2;i < number;i++)
            {
                if ( number % i == 0 )
                {
                    return false;
                }
            }
            return true;
        }

        // 6 

        public static void MaxAndMinArray(int[] arr )
        {
          int  max = arr[0];
          int   min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                 if (arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine($" Max -> {max}  Min {min}");
        }

        // 7 

        // for
        public static long Factorial (int Number)
        {
            int result = 1;
            for (int i = 1;i <= Number;i++)
            {
                result *= i;
            }
            return result;
        }

        // While

        public static long Factorial02(int Number)
        {
            int result = 1;
            while (Number > 1)
            {
                result *= Number;
                Number--;
            }
            return result;
        }

        // 8 

        public static void ReplacedLetter(string word, char letter, int index)
        {
            if (index <= 0 && index < word.Length)
            {
                StringBuilder sp = new StringBuilder(word);
                sp[index] = letter;
                word = sp.ToString();
            }
            Console.WriteLine($" After Replaced --> {word} ");

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




            //double A, B, sumtion, abstraction;
            //B = 15;
            //A = 20;

            //SumAndSubstraction(A, B, out sumtion, out abstraction);

            //Console.WriteLine(sumtion);
            //Console.WriteLine(abstraction);

            #endregion

            #region Q4 

            /*
              4- Write a program in C# Sharp to create a function to calculate the sum of the 
                individual digits of a given number. 
                Output should be like  
                Enter a number: 25                                                                                             
                The sum of the digits of the number 25 is: 7
             */


            // ------------- Solution Very Good --------------

            //int Number = TakeNumFromUser();
            //Console.WriteLine(SumOfDigit(Number));



            // ----------------------------------------------------
            // Solution Another

            //int Result , input;
            //bool flag;

            //do
            //{
            //    Console.WriteLine(" Please Enter Number ");
            //   flag = int.TryParse(Console.ReadLine(), out input);
            //    if (flag == false)
            //    {
            //        Console.WriteLine(" Error , Please Enter Number Again");
            //    }
            //}  
            //while (flag == false);


            //Result = SumOfDigit(input);
            //Console.WriteLine(" Result => " + Result);

            #endregion



            #region Q5 


            /*
             5- Create a function named "IsPrime", which receives an integer number 
                 and retuns true if it is prime, or false if it is not:
             */

            // ------------- Solution Very Good --------------


            //int Number = TakeNumFromUser();
            //Console.WriteLine(IsPrime(Number));


            // ----------------------------------------------



            //int  input;
            //bool flag;

            //do
            //{
            //    Console.WriteLine(" Please Enter Number ");
            //    flag = int.TryParse(Console.ReadLine(), out input);
            //    if (flag == false)
            //    {
            //        Console.WriteLine(" Error , Please Enter Number Again");
            //    }
            //}
            //while (flag == false);

            //if (IsPrime(input) == false)
            //{
            //    Console.WriteLine($" Number -> {input} Is Not Prime");
            //}
            //else
            //{
            //    Console.WriteLine($" Number -> {input} Is  Prime");

            //}

            #endregion

            #region Q6

            /*
             6- Create a function named MinMaxArray, to return the minimum and 
                maximum values stored in an array, using reference parameters
             */





            // ***************************************************


            //int Size;
            //bool flag;

            //do
            //{
            //    Console.WriteLine(" Please Enter Number ");
            //    flag = int.TryParse(Console.ReadLine(), out Size);
            //    if (flag == false)
            //    {
            //        Console.WriteLine(" Error , Please Enter Number Again");
            //    }
            //}
            //while (flag == false || Size < 1);

            //int[] numbers = new int [Size];

            //for (int i = 0;i < numbers.Length ;i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($" Enter Element { i + 1 } Of Array");
            //        flag = int.TryParse(Console.ReadLine(),out numbers[i]);

            //    } while (flag == false);
            //}


            //int min =0;
            //int max =0;

            //MaxAndMinArray(ref numbers , ref max , ref min);

            //Console.WriteLine($" Max -> {max}");
            //Console.WriteLine($" Min -> {min}");

            #endregion

            #region Q7 
            /*
             7- Create function to calculate the factorial of the number specified as parameter 
             */


            //  --------------------- for ----------------

            //long Number = TakeNumFromUser();
            //Console.WriteLine(Factorial(Number));

            // ----------------- While ----------------

            //long Number = TakeNumFromUser();
            //Console.WriteLine(Factorial02(Number));



            ////// --------------------------------------------------


            //int Number;
            //bool flag;

            //do
            //{
            //    Console.WriteLine(" Please Enter Number ");
            //    flag = int.TryParse(Console.ReadLine(), out Number);
            //    if (flag == false)
            //    {
            //        Console.WriteLine(" Error , Please Enter Number Again");
            //    }
            //}
            //while (flag == false || Number < 1);

            //int Sum = Factorial(Number);
            //Console.WriteLine(Sum);

            #endregion


            #region Q8 

            /*
             8- Create a function named "ChangeChar" to modify a letter in a certain 
                position (0 based) of a string, replacing it with a different letter 
             */

            ReplacedLetter("Hazo", 'A', 0);



            #endregion

        }
    }
}
