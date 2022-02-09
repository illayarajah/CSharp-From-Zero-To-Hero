using System;
using System.IO;
using System.Text.RegularExpressions;


namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print each of the statistical output using Text Table with padding 3:
            // - FindHighestBalanceEver
            // - FindPersonWithBiggestLoss
            // - FindRichestPerson
            // - FindMostPoorPerson


            //string cleanFile = @"Input\raja2.txt";
            //Console.WriteLine("this is a test");
            //FileCleaner.Clean(dirtyFile, cleanFile);
            FileCleaner test = new FileCleaner(@"Input\Balances.corrupted", @"Input\raja3.txt");
            test.Clean();
            //This is a test comment for git test. 





            //Console.WriteLine(TextTable.Build(BalanceStats.FindHighestBalanceEver(FileCleaner.CleanFile(cleanFile)), 3));
            //Console.WriteLine(TextTable.Build(BalanceStats.FindPersonWithBiggestLoss(PeoplesBalances.Balances), 3));
            //Console.WriteLine(TextTable.Build(BalanceStats.FindRichestPerson(PeoplesBalances.Balances), 3));
            //Console.WriteLine(TextTable.Build(BalanceStats.FindMostPoorPerson(PeoplesBalances.Balances), 3));

        }
    }
}
