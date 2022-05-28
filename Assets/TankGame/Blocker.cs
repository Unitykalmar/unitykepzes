using UnityEngine;

public class Blocker : MonoBehaviour
{
    [SerializeField] float blockingTime;

    void OnTriggerEnter(Collider other)
    {
        Blockable b = other.GetComponent<Blockable>();
        if (b != null)
            b.Block(blockingTime);
    }
}
