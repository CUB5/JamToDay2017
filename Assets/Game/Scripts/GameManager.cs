using UnityEngine;

/*************************************************************************************************
  
  Copyright (C) UPWARE STUDIOS S.L - Todos los Derechos Reservados -

  Este proyecto ha sido realizado por la empresa UPWARE STUDIOS S.L.U como colaboración para impartir
  un taller sobre iniciación a la programación de videojuegos con la herramienta Unity3D 5 durante el 
  evento JAM TODAY ALMERÍA, que se celebra los días 27,28 y 29 de Mayo de 2016. Queda prohibida la 
  copia o distribución  de este proyecto por cualquier medio sin autorización previa.

  Por: Hilarión Luque (24/05/2016)
  Email:info@upwarestudios.com

**************************************************************************************************/

/// <summary>
/// Controla la lógica general del juego
/// </summary>
public class GameManager : MonoBehaviour
{
    /// <summary>
    /// Acción que se produce cuando se inicia una nueva partida
    /// </summary>
    public static event GameEventHandler OnNewGame;
    public static event GameEventHandler OnEndGame;

    /// <summary>
    /// Obtiene o establece si la partida está en curso
    /// </summary>
    public static bool IsPlaying;

    /// <summary>
    /// Obtiene o establece los puntos conseguidos
    /// </summary>
    public static int CurrentPoints;

    /// <summary>
    /// Obtiene o establece la mejor puntuación
    /// </summary>
    public static int BestPoints;

    /// <summary>
    /// Inicia una nueva partida
    /// </summary>
    public void NewGame()
    {
        CurrentPoints = 0;

        IsPlaying = true;

        if (OnNewGame != null)
            OnNewGame();
    }

    /// <summary>
    /// Actualiza el objeto en cada frame del juego
    /// </summary>
    void Update()
    {

        if (IsPlaying && Input.GetKey(KeyCode.Escape))
            EndGame();

        if (Input.GetKeyDown(KeyCode.R))
        {
            CurrentPoints = 0;
            PlayerPrefs.SetInt("Game.BestPoints", 0);
        }

        if (Input.GetKey(KeyCode.Escape))
            Application.Quit();
    }

    /// <summary>
    /// Termina el juego
    /// </summary>
    private void EndGame()
    {
        IsPlaying = false;

        if (OnEndGame != null)
            OnEndGame();
    }
}


/// <summary>
/// Notifica un evento del juego
/// </summary>
public delegate void GameEventHandler();

