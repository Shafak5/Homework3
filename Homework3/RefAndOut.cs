using System;

namespace Homework3
{
    class RefAndOut
    {
        static void Main(string[] args)
        {
            int number1 = 5; //ref keywordu kullanırken her ne kadar metoddaki 8 değerini referans alsa da burada number1 ın bir değerinin olması gerekir.
            int number2 = 3; //number2 değeri aşağıda atanmamışken ref buradaki değeri kullanır. Dolayısıyla ref hem burada atanan değeri hem metod içerisindeki değeri kontrol eder.

            var result = Whatsref( ref number1, ref number2); 
            
            Console.WriteLine(result);
            Console.WriteLine("Ref kullanıldığında : " + number1);


            int number3 = 5; //out keywordüyle çalışırken ise number3 değeri aşağıda belirlendiği için burada değer atayıp atamadığımızın önemi yoktur.
            int number4 = 3; //out kullandığımız için buradaki değerlerin hiçbir önemi yoktur. metod içerisinde atanan değerlerdir okunanlar.

            var result2 = Whatsout(out number3, out number4);

            Console.WriteLine(result2);
            Console.WriteLine("Out kullanıldığında : " + number3);
            
        }
        



        static int Whatsref(ref int number1,ref int number2)
        {
            number1 = 8;
            
             return number1 * number2;

        }

        static int Whatsout(out int number3, out int number4)
        {
            number3 = 8;
            number4 = 6;
            return number3 * number4;
        }
    }


}
    
