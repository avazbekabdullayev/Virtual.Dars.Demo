namespace Virtual.Dars.Demo.Calc2
{
    public class Calculator
    {
        public void Start()
        {

            while (true)
            {
                Console.WriteLine("Calculator dasturi");

                double firstNumber = ParseNumber();
                string operation = ValidateOperation();
                double secondNumber = ParseNumber();

                /*double result = 0;
                switch (operation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;

                    case "-":
                        result = firstNumber - secondNumber;
                        break;

                    case "*":
                        result = firstNumber * secondNumber;
                        break;

                    case "/":
                        result = firstNumber / secondNumber;
                        break;

                    default:
                        Console.WriteLine("Mavjud bo'lmagan amal");
                        return;
                        break;
                }
                */

                double result = Calculate(firstNumber, operation, secondNumber);
                Console.WriteLine($"firstNumber={firstNumber}");
                Console.WriteLine(result);
            }

        }
       private double Calculate( double firstNumber, string operation, double secondNumber)
        {
           var result = operation switch
            {
                "+" => firstNumber + secondNumber,
                "-" => firstNumber - secondNumber,
                "*" => firstNumber * secondNumber,
                "/" => firstNumber / secondNumber,
                "^" => Math.Pow(firstNumber, secondNumber),
                "#" => Math.Sqrt(firstNumber)
            };
            Console.WriteLine($"Natija: {firstNumber} {operation} {secondNumber} = {result}");
            Console.WriteLine($"firstNumber={firstNumber}");
            return result;
        }

       private double ParseNumber()
        {
            bool parsingResult = false;
            double result = 0;
            while (!parsingResult)
            {
                Console.WriteLine("son kiriting");
                string firstNumberString = Console.ReadLine();
                parsingResult = double.TryParse(firstNumberString, out result);

            }
            return result;
        }

         private string ValidateOperation()
        {
            string operation = string.Empty;

            while (operation != "+" && operation != "-" && operation != "*" && operation != "/"  && operation !="#"  && operation != "^")
            {
                Console.WriteLine("Amalni kiriting: (+ - / * ^ #):");
                operation = Console.ReadLine();
            }

            return operation;
        }

    }
}
