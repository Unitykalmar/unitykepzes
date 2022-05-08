using UnityEngine;

public class ControlStructures : MonoBehaviour
{
    [SerializeField] int a;
    [SerializeField] string milyen;


    void Start()
    {
        int i = 1;
        int talal = 0;

        while (talal < 10)
        {
            if (i % 3 == 0 && i % 7 == 0)
            {
                Debug.Log(i);
                talal++;
            }
            i++;
        }
    }

    void OnValidate()
    {
        if (a % 2 == 0)
        {
            milyen = "Paros!";
        }
        else
        {
            milyen = "Paratlan!";
        }

        /* UGYANAZ:

        milyen = a % 2 == 0 ? "Paros!" : "Paratlan!";

        */
    }
}
