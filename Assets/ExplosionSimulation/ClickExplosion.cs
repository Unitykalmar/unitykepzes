using UnityEngine;

public class ClickExplosion : MonoBehaviour
{
    [SerializeField] float explosionForce;
    [SerializeField] float explosionRadius;
    [SerializeField] float upwardsModifier;
    [SerializeField] Camera camera;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray mouseRay = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(mouseRay, out RaycastHit hitInfo))
            {
                Rigidbody[] allRgbds = FindObjectsOfType<Rigidbody>();

                foreach (var rgbd in allRgbds)
                {
                    rgbd.AddExplosionForce(explosionForce, hitInfo.point, explosionRadius, upwardsModifier, ForceMode.Impulse);
                }

                Debug.Log(hitInfo.point);
            }
        }
    }
}
