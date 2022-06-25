using UnityEngine;
using UnityEngine.SceneManagement;

public class HaveAPlayer : MonoBehaviour
{
    [SerializeField] GameObject avatar1;
    [SerializeField] GameObject avatar2;
    void Update()
    {
        if(avatar1==null && avatar2 == null)
        {
            SceneManager.LoadScene("MenuScene");
        }
    }
}
