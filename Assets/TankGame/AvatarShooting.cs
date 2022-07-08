using UnityEngine;

public class AvatarShooting : MonoBehaviour
{
    [SerializeField] GameObject projectilePrototype;
    [SerializeField] Transform projectileStartPoz;

    [SerializeField] Damageable damageable;
    [SerializeField] AvatarInput input;

    private void Update()
    {
        TryShoot();
    }

    void TryShoot()
    {
        if (input.isShooting())
        {
            GameObject go = Instantiate(projectilePrototype);
            go.SetActive(true);
            Projectile p = go.GetComponent<Projectile>();

            Vector3 forward = transform.forward;
            go.transform.position = projectileStartPoz.position;
            p.Shoot(forward);
        }
    }
}
