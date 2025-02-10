using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Plateau de jeu
/// </summary>
public class Plateau
{

    /// <summary>
    /// Ensemble des joueurs
    /// </summary>
    private Joueur[] joueurs;


    /// <summary>
    /// Ensemble des cases
    /// </summary>
    private Case[] cases;

    public Plateau(Joueur[] joueurs) 
    {
        this.joueurs = joueurs;
    }


}

