using UnityEngine;

public class MyFirstFeledat : MonoBehaviour
{
    [SerializeField] int num;
    [SerializeField] string what;

    void Start()
    {
        count = 0;
        for (int i=1; i<=num; i++)
        {
            if (num % 3 == 0) what;
        }
        Debug.Log(count);
    }
}
