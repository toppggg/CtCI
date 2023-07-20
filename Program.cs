using System;
namespace CtCI;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(Is_unique.Method1("Anemort"));
        System.Console.WriteLine(Is_unique.Method2("Anemort"));

        System.Console.WriteLine(Check_permutations.Method1("permutation","tationmuper"));

        System.Console.WriteLine("1.3 "+ URLify.Method1("This is a string      "));

        System.Console.WriteLine("1.4" + Palin_Permu.Method1("Tact Coa"));
        
        System.Console.WriteLine("1.5 " + One_away.Method1("cakes","cake"));

        System.Console.WriteLine("1.6" + String_compression.Method1("aaabbccc"));


        System.Console.WriteLine("1.7" + Rotate_matrix.Method1(new int[,] {{1,2,3,4},{5,6,7,8},{9,10,11,12},{13,14,15,16}}));

        System.Console.WriteLine("1.8" + Zero_matrix.Method1(new int[,] {{1,2,3,4},{5,0,7,8},{9,10,0,12}}));
    
        System.Console.WriteLine("1.9" + String_rotation.Method1("waterbottle","terbottlewa"));

        //2.1
        Remove_dubs.Test();
        //2.2
        KthedLast.Test();
        //2.3
        DeleteSingleLinkedNode.Test();
        //2.4
        Partition.Test();
        //2.5
        SumLists.Test();
        //2.6
        ListPalindrome.Test();
        //2.7
        ListIntersection.Test();
        //2.8
        LoopDetection.Test();
    }
}