using System;

namespace ArrayGames
{
    class Program
    {
        //I learned of bubble and selection sorts from the Microsoft Data Structures and Algorithms course.
        static void BubbleSort(int[] enteredArray)
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
            foreach (int value in enteredArray)
            {
                Console.Write(value.ToString() + " ");
            }
            Console.WriteLine("\n");
        }
        static void SelectionSort(int[] enteredArray)
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
            foreach (int value in enteredArray)
            {
                Console.Write(value.ToString() + " ");
            }
            Console.WriteLine("\n");
        }
        public static void AverageOfArrayValues(int[] enteredArray)
        {
            double total = 0;
            int count = 0;
            foreach (int value in enteredArray)
            {
                count++;
                total += value;
            }
            double averageOfArray = total / count;
            Console.WriteLine(averageOfArray);
        }
        
        static void SortingArraysNotGoodMethod(int[] enteredArray)
        {
            Console.WriteLine("\nThis will take some time.");
            //This solution is not the most optimal but its the best I could come up with
            for (int i = 0; i < enteredArray.Length - 1; i++)
            {
                for (int j = i+1; j < enteredArray.Length; j++)
                {
                    while (enteredArray[i] > enteredArray[j])
                    {
                        int temp = enteredArray[i];
                        enteredArray[i] = enteredArray[i + 1];
                        enteredArray[i + 1] = temp;
                    }
                }
            }
            foreach (int value in enteredArray)
            {
                Console.Write(value.ToString() + " ");
            }
        }
        static void ReverseArrays(int[] enteredArray)
        {
            for (int i = 0; i < enteredArray.Length / 2; i++) 
            {
                int temp = enteredArray[i];
                enteredArray[i] = enteredArray[enteredArray.Length - i - 1];
                enteredArray[enteredArray.Length - i - 1] = temp;
            }
            foreach (var value in enteredArray)
            {
                Console.Write(value.ToString() + " ");
            }
            Console.WriteLine("\n");
        }
        static void RotateArrays(int[] enteredArray, int direction, int numberOfPositions)
        {
            
            int n = enteredArray.Length;
            int[] temp = new int[n];
            if (direction == 1) // Rotating Left
            {
                //Deep copy of our entered array into a temporary array
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
                foreach (int x in enteredArray)
                {
                    Console.Write(x.ToString() + " ");
                }
                Console.WriteLine("\n");
            }
            if (direction == 2)//Rotating Right
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
                foreach (int x in enteredArray)
                {
                    Console.Write(x.ToString() + " ");
                }
                Console.WriteLine("\n");
            }
         
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
        static void Main(string[] args)
        {
            int[] arrayA = { 0, 2, 4, 6, 8, 10 };
            int[] arrayB = { 1, 3, 5, 7, 9 };
            int[] arrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            Console.Write("The average of Array A is:  ");
            AverageOfArrayValues(arrayA);
            Console.Write("\nThe average of Array B is:  ");
            AverageOfArrayValues(arrayB);
            Console.Write("\nThe average of Array C is:  ");
            AverageOfArrayValues(arrayC);
            Console.Write("\nArray A reversed is:  ");
            ReverseArrays(arrayA);
            Console.Write("\nArry B reversed is:  ");
            ReverseArrays(arrayB);
            Console.Write("\nArray C reversed is:  ");
            ReverseArrays(arrayC);
            ////SortingArraysNotGoodMethod(arrayC);
            Console.Write("\nArray C sorted using Selection Sort is:  ");
            SelectionSort(arrayC);
            Console.Write("\nArray C sorted using Bubble Sort is:  ");
            BubbleSort(arrayC);
            Console.Write("\nArray A rotated two positions to the left is:  ");
            RotateArrays(arrayA, 1, 2);
            Console.Write("\nArray B rotated two posisiotns to the right is:  ");
            RotateArrays(arrayB, 2, 3);
            Console.Write("\nArray C rotated four positions to the left is:  ");
            RotateArrays(arrayC, 1, 4);
            Console.WriteLine("Enter a string you think might be a palindrome. If it is you'll get true. If not you'll get false.");
            string s = Console.ReadLine();
            Console.WriteLine(PalindromeChecker(s));
        }
    }
}
