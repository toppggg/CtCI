namespace CtCI;
public static class Check_permutations{
    public static bool Method1(string str1, string str2) {
        int[] arr1 = GetLetters(str1);
        int[] arr2 = GetLetters(str2);

        for (int i = 0; i < 128; i++){
            if (arr1[i] != arr2[i]) return false;
        }
        return true;
    }

    private static int[] GetLetters(string str) {

        int[] result = new int[128];

        for (int i = 0; i < str.Length;i++) {
            int next = str[i];
            result[next] += 1; 
        }
        foreach (int i in result) System.Console.Write(i);
        System.Console.WriteLine(" ");

        return result;
    }

    
}