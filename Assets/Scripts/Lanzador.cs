using UnityEngine;
using TMPro;

public class Lanzador : MonoBehaviour
{
    public GameObject avePrefab;
    public TextMeshProUGUI textoTiros;
    public int tirosRestantes = 10;

    int angulo = 50;
    int fuerza = 10;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) { angulo = angulo + 10; } //los botones estos de los angulos y fuerza
        if (Input.GetKeyDown(KeyCode.Alpha2)) { angulo = angulo - 10; }
        if (Input.GetKeyDown(KeyCode.Alpha4)) { fuerza = fuerza + 10; }
        if (Input.GetKeyDown(KeyCode.Alpha4)) { fuerza = fuerza - 10; }
    

        if (Input.GetKeyDown(KeyCode.Space) && tirosRestantes > 0) //la funcion de apretar espacio con la condicion de tener tiros
        {
            tirosRestantes = tirosRestantes - 1; //aca resto un tiro, anotalo

            GameObject ave = Instantiate(avePrefab, transform.position, Quaternion.identity); // esta nn crea al prefab, que, donde y en que rotaciin

            float radianes = angulo * Mathf.Deg2Rad;
            //aja lo que entendi es que float radianes es como la cajita donde se guarda la cosa esta el ángulo ya convertido, 
            //porrrque lleva decimales (por eso float y no int btw)... Aparentemente
            //Cos y Sin solo entienden radianes (que es como una manera de medir??) y no grados, 
            //por eso se multiplica por Mathf.Deg2Rad, que significa "de grados a radianes".
        
            Vector2 direccion = new Vector2(Mathf.Cos(radianes), Mathf.Sin(radianes)); // en esta se calculaba lña direccion
        
            ave.GetComponent<Rigidbody2D>().linearVelocity = direccion * fuerza; //la velocidad, recuerda cambiar como salen al inicio

            Destroy(ave, 6f); //bajale a 6 segundos en vez de 10 porque es molesto
        }

        textoTiros.text = "Tiros: " + tirosRestantes;
    }
}