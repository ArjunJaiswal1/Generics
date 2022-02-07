using GenericsProblem;
class Problem
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Find the Maximum Number!");
        //int[] intArray = { 1, 2, 9, 4 };
        //Maximum<int> generic = new Maximum<int>();
        //generic.PrintMaxValue(intArray);

        double[] doubleArray = { 1.1, 1.2, 1.3 };
        Maximum<double> genericDouble = new Maximum<double>();
        genericDouble.PrintMaxValue(doubleArray);
    }
}
