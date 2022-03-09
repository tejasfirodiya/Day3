// See https://aka.ms/new-console-template for more information

class DemoDay03Assignment
{

    public static void Test()
    {
        Console.WriteLine("===========Assignment Day03==========");

        Console.Write("Enter an equation containing numbers and operators : ");
        string str = Console.ReadLine();
        string[] strarr = str.Split(" ");

        int ans = int.Parse(strarr[0]); // 5 + 5 + 5 + 5 

        for (int i = 1; i < strarr.Length; i++) 
        {
            if (strarr[i] == "+")
            {
                ans += int.Parse(strarr[i + 1]);
                i++;
            }
            else if (strarr[i] == "-")
            {
                ans -= int.Parse(strarr[i + 1]);
                i++;
            }
            else if (strarr[i] == "*")
            {
                ans *= int.Parse(strarr[i + 1]);
                i++;
            }
            else if (strarr[i] == "/")
            {
                ans /= int.Parse(strarr[i + 1]);
                i++;
            }
            else
            {
                ans = int.Parse(strarr[i]); 
                i++;
            }
            //BODMAS(int.Parse(strarr[i]));

        }
        Console.WriteLine("Answer : " + ans);
    }

    //public static void BODMAS(string[] strarr)
    //{
    //    int ans = int.Parse(strarr[0]);

    //    for(int i = 1; i < strarr.Length; i++)
    //    {
    //        if(strarr[i] == "*")
    //        {
    //            ans *= int.Parse(strarr[i]);
    //            Console.Write(ans);
    //        }
    //        else if (strarr[i] == "/")
    //        {
    //            ans /= int.Parse(strarr[i]);
    //            Console.Write(ans);
    //        }

    //    }
    //}
}