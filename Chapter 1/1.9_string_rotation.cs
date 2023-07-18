using System;
namespace CtCI;

public static class String_rotation {

    public static bool Method1(string str1, string str2) {
        if (str1.Length != str2.Length) return false; // no need to check then.
        //build hash
        int hash1 = 0;
        int hash2 = 0;
        string str3 = str2 + str2;
        for (int i = 0; i < str2.Length; i++) {
            hash1 += (int) str1[i] * (int) Math.Pow(3 ,i); // cannot use a higher hash base, due to overflow.
            hash2 += (int) str3[i] * (int) Math.Pow(3 ,i);
        }
        //Check if strings match:
        if (hash1==hash2) return true;

        //check subsequent substrings against str1
        for (int i = 1; i < str2.Length; i++) {
            int ingoing = (int)str2[i-1] * (int) Math.Pow(3,str2.Length-1);
            int outgoing = str2[i-1];
            hash2 = (hash2 - outgoing) / 3 + ingoing;
            
            if (hash1==hash2) return true;
        }
        return false;
    }


    // public static bool Method1(string str1, string str2) {
    //     if (str1.Length != str2.Length) return false; // no need to check then.
    
    //     int hash1 = 0;
    //     int hash2 = 0;
    //     for (int i = 0; i < str1.Length - 1; i++) {      
    //         hash1 += (int) Math.Pow((int) str1[i], (int) str1[i+1]);
    //         hash2 += (int) Math.Pow((int) str2[i], (int) str2[i+1]);
    
    //     }
    //     hash1 += (int) Math.Pow((int) str1[str1.Length - 1], (int) str1[0]);
    //     hash2 += (int) Math.Pow((int) str2[str2.Length - 1], (int) str2[0]);

    //     System.Console.WriteLine("hash1= {0}, hash2 = {1}", hash1,hash2);
    //     return (hash1 == hash2);
    // }
}