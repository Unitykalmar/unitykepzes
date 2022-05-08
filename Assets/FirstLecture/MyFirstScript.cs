using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    [Header("Calcutator")]
    [SerializeField] float floatInput1;
    [SerializeField] float floatInput2;

    [Space]
    [SerializeField] float summa;
    [SerializeField] float kulonbseg;
    [SerializeField] float szorzat;
    [SerializeField] float hanyad;
    [SerializeField] float modulo;

    [Header("Atlag")]
    [SerializeField] int a = 1;
    [SerializeField] int b = 2;
    [SerializeField] int c = 3;
    [Space]
    [SerializeField] float atlag;

    [Header("Kor")]
    [SerializeField] float radius;
    [Space]
    [SerializeField] float kerulet;
    [SerializeField] float terulet;

    // Start is called before the first frame update
    void Start()
    {
        float temp = floatInput1;
        floatInput1 = floatInput2;
        floatInput2 = temp;
    }

    void OnValidate()
    {
        summa = floatInput1 + floatInput2;
        kulonbseg = floatInput1 - floatInput2;
        szorzat = floatInput1 * floatInput2;
        hanyad = floatInput1 / floatInput2;
        modulo = floatInput1 % floatInput2;

        atlag = (a + b + c) / 3f;

        kerulet= 2 * radius * Mathf.PI;
        terulet= radius * radius * 3.14f;

     }
}
