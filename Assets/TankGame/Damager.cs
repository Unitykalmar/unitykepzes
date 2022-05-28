using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField] int damage = 10;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{name} <-> {other.name}");

        Damageable damageable = other.GetComponent<Damageable>();

        if (damageable != null)
        {
            damageable.DoDamage(damage);
        }
    }

}
