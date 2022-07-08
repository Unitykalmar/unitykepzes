using System;
using UnityEngine;

public class AvatarPhysicsMovement : MonoBehaviour
{
    [SerializeField] float maxSpeed;
    [SerializeField] float acceleration;
    [SerializeField] float jumpVelocity;

    [SerializeField] Damageable damagable;
    [SerializeField] AvatarInput input;
    [SerializeField] Rigidbody rgbd;

    void FixedUpdate()
    {
        if (damagable.health > 0)
        {
            Move();
        }
    }

    private void Update()
    {
        if (damagable.health > 0)
        {
            TryJump();
        }
    }

    private void TryJump()
    {
        if (input.isJunping())
            rgbd.AddForce(Vector3.up * jumpVelocity, ForceMode.VelocityChange);
    }

    private void Move()
    {
        Vector3 inputVector = input.InputVector();
        // rgbd.velocity = inputVector.normalized * speed;
        rgbd.AddForce(inputVector * acceleration, ForceMode.Acceleration);

        Vector3 vel = rgbd.velocity;
        Vector3 VelHorizontal = new Vector3(vel.x, 0, vel.z);
        float currentHorizontalSpeed = VelHorizontal.magnitude;

        // Version1
        //if(currentSpeed > maxSpeed)
        //{
        //    rgbd.velocity = vel.normalized * maxSpeed;
        //}

        //Version2 optimálisabb
        //if (currentSpeed > maxSpeed)
        //{
        //    rgbd.velocity *= maxSpeed / currentSpeed;
        //}

        //Version3 olvashatóbb
        if (currentHorizontalSpeed > maxSpeed)
        {
            Vector3 clamped = Vector3.ClampMagnitude(vel, maxSpeed);
            clamped.y = vel.y;
            rgbd.velocity = clamped;
        }
    }
}
