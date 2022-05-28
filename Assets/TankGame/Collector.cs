using UnityEngine;
using TMPro;

public class Collector : MonoBehaviour
{
    [SerializeField] int colletedValue;
    [SerializeField] TMP_Text scoreText;

    void OnTriggerEnter(Collider other)
    {
        Collectable collectable = other.GetComponent<Collectable>();

        if(collectable!= null)
        {
            colletedValue += collectable.value;
            collectable.Collect();
            UpdateText();
        }
    }

    void UpdateText()
    {
        if (scoreText != null)
            scoreText.text = $"Score: {colletedValue}";
    }

    public void RestartCollectorValue()
    {
        colletedValue = 0;
        UpdateText();
    }
}
