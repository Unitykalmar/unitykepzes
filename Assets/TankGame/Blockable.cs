
using UnityEngine;

public class Blockable : MonoBehaviour
{
    [SerializeField] MonoBehaviour blockedScript;
    [SerializeField] Collider blockedCollider;

    float unBlockingTime;
    bool isBlocked;

    public void Block(float blockingTime)
    {
        SetEnabled(false);
        unBlockingTime = Time.time + blockingTime;
        isBlocked = true;
    }

    void SetEnabled(bool enable)
    {
        blockedScript.enabled = enable;
        blockedCollider.enabled = enable;
    }

    void Update()
    {
        if (isBlocked && Time.time >= unBlockingTime)
        {
            SetEnabled(true);
            isBlocked = false;
        }
    }
}

