namespace Ass05oop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Implementing project two.......
            /*  int a = 10;
               int b = 5;

               Console.WriteLine($"Add: {Maths.Add(a, b)}");
               Console.WriteLine($"Subtract: {Maths.Subtract(a, b)}");
               Console.WriteLine($"Multiply: {Maths.Multiply(a, b)}");
               Console.WriteLine($"Divide: {Maths.Divide(a, b)}");*/

            //Implementing proj three
            Duration duration1 = new Duration(1, 30, 45);
            duration1.Display(); 
            duration1.AddSeconds(30); 
            duration1.Display();


            Duration D1 = new Duration(1, 10, 15);
            Duration D2 = new Duration(2, 20, 30);

            Duration D3;

            D3 = D1 + D2;
            Console.WriteLine(D3);  

            D3 = D1 + 7800;
            Console.WriteLine(D3);  

            D3 = 666 + D3;
            Console.WriteLine(D3);  

            D3 = ++D1;
            Console.WriteLine(D3);


            D3 = --D2;
            Console.WriteLine(D3);  // Output: Hours: 2, Minutes: 19, Seconds: 30

            D1 = D1 - D2;
            Console.WriteLine(D1);  // Output: Hours: -1, Minutes: -8, Seconds: -15

            if (D1 > D2)
            {
                Console.WriteLine("D1 is greater than D2");
            }
            else
            {
                Console.WriteLine("D1 is not greater than D2");
            }

            if (D1 <= D2)
            {
                Console.WriteLine("D1 is less than or equal to D2");
            }
            else
            {
                Console.WriteLine("D1 is not less than or equal to D2");
            }

            if (D1)
            {
                Console.WriteLine("D1 is non-zero");
            }
            else
            {
                Console.WriteLine("D1 is zero");
            }

            DateTime dateTimeObj = (DateTime)D1;
            Console.WriteLine(dateTimeObj); 




        }
    }
}
