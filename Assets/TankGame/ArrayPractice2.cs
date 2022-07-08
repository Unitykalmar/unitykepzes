using UnityEngine;

public class ArrayPractice2 : MonoBehaviour
{
    void OnValidate()
    {
        int[] array1 = new int[] { 2, 5, 7 };
        int[] array2 = { 2, 5, 7 };

        int[] array3 = array2;

        array1[1] = 9;
        array3[1] = 4;

        Debug.Log(array1[1] + array2[1]);
    }
}
