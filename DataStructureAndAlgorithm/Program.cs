namespace DataStructureAndAlgorithm
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            //Console.WriteLine("These are Ds and Algorithm Programs");
            //BinarySearchWord binarySearchWord = new BinarySearchWord();
            //binarySearchWord.SearchWord(@"D:\assignments\DS_AlgorithmRepo\DataStructureAndAlgorithm\file.txt");
            //Console.WriteLine("\n");
            //Anagram a=new Anagram();
            //a.Check();
            //Console.WriteLine("\n");
            //Bubblesort.Display();
            //InsertionSort sort = new InsertionSort();
            //sort.Display();
            int[] numbers = { 38, 27, 43, 3, 0, 82, 10 };
            int len = numbers.Length;
            Console.WriteLine("Before Merge Sort:");
            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("After Merge Sort");
            Merge.SortMethod(numbers, 0, len - 1);
            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.Read();
        }
    }

}
    
