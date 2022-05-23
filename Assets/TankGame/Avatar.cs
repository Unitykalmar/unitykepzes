using UnityEngine;

public class Avatar : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] float maxspeed;
    [SerializeField] float accelerate;
    [SerializeField] float angularSpeed;
    private void Update()
    {
        bool right = Input.GetKey(KeyCode.D);
        bool left = Input.GetKey(KeyCode.A);
        float xMovement = ToNumber(right, left);

        bool up = Input.GetKey(KeyCode.W);
        bool down = Input.GetKey(KeyCode.S);
        float zMovement = ToNumber(up, down);

        Vector3 movement = new Vector3(xMovement, 0, zMovement);
        movement.Normalize();

        if (speed < maxspeed && (right || left || up || down))
        {
            speed += accelerate;
        }
        else if(speed > 0)
        {
            speed -= 1;
        }

        movement *= speed;
        movement *= Time.deltaTime;

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
}
