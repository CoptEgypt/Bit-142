
/*Filobatire Henein
2/23/2022
Major Coding Assignment 4
Purpose: Given a list of numbers by the user, I will code the algorithm for the following in order to find the element the user 
is searching for
 Binary Search
 Linear Search
 Bubble Sort
 A searching algorithm of your choice
 A sorting algorithm of your choice 
If the element is present, print the index it is at.
If the element is not present, print “the element is not in this list.”
*/
import java.util.*;

public class Major_CS_Assignment4_SearchingAndSortingAlgorithm {
    public static void main(String[] args) {
        StartGame();
        PlayGame();
        // EndGame(PlayGame());
    }

    public static void StartGame() {
        // This method prints out the introduction message telling the user that he is
        // Searching and Sorting Algorithm.
        System.out.println("Hello! Welcome to Filo's Searching and Sorting Algorithm!\n");
        System.out.println("What search/sort method would you like do? ");
    }

    public static void PlayGame() {
        // This method asks the user what method would he like to use weather the Linear
        // or the Binary Search. then it sorts the numbers given by the users then
        // awaits to see what number is the user looking for and then it prints out what
        // index is it in.
        Scanner keyboard = new Scanner(System.in);
        String userChoice;
        int number, searchNumber, index;
        userChoice = keyboard.nextLine();
        System.out.println("\nHow many numbers do you have?");
        number = keyboard.nextInt();
        int[] numArray = new int[number];
        for (int i = 0; i < number; i++) {
            System.out.println("Please enter a number: ");
            numArray[i] = keyboard.nextInt();
        }

        // linear search implentation
        if (userChoice.equalsIgnoreCase("Linear Search")) {
            System.out.println("\nWhat number do you looking for? ");
            searchNumber = keyboard.nextInt();
            index = linearSearch(numArray, searchNumber);
            if (index == -1)
                System.out.println("\nThe element you are looking for is not in the list.");
            else
                System.out.println("\nThe element you are looking for is at index " + index);
        }

        // Binary search implement
        if (userChoice.equalsIgnoreCase("Binary Search")) {
            bubbleSort(numArray);
            System.out.println("\nAfter sorting using bubble sort your new Array is: ");
            for (int i = 0; i < numArray.length; i++) {
                System.out.println(numArray[i]);
            }
            System.out.println("\nWhat number do you looking for? ");
            searchNumber = keyboard.nextInt();
            index = linearSearch(numArray, searchNumber);
            if (index == -1)
                System.out.println("\nThe element you are looking for is not in the list.");
            else
                System.out.println("\nThe element you are looking for is at index " + index);

        }

    }

    // this method sorts the arrays for both methods.
    static void bubbleSort(int[] arr) {
        int n = arr.length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1]) {
                    // swap temp and arr[i]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
    }

    // this method finds the element the user is looking for using Linear Search.
    public static int linearSearch(int[] arr, int x) {
        for (int i = 0; i < arr.length; i++) {
            if (arr[i] == x)
                return i;
        }
        return -1;
    }

    // this method finds the element the user is looking for using Binary Search.
    public static int binarySearch(int[] arr, int l, int r, int x) {
        if (r >= l) {
            int mid = l + (r - l) / 2;

            // If the element is present at the
            // middle itself
            if (arr[mid] == x)
                return mid;

            // If element is smaller than mid, then
            // it can only be present in left subarray
            if (arr[mid] > x)
                return binarySearch(arr, l, mid - 1, x);

            // Else the element can only be present
            // in right subarray
            return binarySearch(arr, mid + 1, r, x);
        }

        // We reach here when element is not present
        // in array
        return -1;
    }

}