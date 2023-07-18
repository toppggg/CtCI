namespace CtCI;
public static class One_away{
    public static bool Method1(string str1, string str2) {
        // string worker = (new string[] {str1,str2}).Aggregate((s,b) => s.Length < b.Length ? s:b); // using System.Linq
        string worker = str1;
        string target = str2;        
        if (str2.Length < str1.Length) {
             worker = str2;
            target = str1; 
        }
        int i = 0;
        int j = 0;
        bool mod_used = false;
        while (i < worker.Length) {
            if (worker[i] != target[j]) {
                if (mod_used) return false; // Check if 1 mod has already been used.
                if (worker.Length < target.Length ) { // worker < target, so rest of worker shall be equal to taget.
                    j++; 
                    mod_used = true;
                } else if (worker.Length == target.Length){ // use the mod to set the char from str 1 = str 2.
                    i++;
                    j++;
                    mod_used = true;
                } else return false; // cannot have letter not equal and different length, will require two modifications.
            } 
            i++;
            j++;
        }
        return true;
    }
}