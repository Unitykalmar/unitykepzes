using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] Transform p1;
    [SerializeField] Transform p2;
    [SerializeField] float speed;
    [SerializeField, Range(0,1)] float phase;

    float t;

    private void OnValidate()
    {
        UpdatePosition();
    }

    private void Update()
    {
        t += Time.deltaTime * speed;
        phase = t % 2;
        phase -= 1;
        phase = Mathf.Abs(phase);
        UpdatePosition();
    }

    void UpdatePosition()
    {
        transform.position = Vector3.Lerp(p1.position, p2.position, phase);
    }

    private void OnDrawGizmos()
    {
        if (p1 == null || p2 == null)
            return;

        Gizmos.color = Color.red;
        Gizmos.DrawLine(p1.position, p2.position);
    }
}
