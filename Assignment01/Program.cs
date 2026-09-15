/*
* Student ID :1690704588
* Name       :อานุภาพ อนุรักษ์สยาม
* Section    :129D
* No.        :NA
* Course     : GI113 Computer Programming (GI)
*/
namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "VALORANT";
            var agentName = "Viper";
            var agentGrade = 'S';

            int accountLevel = 42;
            float headshotRate = 34.8f;
            double combatScorePrecise = 287.6;
            bool isAgentUnlocked = true;

            Console.WriteLine("========================================");
            Console.WriteLine($"          {GameTitle} AGENT CARD");
            Console.WriteLine("========================================");
            Console.WriteLine($" Agent Name      : {agentName}");
            Console.WriteLine($" Agent Grade     : {agentGrade}");
            Console.WriteLine($" Account Level   : {accountLevel}");
            Console.WriteLine($" Headshot Rate   : {headshotRate}%");
            Console.WriteLine($" Combat Score    : {combatScorePrecise}");
            Console.WriteLine($" Agent Unlocked  : {isAgentUnlocked}");
            Console.WriteLine("----------------------------------------");

            double levelAsDouble = accountLevel;

            Console.WriteLine($" Level as Double : {levelAsDouble}");

            int scoreByCast = (int)combatScorePrecise;
            int scoreByConvert = Convert.ToInt32(combatScorePrecise);

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("           SCORE CONVERSION");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($" Original Score  : {combatScorePrecise}");
            Console.WriteLine($" Explicit Cast   : {scoreByCast}");
            Console.WriteLine($" Convert.ToInt32 : {scoreByConvert}");
            Console.WriteLine("========================================");
        }
    }
}
