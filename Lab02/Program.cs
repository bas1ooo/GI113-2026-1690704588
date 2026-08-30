/*
 * Student ID :1690704588
 * Name       :Lab02
 * Section    :129D
 * No.        :NA
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==================== PART A ====================

            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");

            Console.WriteLine();

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");

            Console.WriteLine();

            Console.WriteLine($"{bossName} takes 60 damage!");

            currentHp = currentHp - 60;

            Console.WriteLine();

            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");

            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");


            // ==================== PART B ====================

            // Character 1
            string name1 = "Knight";
            int hp1 = 500;
            float attack1 = 75.5f;
            char rank1 = 'A';
            bool isAlive1 = true;

            // Character 2
            string name2 = "Mage";
            int hp2 = 300;
            double mana2 = 250.75;
            char rank2 = 'S';
            bool isAlive2 = true;

            // Character 3
            string name3 = "Archer";
            int hp3 = 350;
            float speed3 = 8.5f;
            double accuracy3 = 95.25;
            bool isAlive3 = true;

            // Character 4
            string name4 = "Dragon";
            int hp4 = 1000;
            float attack4 = 150.5f;
            char rank4 = 'S';
            bool isAlive4 = true;


            Console.WriteLine();

            Console.WriteLine("===== CHARACTER 1 =====");
            Console.WriteLine($"Name: {name1}");
            Console.WriteLine($"HP: {hp1}");
            Console.WriteLine($"Attack: {attack1}");
            Console.WriteLine($"Rank: {rank1}");
            Console.WriteLine($"Alive: {isAlive1}");

            Console.WriteLine();

            Console.WriteLine("===== CHARACTER 2 =====");
            Console.WriteLine($"Name: {name2}");
            Console.WriteLine($"HP: {hp2}");
            Console.WriteLine($"Mana: {mana2}");
            Console.WriteLine($"Rank: {rank2}");
            Console.WriteLine($"Alive: {isAlive2}");

            Console.WriteLine();

            Console.WriteLine("===== CHARACTER 3 =====");
            Console.WriteLine($"Name: {name3}");
            Console.WriteLine($"HP: {hp3}");
            Console.WriteLine($"Speed: {speed3}");
            Console.WriteLine($"Accuracy: {accuracy3}");
            Console.WriteLine($"Alive: {isAlive3}");

            Console.WriteLine();

            Console.WriteLine("===== CHARACTER 4 =====");
            Console.WriteLine($"Name: {name4}");
            Console.WriteLine($"HP: {hp4}");
            Console.WriteLine($"Attack: {attack4}");
            Console.WriteLine($"Rank: {rank4}");
            Console.WriteLine($"Alive: {isAlive4}");
        }
    }
}