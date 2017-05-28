using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personajes : MonoBehaviour
{
    //Declaramos los atributos del personaje enemigo
    private int vida;
    private int vidaMaxima;
    private int fuerza;
    private int peso;

    public int Vida
    {
        get
        {
            return vida;
        }

        set
        {
            vida = value;
        }
    }

    public int Fuerza
    {
        get
        {
            return fuerza;
        }

        set
        {
            fuerza = value;
        }
    }
   
    public int Peso
    {
        get
        {
            return peso;
        }

        set
        {
            peso = value;
        }
    }
    

    public int VidaMaxima
    {
        get
        {
            return vidaMaxima;
        }

        set
        {
            vidaMaxima = value;
        }
    }

   
}
