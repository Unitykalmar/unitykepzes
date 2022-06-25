using System;
using UnityEngine;

public class Avatar2 : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] float maxspeed;
    [SerializeField] float accelerate;
    [SerializeField] float angularSpeed;
    [SerializeField] Damageable damageable;
    [SerializeField] Space movementSpace = Space.World;

    [SerializeField] GameObject projectilePrototype;


    private void Update()
    {
        if (damageable.health > 0)
        {
            Move();
            TryShoot();
        }
    }

    void TryShoot()
    {
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            GameObject go = Instantiate(projectilePrototype);
            go.SetActive(true);
            Projectile p = go.GetComponent<Projectile>();

            Vector3 forward = transform.forward;
            go.transform.position = projectilePrototype.transform.position;
            p.Shoot(forward);
        }
    }

    void Move()
    {
        bool right = Input.GetKey(KeyCode.RightArrow);
        bool left = Input.GetKey(KeyCode.LeftArrow);
        float xMovement = ToNumber(right, left);

        bool up = Input.GetKey(KeyCode.UpArrow);
        bool down = Input.GetKey(KeyCode.DownArrow);
        float zMovement = ToNumber(up, down);

        if (speed < maxspeed && (right || left || up || down))
        {
            speed += accelerate * Time.deltaTime;
        }
        else if (speed > 0)
        {
            speed -= 1;
        }

        Vector3 movement = new Vector3(xMovement, 0, zMovement);
        
        //if (movementSpace == Space.Self)
        //    movement = transform.TransformVector(movement);
        
        movement.y = 0;
        movement.Normalize();
        movement *= Time.deltaTime;
        movement *= speed;

        transform.Translate(movement, Space.World);  // transform.position += movement;

        if (movement.magnitude != 0)
        {
            Quaternion targetRotation = Quaternion.LookRotation(movement);
            Quaternion currentRotation = transform.rotation;

            transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, angularSpeed * Time.deltaTime);
        }
    }

    float ToNumber(bool positive, bool negative)
    {
        return (positive ? 1 : 0) + (negative ? -1 : 0);
    }

    public void RestartAvatar()
    {
        transform.position = Vector3.zero;
    }
}
