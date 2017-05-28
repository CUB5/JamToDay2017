using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBurguer : Personajes {

    public VidaManager vidaManager;

    // Use this for initialization
    void Start() {
        //inicializamos las variables
        Vida = 30;
        Fuerza = 10;

        //vidaManager.SetLife(Vida);

    }

    

}



