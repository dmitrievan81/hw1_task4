
using System;
class Program
{
    // function without any return type declaration  
    public int GetNumber(string VarName)
    {
        int res;
        string input;
        do
        {
            Console.WriteLine(String.Format("Enter number: {0} = ", VarName));
            input = Console.ReadLine();
        } while (int.TryParse(input, out res) == false);
        return res;
    }

    public static void Main(string[] args)
    {
        Program pr = new Program(); // Creating a class Object  
        string VarName_a = "a";
        string VarName_b = "b";
        string VarName_c = "c";
        int a = pr.GetNumber(VarName_a);
        int b = pr.GetNumber(VarName_b);
        int c = pr.GetNumber(VarName_c);
        
        int max;
        
        string VarName;

        if (a > b) {
            max = a;
            VarName = VarName_a;
        } else { 
            max = b;
            VarName = VarName_b;
        }
        
        if (c > max) {
            max = c;
            VarName = VarName_c;
        }
        Console.WriteLine(String.Format("The max value is {0} = {1}", VarName, max));
    }
}