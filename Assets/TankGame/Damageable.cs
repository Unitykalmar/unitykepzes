using UnityEngine;
using TMPro;

public class Damageable : MonoBehaviour
{
    public int health = 100;
    [SerializeField] TMP_Text healthText;
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] GameObject avatar;

    int startHealth;

    private void Start()
    {
        startHealth = health;
        UpdateText();
    }

    public void DoDamage(int damage)
    {
        if (health <= 0)
            return;

        if (health >= damage)
            health -= damage;
        else
            health = 0;

        UpdateText();

        if (health <= 0)
            Destroy(avatar);
          //  gameOverScreen.SetActive(true);
    }

    void UpdateText()
    {
        if (healthText != null)
            healthText.text = $"Health: {health}";
    }

    public void RestartDamageable()
    {
        //gameOverScreen.SetActive(false);
        health = startHealth;
        UpdateText();
    }
}
