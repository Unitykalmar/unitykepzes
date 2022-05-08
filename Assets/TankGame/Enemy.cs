using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] AnimationCurve speedOverDistance;


    private void Update()
    {
        Vector3 targetPos = target.position;
        Vector3 enemyPos = transform.position;

        Vector3 movement = targetPos - enemyPos;

        float distance = movement.magnitude;

        float speed = speedOverDistance.Evaluate(distance);

        movement.Normalize();
        movement *= speed;
        movement *= Time.deltaTime;

        transform.Translate(movement, Space.World);

        if (movement.magnitude != 0)
        {
            transform.rotation = Quaternion.LookRotation(movement);
        }
    }
}
