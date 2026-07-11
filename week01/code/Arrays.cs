using System.Data;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // Plan: 
        // 1.- Recieve the value of number and length. Create the array where is going to be saved the numbers with the length of lenght. 
        // 2.- Using a for loop, with the variable (could be i or any letter) i starting on 1 (because using 0 could return a 0 and we don't want this), the second part of the parameters of the for loop should be i<= length or  i< length + 1, in order to have just the right number of multiples we want to get. i++ for the last parameter to move to the other number that would multiply the desire number.
        // 3.- The number should be multiplied with the value of i, and this value have to be saved on the array, I will call it 'multiples' and the position where is going to be saved the value of that interation has to be -1 of the value of i, because whe should start on the 0 position of the array .
        // 4.- Finally, return the array.

        double[] multiplies = new double[length];
        for (var i = 1; i <= length; i++)
        {
           multiplies[i-1]= number * i;
        }

        return multiplies; 
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        //MY PLAN:
            //Create a copy of the original list
            //Iterate through the copy list
            //We are going to add the numbers from data to our new list but with the correct posicion after doing the rotation. To do this , we need to calculate the new position like this: 
                // newPosition = ( current posicion + amount) % originalList.Count;
            //Then assign this to the new list:
                //originalList[newPosition] = copyList[current Position];
        //Implementation:
        //Copy of the original list       
        List<int> chida = new List<int>(data);
        for(int i = 0; i < data.Count; i++)
        {
            //Calculating the new position. 
            int newPosition = (i + amount) % data.Count;
            //Changing the originalList
            data[newPosition] = chida[i];
        }
    }
}
