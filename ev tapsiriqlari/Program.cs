namespace ev_tapsiriqlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Calculator);

            //Addprefix(500);
            Solution(19);
        }
        //#region ededin qarsina 3 elave eletdirmek
        ////static void Addprefix(int number)
        //{
        //    //int sabit = number;
        //    //int flor = 3;
        //    //while (number>0)
        //    //{
        //    //    number /= 10;
        //    //    flor *= 10;
        //    //}

        //    //int result = sabit + flor;
        //    //Console.WriteLine(result);
        //    //#endregion
        //}

        //static double Calculator()
        //{
        //    Console.WriteLine("please choose first number");
        //    double number = Double.Parse(Console.ReadLine());
        //    Console.WriteLine("please choose second number");
        //    double number2 = Double.Parse(Console.ReadLine());
        //    Console.WriteLine("please choose valid operation(+ - / *)");
        //    Char op = char.Parse(Console.ReadLine());

        //    double result = 0;
        //    switch (op)
        //    {
        //        case '+':
        //            result += number + number2;
        //            Console.WriteLine(number + '+' + number2 + '=' + result);
        //            break;

        //        case '-':
        //            result += number - number2;
        //            Console.WriteLine(number + '-' + number2 + '=' + result);
        //            break;
        //        case '/':
        //            result += number / number2;
        //            Console.WriteLine(number + '/' + number2 + '=' + result);
        //            break;
        //        case '*':
        //            result += number * number2;
        //            Console.WriteLine(number + '*' + number2 + '=' + result);
        //            break;

        //            return result;
        //    }

        //}

        #region 7 -ye bolunen .

        static void Solution(int number)
        {
           
            if (number%7==0)
            {
             Console.WriteLine("eded 7 ye bolunur");
            }
            if (number%7==1)
            {
                number--;
                Console.WriteLine(number);
            }
            if (number%7==2)
            {    number=number-2;
                Console.WriteLine(number);
            }
            if (number%7==3)
            {    number=number-3;
                Console.WriteLine(number);
            }
            if (number%7==4)
            {
                number = number + 3;
                Console.WriteLine(number);
            }
            if (number%7==5)
            {
                number = number + 2;
                Console.WriteLine(number);
            }
            if (number%7==6)
            {
                number = number + 1;
                Console.WriteLine(number);
            }
           
              else
            {
                Console.WriteLine("eded 7 bolunmur");
            }

           
        }  







        #endregion



    }
}
    
            
            

        

           
            




    








