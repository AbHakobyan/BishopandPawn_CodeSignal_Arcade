using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BishopandPawn_CodeSignal_Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bishop = "a1";
            string pawn = "h5";
            bool x = bishopAndPawn(bishop, pawn);
            Console.WriteLine(x);
        }

        static bool bishopAndPawn(string bishop, string pawn)
        {
            for (int i = 1; i < 8; i++)
                if (bishop[0] + i == pawn[0] && bishop[1] + i == pawn[1])
                    return true;
                else if (bishop[0] - i == pawn[0] && bishop[1] - i == pawn[1])
                    return true;
                else if (bishop[0] + i == pawn[0] && bishop[1] - i == pawn[1])
                    return true;
                else if (bishop[0] - i == pawn[0] && bishop[1] + i == pawn[1])
                    return true;
            return false;
        }
    }
}
