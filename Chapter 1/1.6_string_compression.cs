namespace CtCI;
public static class String_compression{
    public static string Method1(string str) {
        string result = "";
        char last_letter = str[0];
        int counts = 1;
        int i = 1;
        while (i < str.Length) {
            if (str[i] == str[i-1] ){
                counts++;
                
            } else { // char not matching, write number to string.
                if (counts <=2) {
                    for (int j = 1; j <= counts; j++) {
                        result = result + str[i-1];
                    }
                }
                else result = result + str[i-1] + counts;
                counts = 1;
            }
            i++;
        }
        // post loop write last char + number
        if (counts <=2) {
            for (int j = 1; j <= counts; j++) {
                result = result + str[i-1];
            }
        }
        else result = result + str[i-1] + counts;        


        return result;
    }
}