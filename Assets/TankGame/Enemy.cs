using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform target1;
    [SerializeField] Transform target2;
    [SerializeField] AnimationCurve speedOverDistance;

   private void Update()
    {
        Vector3 targetPos;

        if (target2 != null) {
            if ((target1.position - transform.position).magnitude < (target2.position - transform.position).magnitude)
            {
                targetPos = target1.position;
            }
            else
                targetPos = target2.position;
        }
        else
            targetPos = target1.position;


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
