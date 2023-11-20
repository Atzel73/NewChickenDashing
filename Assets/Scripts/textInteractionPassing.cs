using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textInteractionPassing : MonoBehaviour
{
    public TextMeshProUGUI texto;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            texto.text = "¡El camino a la ciudad está bloqueado!";
            Debug.Log("Choca con el personaje");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Limpiar el texto cuando el jugador sale de la zona de colisión
            texto.text = "¿Y ahora te vas sin hacer algo?";
            Invoke("DesactivarTexto", 3f);
        }
    }
     void DesactivarTexto()
    {
        texto.gameObject.SetActive(false);
    }
}
