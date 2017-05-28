using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {

    public int dirX = 0;
    public int dirY = 0;
    public float vel = 15;

	// Use this for initialization
	void Start () {

        if (PlayerManager.Bal_dir == Direccion.Left)
            dirX = -1;

        else if (PlayerManager.Bal_dir == Direccion.Right)
            dirX = 1;

        else if (PlayerManager.Bal_dir == Direccion.Up)
            dirY = 1;

        else if (PlayerManager.Bal_dir == Direccion.Down)
            dirY = -1;
		
	}
	
	// Update is called once per frame
	void Update () {

        
        this.transform.Translate(vel * dirX * Time.deltaTime, vel * dirY * Time.deltaTime, 0);
        




        Destroy(this.gameObject);
		
	}
}
