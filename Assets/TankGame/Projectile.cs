using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 25;
    [SerializeField] float duration = 5;

    Vector3 direction;
    float shootTime;
    bool isShooted = false;

    public void Shoot(Vector3 direction)
    {
        isShooted = true;
        shootTime = Time.time;
        this.direction = direction.normalized;
    }

    void Update()
    {
        if (isShooted)
        {
            Vector3 movementVector = direction * Time.deltaTime * speed;
            transform.Translate(movementVector, Space.World);

            if (shootTime + duration <= Time.time)
                Destroy(gameObject);
        }
    }
}
