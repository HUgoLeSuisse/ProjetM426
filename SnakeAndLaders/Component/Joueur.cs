using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Classe permettant de géré un joueur (Sa postion, son nom et sa couleur)
/// </summary>
public class Joueur
{
    /// <summary>
    /// Position acctuel du joueur
    /// </summary>
    private int postion = 0;

    /// <summary>
    /// Position acctuel du joueur
    /// </summary>
    public int Postion
    {
        get { return postion; }
    }


    /// <summary>
    /// Nom du joueur
    /// </summary>
    private string nom;

    /// <summary>
    /// Nom du joueur
    /// </summary>
    public string Nom
    {
        get { return nom; }
    }

    /// <summary>
    /// Couleur du joueur
    /// </summary>
    private Color color;

    /// <summary>
    /// Couleur du joueur
    /// </summary>
    public Color Color
    {
        get { return color; }
    }


    public Joueur(string nom, Color color)
    {
        this.nom = nom;
        this.color = color;
    }

    /// <summary>
    /// Faire avancer le joueur
    /// </summary>
    /// <param name="de"></param>
    public void Avancer(int de)
    {
        postion += de;

    }

}

