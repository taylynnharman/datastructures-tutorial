using datastructures_tutorial.Stacks;
using datastructures_tutorial.Sets;
using datastructures_tutorial.Trees;
using Solution = datastructures_tutorial.Trees.Solution;

namespace datastructures_tutorial
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n=========== STACK DEMO ===========\n");
            StacksDemo.Run();
            
            Console.WriteLine("\n=========== STACK EXERCISE TEST ===========\n");
            // Uncomment "Stack.Run()" when ready to test your program
            // Stacks.Run();
            
            Console.WriteLine("\n=========== SETS DEMO ===========\n");
            SetsDemo.Run();
            
            Console.WriteLine("\n=========== SET EXERCISE TEST ===========\n");
            // Uncomment "Sets.Run()" when ready to test your program
            // Sets.Run();

            Console.WriteLine("\n=========== TREES DEMO ===========\n");
            TreesDemo.Run();
            
            Console.WriteLine("\n=========== TREES EXERCISE TEST ===========\n");
            // Uncomment "Sets.Run()" when ready to test your program
            // Sets.Run();

        }
    }
}