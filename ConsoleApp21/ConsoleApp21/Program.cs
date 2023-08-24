using System;

namespace ConsoleApp21
{
    internal class Program
    {
        public string Solution(int num)
        {
            if (num % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }

        private static string solution(int num)
        {
            string answer = "";
            return answer;
        }

        static void Main(string[] args)

        {
            Console.Write("번호를 입력하세요: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("짝수입니다.");
            }
            else
            {
                Console.WriteLine("홀수입니다.");
            }

        }
    }
        
}

    


  
