namespace CtCI;
public static class Palin_Permu{
    public static bool Method1(string str) {
        str = str.ToLower();
        System.UInt128 chars = System.UInt128.Zero; 
        for (int i = 0; i < str.Length; i++) {
            if (str[i] != ' '){
                System.UInt128 ascii = System.UInt128.One << str[i];
                chars = (chars ^ ascii);
            }
        }
        return ((chars == System.UInt128.Zero) || (chars == (chars & -chars)));
    }
}