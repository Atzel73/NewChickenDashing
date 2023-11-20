using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class textInteractionLifes : MonoBehaviour
{
      public TextMeshProUGUI texto;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            texto.text = "Toca corazones para recuperar vida" + "¡Huye de los enemigos!";
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
