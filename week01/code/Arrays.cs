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
        // Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // Plan:
        // 1. Create a new array of doubles with the specified length.
        // 2. Iterate through the array, calculating each multiple of the input number.
        // 3. Assign the calculated multiple to the corresponding index in the array.
        // 4. Return the array.

        double[] multiples = new double[length]; // Step 1: Create a new array

        for (int i = 0; i < length; i++) // Step 2: Iterate through the array
        {
            multiples[i] = number * (i + 1); // Step 3: Calculate and assign the multiple
        }

        return multiples; // Step 4: Return the array

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
        // Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // Plan:
        // 1. Handle the case where the amount is equal to the list's count, which results in no change.
        // 2. Calculate the effective rotation amount by using the modulo operator (%) to handle cases where amount > data.Count
        // 3. Use list slicing to extract the last 'amount' elements from the list.
        // 4. Remove the last 'amount' elements from the original list.
        // 5. Insert the extracted elements at the beginning of the list.

        int n = data.Count;

        if (amount == n) return; // Step 1: No change if amount == data.Count

        amount %= n; // Step 2: Effective rotation amount

        List<int> rotatedPart = data.GetRange(n - amount, amount); // Step 3: Extract the last 'amount' elements
        data.RemoveRange(n - amount, amount); // Step 4: Remove the last 'amount' elements
        data.InsertRange(0, rotatedPart); // Step 5: Insert the extracted elements at the beginning

        return;


    }
}
