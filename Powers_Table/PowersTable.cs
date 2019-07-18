using System;

namespace Powers_Table
{
    class PowersTable
    {
        public readonly int userNumber;

        public PowersTable(int userNumber)
        {
            this.userNumber = userNumber;
        }

        public static void TableMaker(int userNumber)
        {
            //creates a table showing the number from 1 to userNumber
            //as well as the squares and cubes of those numbers
            for (int i = 1; i <= userNumber; i++)
            {
                Console.Write(i + "\t\t");
                Console.Write((i * i) + "\t\t");
                Console.Write((i * i * i) + "\t\t");
                Console.WriteLine("\n");
            } 
        }
    }
}
