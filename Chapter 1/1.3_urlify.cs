namespace CtCI;
public static class URLify{
    public static string Method1(string str) { // runtime O(n)
        
        char[] chararr = new char[str.Length]; 
        int i = 0;
        int j = 0;
        while (j < str.Length){
            if ((int) str[i] == (int) ' ') {
                chararr[j++] = '%';
                chararr[j++] = '0'; 
                chararr[j++] = '2';
                System.Console.WriteLine(i);
                i++;
            }
            else {
                chararr[j] = str[i];
                i++;
                j++;
            }

        }
        string result = new string(chararr); 
        return result;
    }
}