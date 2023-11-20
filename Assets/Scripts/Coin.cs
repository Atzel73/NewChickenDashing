using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public int valor = 1;
    public GameManager gameManager;

     /// <summary>
   /// Sent when another object enters a trigger collider attached to this
   /// object (2D physics only).
   /// </summary>
   /// <param name="other">The other Collider2D involved in this collision.</param>
  private void OnTriggerEnter2D(Collider2D Collision)
   {
       if (Collision.CompareTag("Player")){
        gameManager.SumarPuntos(valor);
        Destroy(this.gameObject);
       }



   }
}