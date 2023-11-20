using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class textInteractionRunning : MonoBehaviour
{
       public TextMeshProUGUI texto;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            texto.text = "Presiona B para realizar un dash";
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
