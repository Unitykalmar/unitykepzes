using UnityEngine;

public class Human : MonoBehaviour
{
    [SerializeField] string firstname="No Name";
    [SerializeField] string familyname = "No Name";
    [SerializeField, Min(1900)] int born = 1950;
    [SerializeField, Range(50, 300)] float height = 160;
    [SerializeField] bool isAlive = true;

    [Space]
    [SerializeField] bool blabbla;
    [SerializeField] bool krixkrax;

    // BLABLA
    // Élnie kell
    // Magasabb 165 cm-nél, de kisebb 200-nál
    // 2000 vagy azután születetteket veszünk fel

    // KIRXKRAX
    // Kisebb 180 cm-nél vagy nagyobb 210-nél
    // Azonnal felvesszük, ha a keresztneve és a vezetékneve megegyezik

    void OnValidate()
    {
        blabbla = isAlive && (height > 165 && height < 200) && (born >= 2000);
        krixkrax = (height > 210 || height < 180) || (firstname==familyname);
    }
}
