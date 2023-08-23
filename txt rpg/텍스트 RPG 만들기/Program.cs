using System;
using System.Numerics;
using 텍스트_RPG_만들기;

namespace CSharp
{
    internal class Program
    {
        private static Character player;

        static void Main(string[] args)
        {
            GameDataSetting();
            DisplayGameIntro();
            DisplayInventory();
            DisplayDungeon();
            DisplayYoudie();


        }

        private static void DisplayYoudie()
        {
            Console.WriteLine("당신들은 몬스터들에게 물려서 죽었습니다");
            Console.WriteLine("You Die");
            Console.WriteLine();
            Console.WriteLine("다시 시작하시겠습니까?");

            Console.WriteLine("1.네");

            int input = CheckValidInput(1, 1);
            switch (input)
            {
                case 1:
                    DisplayGameIntro();
                    break;

                default:
                    Console.WriteLine("잘못된 입력입니다. 다시 시도해주세요.");
                    break;



            }
        }

        private static int CheckValidInput(int min, int max)
        {
            while (true)
            {
                string input = Console.ReadLine();

                bool parseSuccess = int.TryParse(input, out var ret);
                if (parseSuccess)
                {
                    if (ret >= min && ret <= max)
                        return ret;
                }

                Console.WriteLine("잘못된 입력입니다.");
            }
        }

        private static void DisplayDungeon()
        {
            Console.WriteLine("스파르타 던전에 입장했습니다.");
            Console.WriteLine("지금 던전에 입장하겠습니까?");
            Console.WriteLine();
            Console.WriteLine("1. 입장");
            Console.WriteLine("2. 뒤로가기");

            int input = CheckValidInput(1, 2);
            switch (input)
            {
                case 1:
                    DisplayYoudie();
                    break;

                case 2:
                    DisplayGameIntro();
                    break;

                default:
                    Console.WriteLine("잘못된 입력입니다. 다시 시도해주세요.");
                    break;
            }
        }

        

        static void GameDataSetting()
        {
            // 캐릭터 정보 세팅
            player = new Character("Chad", "가지지 못한자", 1, 10, 1, 100, 0);

            // 아이템 정보 세팅
        }

        static void DisplayGameIntro()
        {
            Console.Clear();

            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 전전으로 들어가기 전 활동을 할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("1. 상태보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");

            int input = CheckValidInput(1, 2);
            switch (input)
            {
                case 1:
                    DisplayMyInfo();
                    break;

                case 2:
                    DisplayInventory();
                    break;



                default:
                    Console.WriteLine("잘못된 입력입니다. 다시 시도해주세요.");
                    break;
            }
        }

        static void DisplayMyInfo()
        {
            Console.Clear();

            Console.WriteLine("상태보기");
            Console.WriteLine("캐릭터의 정보르 표시합니다.");
            Console.WriteLine();
            Console.WriteLine($"Lv.{player.Level}");
            Console.WriteLine($"{player.Name}({player.Job})");
            Console.WriteLine($"공격력 :{player.Atk}");
            Console.WriteLine($"방어력 : {player.Def}");
            Console.WriteLine($"체력 : {player.Hp}");
            Console.WriteLine($"Gold : {player.Gold} G");
            Console.WriteLine();
            Console.WriteLine("0. 나가기");

            int input = CheckValidInput(0, 0);
            switch (input)
            {
                case 0:
                    DisplayGameIntro();
                    break;
            }
        }

        static void DisplayInventory()
        {
            Console.Clear();

            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");
            Console.WriteLine("몽둥이");
            Console.WriteLine("아이템이 없습니다");


            Console.WriteLine("0. 인벤토리 관리");
            Console.WriteLine("1. 던전입장");
            Console.WriteLine("원하시는 행동을 입력하세요");

            int input = CheckValidInput(0, 1);
            switch (input)
            {
                case 0:
                    DisplayGameIntro();
                    break;
                case 1:
                    DisplayDungeon();
                    break;

                default:
                    Console.WriteLine("잘못된 입력입니다. 다시 시도해주세요.");
                    break;











            }
        }

        
            
        

        public class Character
        {
            public string Name { get; }
            public string Job { get; }
            public int Level { get; }
            public int Atk { get; }
            public int Def { get; }
            public int Hp { get; }
            public int Gold { get; }

            public Character(string name, string job, int level, int atk, int def, int hp, int gold)
            {
                Name = name;
                Job = job;
                Level = level;
                Atk = atk;
                Def = def;
                Hp = hp;
                Gold = gold;
            }
        }
    }
}
