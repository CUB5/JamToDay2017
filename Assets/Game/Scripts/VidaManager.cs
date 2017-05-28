using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaManager : MonoBehaviour {
    
    public float currentVida;
    public float currentVidaMaxima;
    public float currentFuerza;
    public float currentPeso;

    public GameObject manzana, naranja, platano;
    public bool tipoPersonaje = false;

    public float CurrentVida
    {
        get
        {
            return currentVida;
        }

        set
        {
            currentVida = value;
        }
    }

    public float CurrentVidaMaxima
    {
        get
        {
            return currentVidaMaxima;
        }

        set
        {
            currentVidaMaxima = value;
        }
    }

    public float CurrentFuerza
    {
        get
        {
            return currentFuerza;
        }

        set
        {
            currentFuerza = value;
        }
    }
    

    public float CurrentPeso
    {
        get
        {
            return currentPeso;
        }

        set
        {
            currentPeso = value;
        }
    }

    public void SetTipoPersonaje(bool tipo)
    {
        tipoPersonaje = tipo;
    }
    

    //metodo generico de unity
    void OnTriggerEnter2D(Collider2D other)
    {
        if (tipoPersonaje == true)
        {
            if (other.tag == "EnemyBurguer")
            {
                int danio = other.gameObject.GetComponent<EnemyBurguer>().Fuerza;
                CurrentVida -= danio;

                enabled = false;
                Invoke("reactivar", 1);

            }

            if (other.tag == "EnemyDorito")
            {
                int danio = other.gameObject.GetComponent<EnemyDorito>().Fuerza;
                CurrentVida -= danio;

                enabled = false;
                //llamo al metodo reactivar y me tiro 1 segundo para eso!
                Invoke("reactivar", 1);
            }

            if (other.tag == "Manzana")
            {
                CurrentVidaMaxima += 5;
                CurrentFuerza += 1;
            }
            if (other.tag == "Naranja")
            {
                currentVida += 20;
                if (currentVida > currentVidaMaxima)
                {
                    currentVida = currentVidaMaxima;
                }
            }
            if (other.tag == "Platano")
            {
                currentFuerza += 2;
            }

            if (other.tag == "Agua")
            {
                currentVida += 40;
                if (currentVida > currentVidaMaxima)
                {
                    currentVida = currentVidaMaxima;
                }
            }

            if (other.tag == "RedBull")
            {
                currentFuerza += 3;
                currentVidaMaxima -= 10;
                if (currentVida > currentVidaMaxima)
                {
                    currentVida = currentVidaMaxima;
                }
            }

            if (other.tag == "Cola")
            {
                currentFuerza += 2;
                currentVidaMaxima -= 5;
                if (currentVida > currentVidaMaxima)
                {
                    currentVida = currentVidaMaxima;
                }
            }
            Debug.Log(CurrentVida);

            //Si no tienes vida te matas
            if (CurrentVida < 0)
            {
                Debug.Log("He muerto!");
                //Application.LoadLevel(0);
            }

        }else
        {
            if (other.tag == "shot")
            {
                //Si es true significa que es el jugador

                drop();
                Destroy(this.gameObject);
            }
        }
        
    }

    public void reactivar()
    {
        enabled = true;
    }


    public void drop()
    {
        int random = Random.Range(0, 10);

        if (random < 3)
        {
            //llamamos a manzana
            Instantiate(manzana);
        }
        else if (random > 3 && random < 6)
        {
            //declaramos la naranja
            Instantiate(naranja);
        }
        else
        {
            //declaramos el platano
            Instantiate(platano);
        }



    }
}
