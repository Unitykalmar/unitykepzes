using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform target1;
    [SerializeField] Transform target2;
    [SerializeField] AnimationCurve speedOverDistance;
    Vector3 targetPos;

    private void Update()
    {
        Vector3 enemyPos = transform.position;

        if (target2 != null)
        {
            if ((target1.position - transform.position).magnitude < (target2.position - transform.position).magnitude)
            {
                targetPos = target1.position;
            }
            else
                targetPos = target2.position;
        }
        else if (target1 != null)
            targetPos = target1.position;
        else
            targetPos = enemyPos;

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
