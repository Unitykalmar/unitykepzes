using UnityEngine;

public class VectorTest : MonoBehaviour
{
    [SerializeField] Vector3 v3a = new Vector3(1f, 1f, 1f);
    [SerializeField] Vector3 v3b = new Vector3(2f, 2f, 2f);
    [SerializeField] float multiplier = 1;

    [Space]
    [SerializeField] Vector3 summa;
    [SerializeField] Vector3 multiplied;
    [SerializeField] float length;
    [SerializeField] Vector3 normal;

    void OnValidate()
    {
        summa = v3a + v3b;
        multiplied = summa * multiplier;
        length = multiplied.magnitude;
        normal = multiplied.normalized;
    }
}
