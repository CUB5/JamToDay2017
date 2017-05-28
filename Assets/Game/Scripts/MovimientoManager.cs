using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoManager : MonoBehaviour {


    public Transform player;
    public float vel = 3;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 destino = player.position;
        float difX = destino.x - this.transform.position.x;
        float difY = destino.y - this.transform.position.y;
        float distancia;
        float difXX;
        float difYY;

        if (difX < 0)
        {
             difXX= -difX;
        }else
        {
            difXX = difX;
        }
            
        if (difX < 0)
        {
             difYY = -difY;
        }else
        {
            difYY = difY;
        }

        distancia = difXX - difYY;
        
        //Si la distancia es positiva, la X es mayor
        if (distancia > 0)
        {
            if (difX < 0)
            {
                //Se supone va para la izquierda por ser negativo la X
                this.transform.Translate(-vel * Time.deltaTime, 0, 0);
            }else
            {
                this.transform.Translate(vel * Time.deltaTime, 0, 0);
            }
            
        }
        else //Si la distancia es negativa la Y es mayor
        {
            if (difY < 0)
            {   
                //Se supone va para abajo al ser negativa la Y
                this.transform.Translate(0, -vel * Time.deltaTime, 0);
            }else
            {   
                this.transform.Translate(0, vel * Time.deltaTime, 0);
            }
        }
        
    }
}
