using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : Personajes {

    public float velocidad = 5;
    public GameObject bala;
    public static Direccion CurrentDirection;
    public static Direccion Bal_dir;

    public VidaManager vidaManager;
     
	// Use this for initialization
	void Start () {
        Vida = 100;
        VidaMaxima = 100;
        Fuerza = 10;
        Peso = 60;
        
        vidaManager.SetTipoPersonaje(true);
        vidaManager.CurrentVida = Vida;
        vidaManager.CurrentVidaMaxima = VidaMaxima;
        vidaManager.CurrentPeso = Peso;
        vidaManager.CurrentFuerza = Fuerza;
        
        
	}
	
	// Update is called once per frame
	void Update () {
        if (GameManager.IsPlaying)
        {
            checkAction();
        }
	}

    public void checkAction()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            disparar(Direccion.Left);
            Bal_dir = Direccion.Left;

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            disparar(Direccion.Right);
            Bal_dir = Direccion.Right;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            disparar(Direccion.Up);
            Bal_dir = Direccion.Up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            disparar(Direccion.Down);
            Bal_dir = Direccion.Down;
        }
        if (Input.GetKey(KeyCode.A))
            movimiento(Direccion.Left);
        if (Input.GetKey(KeyCode.S))
            movimiento(Direccion.Down);
        if (Input.GetKey(KeyCode.D))
            movimiento(Direccion.Right);
        if (Input.GetKey(KeyCode.W))
            movimiento(Direccion.Up);
    }

    public void movimiento(Direccion dir)
    {
        if(dir== Direccion.Down)
        {
            this.transform.Translate(0, -velocidad * Time.deltaTime,0);
        }else if (dir == Direccion.Up)
        {
            this.transform.Translate(0, velocidad * Time.deltaTime,0);
        }else if( dir == Direccion.Left)
        {
            this.transform.Translate(-velocidad * Time.deltaTime,0,0);
        }else if( dir == Direccion.Right)
        {
            this.transform.Translate(velocidad * Time.deltaTime,0,0);
        }
    }

    public void disparar(Direccion dir)
    {
        GameObject disparo = Instantiate(bala);
        var pos = this.transform.position;

        if(dir == Direccion.Left)
        {
            disparo.transform.position = new Vector3(pos.x - 3, pos.y + 1);

        }
        if (dir == Direccion.Right)
        {
            disparo.transform.position = new Vector3(pos.x + 3, pos.y + 1);
        }
        if (dir == Direccion.Up)
        {
            disparo.transform.position = new Vector3(pos.x - 1, pos.y + 5);
        }
        if (dir == Direccion.Down)
        {
            disparo.transform.position = new Vector3(pos.x +1 , pos.y + 5);
        }
    }

    
    
}

public enum Direccion
{
    Left,
    Right,
    Up,
    Down
}
