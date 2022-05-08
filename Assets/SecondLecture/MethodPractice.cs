using UnityEngine;

public class MethodPractice : MonoBehaviour
{
    [SerializeField] float a;
    [SerializeField] float b;

    [Space]
    [SerializeField] float max;
    [SerializeField] float min;
    [SerializeField] float absolutevalue;
    [SerializeField] float sign;
    [SerializeField] float power;
    [SerializeField] float power2;

    private void OnValidate()
    {
        max = Mathf.Max(a, b);
        min = Mathf.Max(a, b);
        absolutevalue = Mathf.Abs(a);
        sign = Mathf.Sign(a);
        power = Mathf.Pow(a, b);
        power2 = MyPower(a, b);
    }

    float Maximum(float a, float b)
    {
        return a > b ? a : b;
    }

    float MyAbs(float a)
    {
        return a > 0 ? a : -a;
    }

    float MyPower(float a, float b)
    {
        float x=1;
        for(int i=1; i<=b; i++)
        {
            x *= a;
        }
        return x;
    }
}
