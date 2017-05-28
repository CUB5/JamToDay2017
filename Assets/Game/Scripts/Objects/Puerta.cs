using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour {

    public int escena;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Choca");
        Debug.Log(other.tag);
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Choca Player");

            Application.LoadLevel(escena);
        }
    }
}
