using UnityEngine;

public class Roteter : MonoBehaviour
{
    [SerializeField] float angularSpeed;
    [SerializeField] Space space;

    void Update()
    {
        Vector3 rotate = new Vector3(0, angularSpeed * Time.deltaTime, 0);
        transform.Rotate(rotate, space);
    }
}
