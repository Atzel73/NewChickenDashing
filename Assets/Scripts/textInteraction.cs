using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textInteraction : MonoBehaviour
{
    public TextMeshProUGUI texto;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            texto.text = "Pulsa la barra espaciadora para saltar.¡Puedes realizar hasta 3 saltos!";
            Debug.Log("Choca con el personaje");

            // Después de 3 segundos, desactiva el texto
            Invoke("DesactivarTexto", 3f);
        }
    }

    void DesactivarTexto()
    {
        texto.gameObject.SetActive(false);
    }
}
