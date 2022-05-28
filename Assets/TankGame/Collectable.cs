using UnityEngine;

public class Collectable : MonoBehaviour
{
    public int value;

    [SerializeField] Bounds teleportBounds;

    public void Collect()
    {
        float randX = Random.Range(teleportBounds.min.x, teleportBounds.max.x);
        float randY = Random.Range(teleportBounds.min.y, teleportBounds.max.y);
        float randZ = Random.Range(teleportBounds.min.z, teleportBounds.max.z);

        transform.position = new Vector3(randX,randY,randZ);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(teleportBounds.center, teleportBounds.size);
    }
}
