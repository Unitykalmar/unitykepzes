using UnityEngine;

public class AvatarInput : MonoBehaviour
{
    [SerializeField] KeyCode upKey;
    [SerializeField] KeyCode downKey;
    [SerializeField] KeyCode rightKey;
    [SerializeField] KeyCode leftKey;
    [SerializeField] KeyCode shootKey;
    [SerializeField] KeyCode jumpKey;

    public Vector3 InputVector()
    {
        bool right = Input.GetKey(rightKey);
        bool left = Input.GetKey(leftKey);
        float xMovement = ToNumber(right, left);

        bool up = Input.GetKey(upKey);
        bool down = Input.GetKey(downKey);
        float zMovement = ToNumber(up, down);

        return new Vector3(xMovement, 0, zMovement);
    }

    public bool isShooting()
    {
        return Input.GetKeyDown(shootKey);
    }

    public bool isJunping()
    {
        return Input.GetKeyDown(jumpKey);
    }

    float ToNumber(bool positive, bool negative)
    {
        return (positive ? 1 : 0) + (negative ? -1 : 0);
    }
}
