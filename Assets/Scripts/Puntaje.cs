using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{
    public static int puntos = 0;
    TextMeshProUGUI texto;

    void Start()
    {
        texto = GetComponent<TextMeshProUGUI>();
        puntos = 0;
    }

    void Update()
    {
        texto.text = "Puntaje: " + puntos;
    }
}