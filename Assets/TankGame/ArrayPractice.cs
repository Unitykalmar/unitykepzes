using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    /*
    [SerializeField] float input1;
    [SerializeField] float input2;
    [SerializeField] float input3;
    */

    [SerializeField] float[] input;
    [SerializeField] string[] stringArray;
    [SerializeField] KeyCode[] keyCodes;
    [SerializeField] Transform[] transforms;
    [SerializeField] Vector3 meanPosition;

    [SerializeField] float mean;

    private void OnValidate()
    {
        // mean = (input1 + input2 + input3) / 3f;

        int length = input.Length;

        if (length != 0)
        {
            float first = input[0];

            float sum = 0;

            for (int i = 0; i < length; i++)
            {
                sum += input[i];
            }

            mean = sum / length;

            if (float.IsNaN(mean))
                mean = 0;

            meanPosition = CalculateMeanPosition();

            // Creating Array

            int[] intArray = new int[5];
            // int[] intArray2 = null; 

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i + 1;
            }
        }
    }

    Vector3 CalculateMeanPosition()
    {
        int transformLength = transforms.Length;
        Vector3 sumPosition = Vector3.zero;
        int nonNullElementCount = 0;

        for (int i = 0; i < transformLength; i++)
        {
            if (transforms[i] != null && transforms[i] != transform)
            {
                sumPosition += transforms[i].position;
                nonNullElementCount++;
            }
        }

        return sumPosition / transformLength;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(Vector3.zero, 1);

        for (int i = 0; i < transforms.Length; i++)
        {
            if (transforms[i] != null && transforms[i] != transform)
                Gizmos.DrawSphere(transforms[i].position, 0.15f);
        }

        Gizmos.color = Color.red;
        Gizmos.DrawSphere(CalculateMeanPosition(), 0.15f);
    }
}