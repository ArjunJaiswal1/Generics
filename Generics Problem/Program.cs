using GenericsProblem;
class Problem
{
    static void Main(string[] args)
    {
        Console.WriteLine("Find the Maximum Number!");
        int[] intArray = { 1, 2, 9, 4 };
        Maximum<int> generic = new Maximum<int>();
        generic.PrintMaxValue(intArray);
    }
}