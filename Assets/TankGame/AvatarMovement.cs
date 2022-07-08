using UnityEngine;

public class AvatarMovement : MonoBehaviour
{
    [SerializeField] Damageable damageable;
    [SerializeField] AvatarInput Input;

    [SerializeField] float speed;
    [SerializeField] float maxspeed;
    [SerializeField] float accelerate;
    [SerializeField] float angularSpeed;
    [SerializeField] Space movementSpace = Space.World;


    private void Update()
    {
        if (damageable.health > 0)
        {
            Move();
        }
    }

    void Move()
    {
        Vector3 InputVector = Input.InputVector();

        if (InputVector != Vector3.zero && speed < maxspeed)
        {
            speed += accelerate * Time.deltaTime;
        }
        else if (speed > 0)
        {
            speed -= 1;
        }

        //if (movementSpace == Space.Self)
        //    movement = transform.TransformVector(movement);

        Vector3 movement = InputVector;

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
    public void RestartAvatar()
    {
        transform.position = Vector3.zero;
    }
}
