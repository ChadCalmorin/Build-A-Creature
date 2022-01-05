using System;

namespace Build_A_Creature
{
    class Program
    {
        static void Main(string[] args)
        {

            BuildACreature("ghost", "ghost", "bug");

        }

        static void BuildACreature(string head, string body, string feet)
        {
            int headNum = TranslateToNumber(head);
            int bodyNum = TranslateToNumber(body);
            int feetNum = TranslateToNumber(feet);

            SwitchCase(headNum, bodyNum, feetNum);




        }

        static void RandomMode()
        {
            Random random = new Random();
            int head = random.Next(1, 4);
            int body = random.Next(1, 4);
            int feet = random.Next(1, 4);


            SwitchCase(head, body, feet);


        }

        static void SwitchCase(int head, int body, int feet)
        {
            switch (head)

            {
                case 1:
                    GhostHead();
                    break;

                case 2:
                    BugHead();
                    break;

                case 3:
                    MonsterHead();
                    break;

            }

            switch (body)

            {
                case 1:
                    GhostBody();
                    break;

                case 2:
                    BugBody();
                    break;

                case 3:
                    MonsterBody();
                    break;

            }

            switch (feet)

            {
                case 1:
                    GhostFeet();
                    break;

                case 2:
                    BugFeet();
                    break;

                case 3:
                    MonsterFeet();
                    break;

            }

        }

        static int TranslateToNumber(string creatureConvert)
        {
            switch (creatureConvert)
            {
                case "ghost":
                    return 1;    //don't need to use the break keyword because when we return a value it will automatically break us out of the code block

                case "bug":
                    return 2;

                case "monster":
                    return 3;

                default:
                    return 1; //must return an int, look at method signuatre
            }

            

        }

        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}
