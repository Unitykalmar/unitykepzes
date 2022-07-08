using System.Collections.Generic;
using UnityEngine;

public class ListPactrice : MonoBehaviour
{
    [SerializeField] int[] array;
    [SerializeField] List<string> list;

    void Start()
    {
        // Lenght
        Debug.Log(array.Length);
        Debug.Log(list.Count);

        // Indexing
        Debug.Log(array[1]);
        Debug.Log(list[1]);

        // Arraies are fix lenght
        // Listis are dinamic

        list.Add("dfsg");
        list.Remove("dfsg");
        list.RemoveAt(4);
        list.Insert(3, "12345fds");
        bool IsContaining = list.Contains("dfsg");
        list.Sort();  // sortba rendezi
        list.Clear();

        List<Vector2> v2List = new List<Vector2>();
     }
}
