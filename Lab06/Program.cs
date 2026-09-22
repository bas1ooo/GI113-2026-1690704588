using System.Net.Security;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             int lives = 5;

            // เรียก if เพื่อ เช็ค เงื่อนไข
            if (lives <= 0)  //ในวงเล็บคือเงื่อนไขที่เป็น bool
            {
                //ในปีกกาเป็นโค๊ดการทำงาน จะรันได้ true
                Console.WriteLine("Game Over");
            }
            else
            {
                Console.WriteLine("Game is Playing");
            }

            //โค๊ดบรรทัดต่อไป
            //Console.WriteLine("Continue Code");

            //int level = 10;
            bool hasKey = true;
            Console.WriteLine("Your level (1-99): ");
            bool inputValid = int.TryParse(Console.ReadLine(), out int level);

            if (!inputValid || level < 1 || level > 99) //เงื่อนไขที่ถือว่า eror จาก input
            {
                Console.WriteLine("Invalid level.");
            }

            else if (level >= 10 && hasKey) //เมื่อมีเงื่อไขเป็นจำนวน ให้เรียงจำนวน มาก -> น้อย เสมอ
            {
                Console.WriteLine("Boss floor unlocked.");
            }
            else if (level >= 5)
            {
                if (hasKey)
                {
                    Console.WriteLine("The door opens.");
                }
                else
                {
                    Console.WriteLine("Locked. Find a key");
                }
            }
            else
            {
                Console.WriteLine("The door stays shut.");
            }

            bool isPoisioned = true;

            //เรียกชื่อ bool เฉยๆ คือเช็คว่าเป็นจริงมั้ย
            if (isPoisioned == true)
            {
                Console.WriteLine("You died!");

            }
            else if (isPoisioned == false) // ! คือตรงข้าม true -> false, false -> true
            {
                Console.WriteLine("You Lives");
            } 
            */

            int swordDmg = 80;
            int bowDmg = 40;
            int zombieHp = 70;
            int heroHp = 60;
            int potionHeal = 30;

            Console.WriteLine("GAME TITLE: ZOMBIE SURVIVAL");
            Console.WriteLine();

            Console.WriteLine("ACTION 1: ATTACK WITH SWORD");
            Console.WriteLine("ACTION 2: SHOOT WITH BOW");
            Console.WriteLine("ACTION 3: DRINK POTION");

            Console.WriteLine();
            Console.Write("CHOOSE YOUR NEXT MOVE (1-3): ");

            bool inputValid = int.TryParse(Console.ReadLine(), out int choice);

            if (!inputValid || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid input, please choose between 1-3 only!");
            }
            else if (choice == 1)
            {
                zombieHp -= swordDmg;

                if (zombieHp <= 0)
                {
                    Console.WriteLine($"Zombie took {swordDmg} DMG. Zombie defeated!");
                }
                else
                {
                    Console.WriteLine($"Zombie took {swordDmg} DMG. Zombie has {zombieHp} HP left.");
                }
            }
            else if (choice == 2)
            {
                zombieHp -= bowDmg;

                if (zombieHp <= 0)
                {
                    Console.WriteLine($"Zombie took {bowDmg} DMG. Zombie defeated!");
                }
                else
                {
                    Console.WriteLine($"Zombie took {bowDmg} DMG. Zombie has {zombieHp} HP left.");
                }
            }
            else
            {
                heroHp += potionHeal;

                Console.WriteLine($"You drink a potion and heal {potionHeal} HP. Hero HP is now {heroHp}.");
            }
        }
    }
}
