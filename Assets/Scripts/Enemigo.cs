using UnityEngine;

public class Enemigo : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.name.Contains("Ave"))
        {
            Puntaje.puntos = Puntaje.puntos + 100;
            Destroy(gameObject);
        }
    }
}