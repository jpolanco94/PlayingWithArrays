# PlayingWithArrays
## Array exercises to help better understand arrays.

This programming exercise has four parts consisting of four requirements. Completion of all exercises is necessary to receive 
the total score of 100 points. At a minimum, your program must compile successfully and run.

For this programming exercise, you have three test arrays of type integer, shown below. Write a program that performs the 
following tasks, listed below. Do not use convenience functions. (You may use the Length property of the Array type.) Write 
the code by hand.

1. Array A: 0, 2, 4, 6, 8, 10
2. Array B: 1, 3, 5, 7, 9
3. Array C: 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9

## Counting, Summing, and Comuputing the Mean
Write a method counts the number of elements in an integer array, and then sums the elements in an integer array. It 
should return the average of the array elements as a double. Using the count and sum, compute and print the mean of each array.

## Reversing Arrays
Write a method that accepts an array as an argument and prints the reversed array. For example, if you pass the method Array B, 
it should print [9, 7, 5, 3, 1]. Print the reverse of all three arrays.

## Rotating Arrays
Arrays can be rotated to the right or to the left by any number of places. Rotating an array to the right by two places puts the 
first element in position three, the second element in position four, and so on, with the last element in position two and the next 
to last element in position one. Array A rotated to the right by two places results in [8, 10, 0, 2, 4, 6]. Likewise, rotating an 
array to the left places the first elements at the end. Array B rotated to the left by two places results in [5, 7, 9, 1, 3].

Write a method that accepts three parameters, a direction (right or left), a number of places, and an array, which prints the 
appropriate rotation. Call the method on all three arrays. Rotate array A two places to the left. Rotate array B two places to the 
right. Rotate array C four places to the left.

## Sorting Arrays
Write a method that takes an unsorted integer array and prints a sorted array. Use Array C as your test array. Do you recognize this 
list of numbers?

HINT: How do you sort a deck of cards? The simplest strategy is to go through the deck and if the “next” card is “smaller” than 
the current card, swap them. Then, repeat the process until all cards are in order. You should try to implement this without any 
outside help, but if you need just a hint, check out bubble sort.

You will find that recruiters and hiring managers like to give these kinds of whiteboarding problems. You will probably see these or 
similar when you interview at Microsoft.
