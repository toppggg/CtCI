namespace CtCI;
public static class Is_unique{
    public static bool Method1(string str) {
        bool[] chars = new bool[128];

        if (str.Length >128 ) return false;

        for (int i = 0; i < str.Length; i++) {
            int ascii = str[i];
            if (chars[ascii]) return false;
            else chars[ascii] = true;
        }
        return true;
    }


    // This is slower, the assembly code is 130 instructions, the upper one is 100, and it has the same size.
    public static bool Method2(string str) {
        System.UInt128 chars = System.UInt128.Zero;

        if (str.Length >128 ) return false;

        for (int i = 0; i < str.Length; i++) {
            System.UInt128 ascii = System.UInt128.One << str[i];
            System.UInt128 check = chars & ascii;
            if (check != System.UInt128.Zero) return false;
            else chars = (chars | ascii);
        }
        return true;        
    }
}
