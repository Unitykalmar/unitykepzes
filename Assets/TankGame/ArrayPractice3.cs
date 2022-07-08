using UnityEngine;

public class ArrayPractice3 : MonoBehaviour
{
    [SerializeField] float[] inputArray;
    [SerializeField] float sum;
    private void OnValidate()
    {
        //Foreach

        sum = 0;

        foreach (float item in inputArray)
        {
            sum += item;
        }

        // Strings

        string st = "Bear"; // Medve
        char[] charArray = st.ToCharArray();
        charArray[2] = 'e'; // Sör
        string newSt = new string(charArray);


    }
}
