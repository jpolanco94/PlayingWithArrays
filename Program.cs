using System;

namespace ArrayGames
{
    struct TheThreeArrays
    {
        public int[] arrayA;
        public int[] arrayB;
        public int[] arrayC;
    }

    class Program
    {
        //I learned of bubble and selection sorts from the Microsoft Data Structures and Algorithms course.
        static int[] BubbleSort(int[] enteredArray)
        {
            int n = enteredArray.Length;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < n - 1; i++)
                {
                    if (enteredArray[i] > enteredArray[i + 1])
                    {
                        int temp = enteredArray[i];
                        enteredArray[i] = enteredArray[i + 1];
                        enteredArray[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped == true);
            return enteredArray;
        }
        static int[] SelectionSort(int[] enteredArray)
        {
            int n = enteredArray.Length;
            int temp, smallest;
            for (int i = 0; i < n - 1; i++)
            {

                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (enteredArray[j] < enteredArray[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = enteredArray[smallest];
                enteredArray[smallest] = enteredArray[i];
                enteredArray[i] = temp;
            }
            return enteredArray;
        }
        static double AverageOfArrayValues(int[] enteredArray)
        {
            double total = 0;
            int count = 0;
            foreach (int value in enteredArray)
            {
                count++;
                total += value;
            }
            double averageOfArray = total / count;
            return averageOfArray;
        }
        static int[] ReverseArrays(int[] enteredArray)
        {
            for (int i = 0; i < enteredArray.Length / 2; i++) 
            {
                int temp = enteredArray[i];
                enteredArray[i] = enteredArray[enteredArray.Length - i - 1];
                enteredArray[enteredArray.Length - i - 1] = temp;
            }
            return enteredArray;
        }
        static int[] RotateArrays(int[] enteredArray, string direction, int numberOfPositions)
        {
            //This solution to rotating arrays seems to be very different to the other solutions others came up
            //with. It works for the getting the job done but will not work if we want to rotate the array one
            //position past the length of the array.
            
            int n = enteredArray.Length;
            int[] temp = new int[n];
            direction.ToLower();
            if (direction == "left")
            {
                //Deep copy of our entered array to have two similar but completely different arrays
                for (int i = 0; i < n; i++)
                {
                    temp[i] = enteredArray[i];
                }
                //Shifting down the elements of the entered array that won't be moved to the back
                for (int i = numberOfPositions; i < n; i++)
                {
                    int tempElement = enteredArray[i];
                    enteredArray[i] = enteredArray[i - numberOfPositions];
                    enteredArray[i - numberOfPositions] = tempElement;
                }
                //Using the deep-copy array to finish up the new array with the values not shifted
                for (int i = 0, j = n - numberOfPositions; i < numberOfPositions; i++, j++)
                {

                    enteredArray[j] = temp[i];
                }
            }
            if (direction == "right")
            {
                for (int i = 0; i < n; i++)
                {
                    temp[i] = enteredArray[i];
                }
                for (int i = n - numberOfPositions - 1; i >= 0; i--)
                {
                    int tempElement = enteredArray[i];
                    enteredArray[i] = enteredArray[i + numberOfPositions];
                    enteredArray[i + numberOfPositions] = tempElement;
                }
                for (int i = 0, j = n - numberOfPositions; i < numberOfPositions; i++, j++)
                {
                    enteredArray[i] = temp[j];
                }
            }
                return enteredArray;
        }
        //The palindrome checker is a whiteboarding exercise that was given to us by our mentors
        //that I enjoyed.
        static bool PalindromeChecker(string s)
        {
            bool checker = true;
            s.ToLower();
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    checker = false;
                }
            }
            return checker;
        }
        static int[] DisplayArrays(int[] enteredArray)
        {
            foreach (int x in enteredArray)
            {
                Console.Write(x.ToString()+" ");
            }
            Console.WriteLine("\n");
            return enteredArray;
        }

        //The way this code was organized is not optimal but it gets the job done. I will continue to work
        //on this code to try to get the 'cleanest' solution.
        static void Main(string[] args)
        {
            TheThreeArrays a1, a2, b1, b2, c1, c2, c3, c4;
            a1.arrayA = new int[] { 0, 2, 4, 6, 8, 10 };
            a2.arrayA = new int[] { 0, 2, 4, 6, 8, 10 };
            b1.arrayB = new int[] { 1, 3, 5, 7, 9 };
            b2.arrayB = new int[] { 1, 3, 5, 7, 9 };
            c1.arrayC = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            c2.arrayC = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            c3.arrayC = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            c4.arrayC = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            Console.WriteLine($"The average of Array A is: {AverageOfArrayValues(a1.arrayA)}\n");
            Console.WriteLine($"The average of Array B is: {AverageOfArrayValues(b1.arrayB)}\n");
            Console.WriteLine($"The average of Array C is: {AverageOfArrayValues(c1.arrayC)}\n");
            Console.Write("Array A reversed is:  "); DisplayArrays(ReverseArrays(a1.arrayA));
            Console.Write("\nArray B reversed is:  "); DisplayArrays(ReverseArrays(b1.arrayB));
            Console.Write("\nArray C reversed is:  "); DisplayArrays(ReverseArrays(c1.arrayC));
            Console.Write("Array A rotated to the left two positions is:  ");
            DisplayArrays(RotateArrays(a2.arrayA, "left", 7));
            Console.Write("Array B rotated to the right two positions is:  ");
            DisplayArrays(RotateArrays(b2.arrayB, "right", 2));
            Console.Write("Array C rotated to the left four positions is:  ");
            DisplayArrays(RotateArrays(c2.arrayC, "left", 4));
            Console.Write("Array C sorted using Bubble Sort is:  ");
            DisplayArrays(BubbleSort(c3.arrayC));
            Console.Write("Array C sorted using Selection Sort is:  ");
            DisplayArrays(BubbleSort(c4.arrayC));
            Console.WriteLine("Enter a string you think might be a palindrome. If it is you'll get true. " +
                "If not you'll get false.");
            string s = Console.ReadLine();
            Console.WriteLine(PalindromeChecker(s));

        }
    }
}
